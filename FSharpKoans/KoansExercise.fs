namespace FSharpKoans
open FSharpKoans.Core

//---------------------------------------------------------------
// Getting Started
//
// The F# Koans are a set of exercises designed to get you familiar
// with F#. By the time you're done, you'll have a basic
// understanding of the syntax of F# and learn a little more
// about functional programming in general.
//
// Answering Problems
//
// This is where the fun begins! Each Koan method contains
// an example designed to teach you a lesson about the F# language.
// If you execute the program defined in this project, you will get
// a message that the AssertEquality koan below has failed. Your
// job is to fill in the blank (the __ symbol) to make it pass. Once
// you make the change, re-run the program to make sure the koan
// passes, and continue on to the next failing koan.  With each
// passing koan, you'll learn more about F#, and add another
// weapon to your F# programming arsenal.
//---------------------------------------------------------------
[<Koan(Sort = 1)>]
module KoansExercise =

    [<Koan>]
    let AssertExpectation() =
        let expectedValue = 1 + 1
        let actualValue = 2 //start by changing this line

        AssertEquality expectedValue actualValue

    //Easy, right? Now try one more
    [<Koan>]
    let FillInValues() =
        AssertEquality (1 + 1) 2

    [<Koan>]
    let HexadecimalsLiterals() =
        let actualValue = 0x29 + 0x0D

        AssertEquality 54 actualValue

    [<Koan>]
    let BinaryLiterals() =
        let actualValue = 0b00101010 + 0b00000101

        AssertEquality 47 actualValue

    [<Koan>]
    let NestedScopes() =
        let actualValue =
            let x = 8 + 17
            x

        AssertEquality 25 actualValue

    [<Koan>]
    let StringConcatValue() =
        let message = "hello " + "world"

        AssertEquality message "hello world"

    [<Koan>]
    let FormatStringLiterals() =
        let num = 0x91
        let actualValue = $"An intresting number: '{num}'"

        AssertEquality "An intresting number: '145'" actualValue

    [<Koan>]
    let AppendingToAList() =
        let initalValue = [2; 3]

        let result = 1:: initalValue

        AssertEquality [1; 2; 3] result

    [<Koan>]
    let FirstFunction() =
        let compute x = x * 6

        let result1 = compute 2
        let result2 = compute 5
        let result3 = compute 7
        let result4 = compute 9

        AssertEquality 12 result1
        AssertEquality 30 result2
        AssertEquality 42 result3
        AssertEquality 54 result4

    [<Koan>]
    let NestingFunctions() =
        let quadruple x =
            let double x =
                x * 2

            double(double(x))

        let result = quadruple 4
        AssertEquality result 16

    [<Koan>]
    let VariablesInTheParentScopeCanBeAccessed() =
        let suffix = "!!!"

        let caffeinate (text:string) =
            let exclaimed = text.Trim() + suffix
            let yelled = exclaimed.ToUpper()
            yelled

        let caffeinatedReply = caffeinate "hello there"

        AssertEquality caffeinatedReply "HELLO THERE!!!"

    [<Koan>]
    let FirstPartialFunction() =
        let sub x y = x - y

        let subFrom50 = sub 50

        let result1 = subFrom50 10
        let result2 = subFrom50 20
        let result3 = subFrom50 30
        let result4 = subFrom50 40

        AssertEquality 40 result1
        AssertEquality 30 result2
        AssertEquality 20 result3
        AssertEquality 10 result4

    [<Koan>]
    let SometimesYouNeedParenthesisToGroupThings() =
        let add x y =
            x + y

        // TRY IT: What happens if you remove the parenthesis?
        let result = add (add 5 8) (add 1 1)

        AssertEquality result 15

    [<Koan>]
    let StringFormattingRevisited() =
        // It's time to apply what you've learned so far. Fill in the function below to
        // make the asserts pass
        let getFunFacts x =
            $"{x} doubled is {x * 2}, and {x} tripled is {x * 3}!"

        let funFactsAboutThree = getFunFacts 3
        let funFactsAboutSix = getFunFacts 6

        AssertEquality "3 doubled is 6, and 3 tripled is 9!" funFactsAboutThree
        AssertEquality "6 doubled is 12, and 6 tripled is 18!" funFactsAboutSix

    [<Koan>]
    let CreatingLists() =
        let list = ["apple"; "pear"; "grape"; "peach"]

        //Note: The list data type in F# is a singly linked list,
        //      so indexing elements is O(n).

        AssertEquality list.Head "apple"
        AssertEquality list.Tail ["pear"; "grape"; "peach"]
        AssertEquality list.Length 4

    [<Koan>]
    let CreatingListsWithARange() =
        let list = [0..4]

        AssertEquality list.Head 0
        AssertEquality list.Tail [1; 2; 3; 4]; 

    [<Koan>]
    let ReversingAList() =
        let initalValue = [1; 2; 3]

        let result = List.rev initalValue

        AssertEquality [3; 2; 1] result

    [<Koan>]
    let SortingAList() =
        let initalValue = [7; 3; 6; 5; 2]

        let result = List.sort initalValue

        AssertEquality [2; 3; 5; 6; 7] result

    [<Koan>]
    let SortingAWordListByLength() =
        let initalValue = ["Twas"; "brillig"; "and"; "the"; "slithy"; "toves"; ]

        let result = initalValue |> List.sortBy(fun x -> x.Length)

        AssertEquality ["and"; "the"; "Twas"; "toves"; "slithy"; "brillig"] result

    [<Koan>]
    let SquareNumberList() =
        let initalValue = [1 .. 5]

        let result = initalValue |> List.map (fun x -> x*x)

        AssertEquality [1; 4; 9; 16; 25] result

    [<Koan>]
    let ConvertNumbersToString() =
        let initalValue = [1 .. 5]

        let result = initalValue |> List.map (fun x -> x.ToString())

        AssertEquality ["1"; "2"; "3"; "4"; "5"] result

    [<Koan>]
    let MultiplyAllElementsBy10() =
        let initalValue = [1 .. 5]

        let result = initalValue |> List.map (fun x -> x * 10)

        AssertEquality [10; 20; 30; 40; 50] result

    [<Koan>]
    let CountNumberOfUniqueWords() =
        let initalValue =
            ["water"; "water"; "every"; "where";
             "nor"; "any"; "drop"; "to"; "drink" ]

        let result = initalValue |> List.distinct |> List.length

        AssertEquality 8 result

    [<Koan>]
    let FindLargestNumberInAList() =
        let initalValue = [22; 6; 89; 33; 45; 10; 21; 67]

        let result = initalValue |> List.max

        AssertEquality 89 result

    [<Koan>]
    let SumAList() =
        let initalValue = [1 .. 5]

        let result = List.sum initalValue

        AssertEquality 15 result

    [<Koan>]
    let FliterOutOddNumberFromAList() =
        let initalValue = [1 .. 10]

        let result = initalValue |> List.filter (fun x -> x%2 = 0)

        AssertEquality [2; 4; 6; 8; 10] result

    [<Koan>]
    let ComputerTheAverageNumberOfLetters() =
        let initalValue =
            ["It"; "is"; "an"; "ancient"; "Mariner";
             "And"; "he"; "stoppeth"; "one"; "of"; "three";
             "By"; "thy"; "long"; "grey"; "beard"; "and"; "glittering"; "eye";
             "Now"; "wherefore"; "stoppst"; "thou"; "me"]

        let result = initalValue |> List.averageBy (fun x -> float x.Length) 
        AssertEquality
            4.25
            result

    [<Koan>]
    let TestIfEverWordContainsTheLetterA() =
        let test (l: list<string>) =
            l |> List.forall (fun x -> x.Contains("a"))

        AssertEquality
            true
            (test ["day"; "after"; "day"; "day"; "after"; "day"])

        AssertEquality
            false
            (test ["we"; "stuck"; "nor"; "breath"; "nor"; "motion"])


    [<Koan>]
    let CaesarCipher() =
        let initalValue = "Encode me!" |> List.ofSeq

        let encodeLetter (x:char) = 
            match x with
            |x when System.Char.IsLower x -> (int x - 97 + 13)% 26 + 97 |> char
            |x when System.Char.IsUpper x -> (int x - 65 + 13)% 26 + 65 |> char
            |_ -> x

        let encoder (l: list<char>) =
            l |> List.map encodeLetter

        let encoded = encoder initalValue
        let decoded = encoder encoded

        AssertEquality
            ['R'; 'a'; 'p'; 'b'; 'q'; 'r'; ' '; 'z'; 'r'; '!']
            encoded

        AssertEquality
            ['E'; 'n'; 'c'; 'o'; 'd'; 'e'; ' '; 'm'; 'e'; '!']
            decoded

    [<Koan>]
    let TestIfAWordHasNoRepeatingLetter() =
        let test (s: string) =
            (s |> List.ofSeq |> List.distinct) = (s |> List.ofSeq)

        AssertEquality
            true
            (test "cornflakes")

        AssertEquality
            false
            (test "cheerios")
