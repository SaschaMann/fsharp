module AnnalynsInfiltrationTests

open FsUnit.Xunit
open Xunit
open Exercism.Tests

open AnnalynsInfiltration

[<Fact>]
[<Task(1)>]
let ``Cannot execute fast attack if knight is awake``() =
    let knightIsAwake = true
    canFastAttack knightIsAwake |> should equal false

[<Fact(Skip = "Remove this Skip property to run this test")>]
[<Task(1)>]
let ``Can execute fast attack if knight is sleeping``() =
    let knightIsAwake = false
    canFastAttack knightIsAwake |> should equal true

[<Fact(Skip = "Remove this Skip property to run this test")>]
[<Task(2)>]
let ``Cannot spy if everyone is sleeping``() =
    let knightIsAwake = false
    let archerIsAwake = false
    let prisonerIsAwake = false
    canSpy knightIsAwake archerIsAwake prisonerIsAwake |> should equal false

[<Fact(Skip = "Remove this Skip property to run this test")>]
[<Task(2)>]
let ``Can spy if everyone but knight is sleeping``() =
    let knightIsAwake = true
    let archerIsAwake = false
    let prisonerIsAwake = false
    canSpy knightIsAwake archerIsAwake prisonerIsAwake |> should equal true

[<Fact(Skip = "Remove this Skip property to run this test")>]
[<Task(2)>]
let ``Can spy if everyone but archer is sleeping``() =
    let knightIsAwake = false
    let archerIsAwake = true
    let prisonerIsAwake = false
    canSpy knightIsAwake archerIsAwake prisonerIsAwake |> should equal true

[<Fact(Skip = "Remove this Skip property to run this test")>]
[<Task(2)>]
let ``Can spy if everyone but prisoner is sleeping``() =
    let knightIsAwake = false
    let archerIsAwake = false
    let prisonerIsAwake = true
    canSpy knightIsAwake archerIsAwake prisonerIsAwake |> should equal true

[<Fact(Skip = "Remove this Skip property to run this test")>]
[<Task(2)>]
let ``Can spy if only knight is sleeping``() =
    let knightIsAwake = false
    let archerIsAwake = true
    let prisonerIsAwake = true
    canSpy knightIsAwake archerIsAwake prisonerIsAwake |> should equal true

[<Fact(Skip = "Remove this Skip property to run this test")>]
[<Task(2)>]
let ``Can spy if only archer is sleeping``() =
    let knightIsAwake = true
    let archerIsAwake = false
    let prisonerIsAwake = true
    canSpy knightIsAwake archerIsAwake prisonerIsAwake |> should equal true

[<Fact(Skip = "Remove this Skip property to run this test")>]
[<Task(2)>]
let ``Can spy if only prisoner is sleeping``() =
    let knightIsAwake = true
    let archerIsAwake = true
    let prisonerIsAwake = false
    canSpy knightIsAwake archerIsAwake prisonerIsAwake |> should equal true

[<Fact(Skip = "Remove this Skip property to run this test")>]
[<Task(2)>]
let ``Can spy if everyone is awake``() =
    let knightIsAwake = true
    let archerIsAwake = true
    let prisonerIsAwake = true
    canSpy knightIsAwake archerIsAwake prisonerIsAwake |> should equal true

[<Fact(Skip = "Remove this Skip property to run this test")>]
[<Task(3)>]
let ``Can signal prisoner if archer is sleeping and prisoner is awake``() =
    let archerIsAwake = false
    let prisonerIsAwake = true
    canSignalPrisoner archerIsAwake prisonerIsAwake |> should equal true

[<Fact(Skip = "Remove this Skip property to run this test")>]
[<Task(3)>]
let ``Cannot signal prisoner if archer is awake and prisoner is sleeping``() =
    let archerIsAwake = true
    let prisonerIsAwake = false
    canSignalPrisoner archerIsAwake prisonerIsAwake |> should equal false

[<Fact(Skip = "Remove this Skip property to run this test")>]
[<Task(3)>]
let ``Cannot signal prisoner if archer and prisoner are both sleeping``() =
    let archerIsAwake = false
    let prisonerIsAwake = false
    canSignalPrisoner archerIsAwake prisonerIsAwake |> should equal false

[<Fact(Skip = "Remove this Skip property to run this test")>]
[<Task(3)>]
let ``Cannot signal prisoner if archer and prisoner are both awake``() =
    let archerIsAwake = true
    let prisonerIsAwake = true
    canSignalPrisoner archerIsAwake prisonerIsAwake |> should equal false

[<Fact(Skip = "Remove this Skip property to run this test")>]
[<Task(4)>]
let ``Cannot free prisoner if everyone is awake and pet dog is present``() =
    let knightIsAwake = true
    let archerIsAwake = true
    let prisonerIsAwake = true
    let petDogIsPresent = true
    canFreePrisoner knightIsAwake archerIsAwake prisonerIsAwake petDogIsPresent |> should equal false

[<Fact(Skip = "Remove this Skip property to run this test")>]
[<Task(4)>]
let ``Cannot free prisoner if everyone is awake and pet dog is absent``() =
    let knightIsAwake = true
    let archerIsAwake = true
    let prisonerIsAwake = true
    let petDogIsPresent = false
    canFreePrisoner knightIsAwake archerIsAwake prisonerIsAwake petDogIsPresent |> should equal false

[<Fact(Skip = "Remove this Skip property to run this test")>]
[<Task(4)>]
let ``Can free prisoner if everyone is asleep and pet dog is present``() =
    let knightIsAwake = false
    let archerIsAwake = false
    let prisonerIsAwake = false
    let petDogIsPresent = true
    canFreePrisoner knightIsAwake archerIsAwake prisonerIsAwake petDogIsPresent |> should equal true

