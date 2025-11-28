using System;

// Código adaptado do exercício coloso_pets — objetivo: testar o loop do menu e switch-case

// the ourAnimals array will store the following:
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";
string suggestedDonation = "";

// variables that support data entry
int maxPets = 8;
string? readResult = null;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 7];

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    // usando switch para melhorar a legibilidade
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            suggestedDonation = "49.99";
            break;

        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            suggestedDonation = "40.00";
            break;

        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            suggestedDonation = "";
            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            suggestedDonation = "";
            break;
    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;

    if (!decimal.TryParse(suggestedDonation, out decimalDonation)){
        decimalDonation = 45.00m; // if suggestedDonation NOT a number, default to 45.00
    }
    ourAnimals[i, 6] = $"Suggested Donation: {decimalDonation:C2}";
}

// loop do menu principal — repete até o usuário digitar "sair"
bool running = true;
while (running)
{
    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine(" 5. Edit an animal’s age");
    Console.WriteLine(" 6. Edit an animal’s personality description");
    Console.WriteLine(" 7. Display all cats with a specified characteristic");
    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (1-8) or type 'sair' to exit the program:");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.Trim().ToLower();
    }
    else
    {
        menuSelection = "";
    }

    if (menuSelection == "sair" || menuSelection == "exit")
    {
        Console.WriteLine("Saindo do programa. Pressione Enter para finalizar...");
        Console.ReadLine();
        break;
    }

    // switch-case para ramificações de menu; por enquanto, cada case contém um placeholder
    switch (menuSelection)
    {
        case "1":
            // listar todos os animais atualmente cadastrados
            Console.WriteLine("Listando todos os animais atualmente cadastrados:\n");
            for (int idx = 0; idx < maxPets; idx++)
            {
                // pulamos entradas vazias (ID vazio)
                if (!string.IsNullOrWhiteSpace(ourAnimals[idx, 0]) && ourAnimals[idx, 0] != "ID #: ")
                {
                    Console.WriteLine($"-- Animal {idx + 1} --");
                    Console.WriteLine(ourAnimals[idx, 0]);
                    Console.WriteLine(ourAnimals[idx, 1]);
                    Console.WriteLine(ourAnimals[idx, 2]);
                    Console.WriteLine(ourAnimals[idx, 3]);
                    Console.WriteLine(ourAnimals[idx, 4]);
                    Console.WriteLine(ourAnimals[idx, 5]);
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Fim da listagem. Pressione Enter para retornar ao menu...");
            Console.ReadLine();
            break;

        case "2":
            // Add a new animal friend to the ourAnimals array
            string anotherPet = "y";
            int petCount = 0;
            for (int i = 0; i < maxPets; i++)
            {
                if (!string.IsNullOrWhiteSpace(ourAnimals[i, 0]) && ourAnimals[i, 0] != "ID #: ")
                {
                    petCount += 1;
                }
            }

            if (petCount < maxPets)
            {
                Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
            }

            while (anotherPet == "y" && petCount < maxPets)
            {
                // validate species entry
                bool validEntry = false;
                // get species (cat or dog) - string animalSpecies is a required field
                do
                {
                    Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalSpecies = readResult.ToLower();
                        if (animalSpecies != "dog" && animalSpecies != "cat")
                        {
                            validEntry = false;
                        }
                        else
                        {
                            validEntry = true;
                        }
                    }
                } while (validEntry == false);

                // build the animal ID number - for example C1, C2, D3 (for Cat 1, Cat 2, Dog 3)
                animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();

                // get the pet's age. can be ? at initial entry.
                do
                {
                    int petAge;
                    Console.WriteLine("Enter the pet's age or enter ? if unknown");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalAge = readResult;
                        if (animalAge != "?")
                        {
                            validEntry = int.TryParse(animalAge, out petAge);
                        }
                        else
                        {
                            validEntry = true;
                        }
                    }
                } while (validEntry == false);

                // get a description of the pet's physical appearance/condition - animalPhysicalDescription can be blank.
                do
                {
                    Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPhysicalDescription = readResult.ToLower();
                        if (animalPhysicalDescription == "")
                        {
                            animalPhysicalDescription = "tbd";
                        }
                    }
                } while (animalPhysicalDescription == "");

                // get a description of the pet's personality - animalPersonalityDescription can be blank.
                do
                {
                    Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPersonalityDescription = readResult.ToLower();
                        if (animalPersonalityDescription == "")
                        {
                            animalPersonalityDescription = "tbd";
                        }
                    }
                } while (animalPersonalityDescription == "");

                // get the pet's nickname. animalNickname can be blank.
                do
                {
                    Console.WriteLine("Enter a nickname for the pet");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalNickname = readResult.ToLower();
                        if (animalNickname == "")
                        {
                            animalNickname = "tbd";
                        }
                    }
                } while (animalNickname == "");

                // store the pet information in the ourAnimals array (zero based)
                ourAnimals[petCount, 0] = "ID #: " + animalID;
                ourAnimals[petCount, 1] = "Species: " + animalSpecies;
                ourAnimals[petCount, 2] = "Age: " + animalAge;
                ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
                ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
                ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

                // increment petCount (the array is zero-based, so we increment the counter after adding to the array)
                petCount = petCount + 1;

                // check maxPet limit
                if (petCount < maxPets)
                {
                    // another pet?
                    Console.WriteLine("Do you want to enter info for another pet (y/n)");
                    do
                    {
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            anotherPet = readResult.ToLower();
                        }

                    } while (anotherPet != "y" && anotherPet != "n");
                }
            }

            if (petCount >= maxPets)
            {
                Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
                Console.WriteLine("Press the Enter key to continue.");
                readResult = Console.ReadLine();
            }

            break;

        case "3":
            // Ensure animal ages and physical descriptions are complete
            Console.WriteLine("Verificando idades e descrições físicas dos animais...");

            for (int idx = 0; idx < maxPets; idx++)
            {
                // skip entries that are default/empty
                if (string.IsNullOrWhiteSpace(ourAnimals[idx, 0]) || ourAnimals[idx, 0] == "ID #: ")
                {
                    continue;
                }

                // show the current ID
                Console.WriteLine($"\nVerificando {ourAnimals[idx, 0]}");

                // --- validate age ---
                // ourAnimals[idx,2] is like "Age: 2" or "Age: ?"
                string currentAgeField = ourAnimals[idx, 2] ?? "";
                string currentAge = currentAgeField.Replace("Age:", "").Trim();

                int parsedAge;
                while (!int.TryParse(currentAge, out parsedAge))
                {
                    Console.WriteLine($"Idade ausente ou inválida (atual: '{currentAge}'). Digite uma idade numérica para {ourAnimals[idx, 0]}:");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        currentAge = readResult.Trim();
                    }
                    else
                    {
                        currentAge = "";
                    }
                }
                // assign validated age back to array
                ourAnimals[idx, 2] = "Age: " + parsedAge.ToString();

                // --- validate physical description ---
                string currentPhysField = ourAnimals[idx, 4] ?? "";
                string phys = currentPhysField.Replace("Physical description:", "").Trim();

                while (string.IsNullOrEmpty(phys))
                {
                    Console.WriteLine($"Descrição física ausente para {ourAnimals[idx, 0]}. Insira uma descrição física (tamanho, cor, gênero, peso, housebroken):");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        phys = readResult.Trim();
                    }
                    else
                    {
                        phys = "";
                    }
                }
                ourAnimals[idx, 4] = "Physical description: " + phys;
            }

            Console.WriteLine("\nTodos os animais cadastrados têm idades numéricas válidas e descrições físicas preenchidas.");
            Console.WriteLine("Pressione Enter para retornar ao menu...");
            Console.ReadLine();
            break;

        case "4":
            // Ensure animal nicknames and personality descriptions are complete
            Console.WriteLine("Verificando apelidos e descrições de personalidade dos animais...");

            for (int idx = 0; idx < maxPets; idx++)
            {
                // skip entries that are default/empty
                if (string.IsNullOrWhiteSpace(ourAnimals[idx, 0]) || ourAnimals[idx, 0] == "ID #: ")
                {
                    continue;
                }

                Console.WriteLine($"\nEnter a nickname for {ourAnimals[idx, 0]}");
                string currentNickField = ourAnimals[idx, 3] ?? "";
                string nick = currentNickField.Replace("Nickname:", "").Trim();

                while (string.IsNullOrEmpty(nick))
                {
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        nick = readResult.Trim();
                    }
                    else
                    {
                        nick = "";
                    }
                    if (string.IsNullOrEmpty(nick))
                    {
                        Console.WriteLine($"Enter a nickname for {ourAnimals[idx, 0]}");
                    }
                }
                ourAnimals[idx, 3] = "Nickname: " + nick;

                // personality
                Console.WriteLine($"Enter a personality description for {ourAnimals[idx, 0]} (likes or dislikes, tricks, energy level)");
                string currentPersField = ourAnimals[idx, 5] ?? "";
                string pers = currentPersField.Replace("Personality:", "").Trim();

                while (string.IsNullOrEmpty(pers))
                {
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        pers = readResult.Trim();
                    }
                    else
                    {
                        pers = "";
                    }
                    if (string.IsNullOrEmpty(pers))
                    {
                        Console.WriteLine($"Enter a personality description for {ourAnimals[idx, 0]} (likes or dislikes, tricks, energy level)");
                    }
                }
                ourAnimals[idx, 5] = "Personality: " + pers;
            }

            Console.WriteLine("\nNickname and personality description fields are complete for all of our friends.");
            Console.WriteLine("Press the Enter key to continue");
            Console.ReadLine();
            break;

        case "5":
            Console.WriteLine("Opção 5: Editar idade do animal — recurso ainda não implementado. (placeholder)");
            Console.WriteLine("Pressione Enter para retornar ao menu...");
            Console.ReadLine();
            break;

        case "6":
            Console.WriteLine("Opção 6: Editar descrição de personalidade — recurso ainda não implementado. (placeholder)");
            Console.WriteLine("Pressione Enter para retornar ao menu...");
            Console.ReadLine();
            break;

        case "7":
            Console.WriteLine("Opção 7: Exibir gatos com característica especificada — recurso ainda não implementado. (placeholder)");
            Console.WriteLine("Pressione Enter para retornar ao menu...");
            Console.ReadLine();
            break;

        case "8":
            Console.WriteLine("Opção 8: Exibir cães com característica especificada — recurso ainda não implementado. (placeholder)");
            Console.WriteLine("Pressione Enter para retornar ao menu...");
            Console.ReadLine();
            break;

        default:
            Console.WriteLine($"Seleção inválida: '{menuSelection}'. Por favor, escolha uma opção entre 1 e 8, ou digite 'sair' para encerrar.");
            Console.WriteLine("Pressione Enter para retornar ao menu...");
            Console.ReadLine();
            break;
    }
}
