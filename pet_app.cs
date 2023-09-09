// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6]; // this is a multidimensional array wherein string ourAnimals has length of maxpets which is 8 and can take 6 arguments per count, "," after te string is for denoting 2d arrays
// string[,,] 3darrr = new string[ whatever goes here], this is a 3d array.
