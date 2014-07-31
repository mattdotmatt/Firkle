open Xunit // import namespace
open FirkleServer

[<Fact>]   // test
let game_should_find_existing_game() =

    let getCurrentGameFromDb = 12

    let gamePlay = FirkleServer.GamePlay.CurrentGame getCurrentGameFromDb
    Assert.Equal(12, gamePlay)