[<Fact(Skip = "Remove this Skip property to run this test")>]
[<Task(4)>]
let ``Cannot free prisoner if everyone is asleep and pet dog is absent``() =
    let knightIsAwake = false
    let archerIsAwake = false
    let prisonerIsAwake = false
    let petDogIsPresent = false
    canFreePrisoner knightIsAwake archerIsAwake prisonerIsAwake petDogIsPresent |> should equal false

[<Fact(Skip = "Remove this Skip property to run this test")>]
[<Task(4)>]
let ``Can free prisoner if only prisoner is awake and pet dog is present``() =
    let knightIsAwake = false
    let archerIsAwake = false
    let prisonerIsAwake = true
    let petDogIsPresent = true
    canFreePrisoner knightIsAwake archerIsAwake prisonerIsAwake petDogIsPresent |> should equal true

[<Fact(Skip = "Remove this Skip property to run this test")>]
[<Task(4)>]
let ``Can free prisoner if only prisoner is awake and pet dog is absent``() =
    let knightIsAwake = false
    let archerIsAwake = false
    let prisonerIsAwake = true
    let petDogIsPresent = false
    canFreePrisoner knightIsAwake archerIsAwake prisonerIsAwake petDogIsPresent |> should equal true

[<Fact(Skip = "Remove this Skip property to run this test")>]
[<Task(4)>]
let ``Cannot free prisoner if only archer is awake and pet dog is present``() =
    let knightIsAwake = false
    let archerIsAwake = true
    let prisonerIsAwake = false
    let petDogIsPresent = true
    canFreePrisoner knightIsAwake archerIsAwake prisonerIsAwake petDogIsPresent |> should equal false

[<Fact(Skip = "Remove this Skip property to run this test")>]
[<Task(4)>]
let ``Cannot free prisoner if only archer is awake and pet dog is absent``() =
    let knightIsAwake = false
    let archerIsAwake = true
    let prisonerIsAwake = false
    let petDogIsPresent = false
    canFreePrisoner knightIsAwake archerIsAwake prisonerIsAwake petDogIsPresent |> should equal false

[<Fact(Skip = "Remove this Skip property to run this test")>]
[<Task(4)>]
let ``Can free prisoner if only knight is awake and pet dog is present``() =
    let knightIsAwake = true
    let archerIsAwake = false
    let prisonerIsAwake = false
    let petDogIsPresent = true
    canFreePrisoner knightIsAwake archerIsAwake prisonerIsAwake petDogIsPresent |> should equal true

[<Fact(Skip = "Remove this Skip property to run this test")>]
[<Task(4)>]
let ``Cannot free prisoner if only knight is awake and pet dog is absent``() =
    let knightIsAwake = true
    let archerIsAwake = false
    let prisonerIsAwake = false
    let petDogIsPresent = false
    canFreePrisoner knightIsAwake archerIsAwake prisonerIsAwake petDogIsPresent |> should equal false

[<Fact(Skip = "Remove this Skip property to run this test")>]
[<Task(4)>]
let ``Cannot free prisoner if only knight is asleep and pet dog is present``() =
    let knightIsAwake = false
    let archerIsAwake = true
    let prisonerIsAwake = true
    let petDogIsPresent = true
    canFreePrisoner knightIsAwake archerIsAwake prisonerIsAwake petDogIsPresent |> should equal false

[<Fact(Skip = "Remove this Skip property to run this test")>]
[<Task(4)>]
let ``Cannot free prisoner if only knight is asleep and pet dog is absent``() =
    let knightIsAwake = false
    let archerIsAwake = true
    let prisonerIsAwake = true
    let petDogIsPresent = false
    canFreePrisoner knightIsAwake archerIsAwake prisonerIsAwake petDogIsPresent |> should equal false

[<Fact(Skip = "Remove this Skip property to run this test")>]
[<Task(4)>]
let ``Can free prisoner if only archer is asleep and pet dog is present``() =
    let knightIsAwake = true
    let archerIsAwake = false
    let prisonerIsAwake = true
    let petDogIsPresent = true
    canFreePrisoner knightIsAwake archerIsAwake prisonerIsAwake petDogIsPresent |> should equal true

[<Fact(Skip = "Remove this Skip property to run this test")>]
[<Task(4)>]
let ``Cannot free prisoner if only archer is asleep and pet dog is absent``() =
    let knightIsAwake = true
    let archerIsAwake = false
    let prisonerIsAwake = true
    let petDogIsPresent = false
    canFreePrisoner knightIsAwake archerIsAwake prisonerIsAwake petDogIsPresent |> should equal false

[<Fact(Skip = "Remove this Skip property to run this test")>]
[<Task(4)>]
let ``Cannot free prisoner if only prisoner is asleep and pet dog is present``() =
    let knightIsAwake = true
    let archerIsAwake = true
    let prisonerIsAwake = false
    let petDogIsPresent = true
    canFreePrisoner knightIsAwake archerIsAwake prisonerIsAwake petDogIsPresent |> should equal false

[<Fact(Skip = "Remove this Skip property to run this test")>]
[<Task(4)>]
let ``Cannot free prisoner if only prisoner is asleep and pet dog is absent``() =
    let knightIsAwake = true
    let archerIsAwake = true
    let prisonerIsAwake = false
    let petDogIsPresent = false
    canFreePrisoner knightIsAwake archerIsAwake prisonerIsAwake petDogIsPresent |> should equal false
