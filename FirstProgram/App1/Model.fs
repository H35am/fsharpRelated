module Model

type Details =
    {
    Name: string
    Description: string
    }

type Item =
    {
    Details: Details
    }
 
 type RoomId =
    | RoomId of string

 // descriminated unions
 type Exit =
    | PassableExit of string * destination: RoomId
    | LockedExit of string * key: Item * next: Exit 
    | NoExit of string option
    
type Exits =
    {
    North: Exit
    South: Exit
    West: Exit
    East: Exit 
     }

type Room =
    {
    Id : RoomId
    Details: Details
    Items: Item list
    Exits: Exits 
    }

type Player = 
    {
    Details: Details
    Location : RoomId
    Inventory: Item list
    }

type World = 
    {
    Rooms: Map<RoomId, Room>
    Player: Player
    }

//let key: Item =

let allRooms = [
    {
    Id = RoomId "center"
    Details = {
               Name = "A central room"
               Description = "You are standing in a central room" 
               }
    Items = []
    Exits = 
          {
          North = PassableExit("You see a passible exit", RoomId "center")
          South = NoExit None
          East = NoExit None
          West = NoExit None
          }
    }
    Id = RoomId "North"
    Details = {
               Name = "A north room"
               Description = "You are standing in a north room" 
               }
    Items = []
    Exits = 
          {
          North = NoExit None 
          South = NoExit None
          East = PassableExit("You see a passible exit", RoomId "north")
          West = NoExit None
          }
    }
]


let firstRoom =
    {
    Details = {Name = "First Room"; Description = "You're standing in a room!"};
      Items = [];
      Exits = {
               North = NoExit(None);
               South = NoExit(None); 
               East = NoExit(None);
               West = NoExit(None);
               }
      }