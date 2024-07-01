
using MyLibrary.ElementClasses;
Console.OutputEncoding = System.Text.Encoding.UTF8;
string email = "miritagiyev@gmail.com";
string password = "mt123";

// Login page --> start
#region Login Form
{
    Console.WriteLine("Sisteme daxil olun:");
    Console.WriteLine("------------------\n");
    Console.Write("E-mail:");
    string inputEmail = Console.ReadLine();
    Console.Write("Şifrə:");
    string inputPassword = Console.ReadLine();
    Console.Clear();
    #endregion
    if (inputEmail == email && inputPassword == password)
    {
        var library = new Library("Wunsch", 1, 1, 1);

        PrintMessage($"Salam! {library.LibraryName} kitabxanasına xoş gəlmişsiniz!", ConsoleColor.Blue);

        // Main Menu --> start
        #region Main Menu
        Console.WriteLine("Baxmaq istədiyiniz nədir?");
        string menu = "1.Kitablar\n" +
            "2.Jurnallar\n" +
            "3.Səsli kitablar\n" +
            "4.Çıxış";
        Console.WriteLine(menu);
        Console.Write("Emeliyyat nomresini secin:");
        int.TryParse(Console.ReadLine(), out int operationNumber);
        Console.Clear();
        #endregion
        // Main Menu --> end

        switch (operationNumber)
        {
            case 1:
                #region Book Operations
                bool isContinue = true;
                do
                {
                    #region Book Menu
                    string bookMenu = "1.Kitabların siyahısı\n" +
                                      "2.Yeni kitab əlavə et\n" +
                                      "3.Kitab sil\n" +
                                      "4.Kitab axtar\n" +
                                      "5.Kitabı kirayə ver";
                    Console.WriteLine(bookMenu);
                    Console.Write("Əməliyyat nömrəsini seçin:");
                    int.TryParse(Console.ReadLine(), out int operationNumberBook);
                    Console.Clear();
                    #endregion
                    switch (operationNumberBook)
                    {
                        case 1:
                            {
                                #region Get Book List
                                library.GetBookList();
                                Console.WriteLine("\n");
                                #endregion
                            }
                            break;
                        case 2:
                            {
                                #region Add Book Form
                                Console.Write("Kitab adı:");
                                string name = Console.ReadLine();
                                Console.WriteLine("-----------");
                                Console.Write("Yazıçı:");
                                string author = Console.ReadLine();
                                Console.WriteLine("-----------");
                                Console.Write("Nəşriyyat ili:");
                                int.TryParse(Console.ReadLine(), out int year);
                                Console.WriteLine("-----------");
                                Console.Write("Janrı:");
                                string type = Console.ReadLine();
                                bool rent = false;
                                Book book = new Book()
                                {
                                    BookName = name,
                                    Author = author,
                                    Type = type,
                                    IsRented = rent,
                                    Year = year
                                };
                                library.CreateBook(book);
                                PrintMessage("Kitab uğurla əlavə olundu!", ConsoleColor.Green);
                                #endregion
                            }
                            break;
                        case 3:
                            library.GetBookList();
                            Console.Write("Siləcəyiniz kitabı seçin:");
                            int.TryParse(Console.ReadLine(), out int index);
                            index = index - 1;
                            var result = library.DeleteBook(index);
                            if (result)
                            {
                                PrintMessage("Kitab uğurla silindi!", ConsoleColor.Green);
                            }
                            else
                            {
                                PrintMessage("Bir xəta baş verdi!", ConsoleColor.Red);
                            }
                            break;
                        case 4:
                            {
                                Console.Write("Kitab adı:");
                                string name = Console.ReadLine();
                                Console.WriteLine("-----------");
                                Console.Write("Yazıçı:");
                                string author = Console.ReadLine();
                                Console.WriteLine("-----------");
                                Console.Write("Nəşriyyat ili:");
                                int.TryParse(Console.ReadLine(), out int year);
                                Console.WriteLine("-----------");
                                Console.Write("Janrı:");
                                string type = Console.ReadLine();
                                library.SearchBook(name, author, year, type);
                            }
                            break;
                        case 5:
                            {
                                library.GetBookList();
                                Console.Write("Kirayələmək istədiyiniz kitabı seçin:");
                                int.TryParse(Console.ReadLine(), out int updateIndex);
                                updateIndex = updateIndex - 1;
                                var updateResult = library.RentBook(updateIndex);
                                if (updateResult)
                                {
                                    PrintMessage("Kitab uğurla kirayələndi!", ConsoleColor.Green);
                                }
                                else
                                {
                                    PrintMessage("Bir xəta baş verdi!", ConsoleColor.Red);
                                }
                            }
                            break;
                        default:
                            PrintMessage("!!! Əməliyyat nömrəsi düzgün seçilmədi !!!!", ConsoleColor.DarkRed);
                            break;
                    }
                } while (isContinue);
                break;
            #endregion
            case 2:
                #region Journal Operations
                bool isContinueJournal = true;
                do
                {
                    #region Book Menu
                    string bookMenu = "1.Jurnalların siyahısı\n" +
                                      "2.Yeni jurnal əlavə et\n" +
                                      "3.Jurnalı sil\n" +
                                      "4.Jurnalı axtar\n" +
                                      "5.Jurnalı kirayə ver";
                    Console.WriteLine(bookMenu);
                    Console.Write("Əməliyyat nömrəsini seçin:");
                    int.TryParse(Console.ReadLine(), out int operationNumberBook);
                    Console.Clear();
                    #endregion
                    switch (operationNumberBook)
                    {
                        case 1:
                            {
                                #region Get Journal List
                                library.GetJournalList();
                                Console.WriteLine("\n");
                                #endregion
                            }
                            break;
                        case 2:
                            {
                                #region Add Journal Form
                                Console.Write("Jurnal adı:");
                                string name = Console.ReadLine();
                                Console.WriteLine("-----------");
                                Console.Write("Tipi:");
                                string type = Console.ReadLine();
                                Console.WriteLine("-----------");
                                Console.Write("Nəşriyyat ili:");
                                int.TryParse(Console.ReadLine(), out int year);
                                Console.WriteLine("-----------");
                                bool rent = false;
                                Journal journal = new Journal()
                                {
                                    JournalName = name,
                                    JournalType = type,
                                    IsRented = rent,
                                    Year = year
                                };
                                library.CreateJournal(journal);
                                PrintMessage("Jurnal uğurla əlavə olundu!", ConsoleColor.Green);
                                #endregion
                            }
                            break;
                        case 3:
                            library.GetJournalList();
                            Console.Write("Siləcəyiniz jurnalı seçin:");
                            int.TryParse(Console.ReadLine(), out int index);
                            index = index - 1;
                            var result = library.DeleteJournal(index);
                            if (result)
                            {
                                PrintMessage("Jurnal uğurla silindi!", ConsoleColor.Green);
                            }
                            else
                            {
                                PrintMessage("Bir xəta baş verdi!", ConsoleColor.Red);
                            }
                            break;
                        case 4:
                            {
                                library.GetJournalList();
                                Console.Write("Jurnal adı:");
                                string name = Console.ReadLine();
                                Console.WriteLine("-----------");
                                Console.Write("Tipi:");
                                string type = Console.ReadLine();
                                Console.WriteLine("-----------");
                                Console.Write("Nəşriyyat ili:");
                                int.TryParse(Console.ReadLine(), out int year);
                                library.SearchJournal(name, type, year);
                            }
                            break;
                        case 5:
                            {
                                library.GetJournalList();
                                Console.Write("Kirayələmək istədiyiniz jurnalı seçin:");
                                int.TryParse(Console.ReadLine(), out int updateIndex);
                                updateIndex = updateIndex - 1;
                                var updateResult = library.RentJournal(updateIndex);
                                if (updateResult)
                                {
                                    PrintMessage("Jurnal uğurla kirayələndi!", ConsoleColor.Green);
                                }
                                else
                                {
                                    PrintMessage("Bir xəta baş verdi!", ConsoleColor.Red);
                                }
                            }
                            break;
                        default:
                            PrintMessage("!!! Əməliyyat nömrəsi düzgün seçilmədi !!!!", ConsoleColor.DarkRed);
                            break;
                    }
                } while (isContinueJournal);
                break;
            #endregion
            case 3:
                #region Audio Book Operations
                bool isContinueAudio = true;
                do
                {
                    #region Audio Book Menu
                    string bookMenu = "1.Səsli kitabların siyahısı\n" +
                                      "2.Yeni səsli kitab əlavə et\n" +
                                      "3.Səsli kitab sil\n" +
                                      "4.Səsli kitab axtar\n" +
                                      "5.Səsli kitabı kirayə ver";
                    Console.WriteLine(bookMenu);
                    Console.Write("Əməliyyat nömrəsini seçin:");
                    int.TryParse(Console.ReadLine(), out int operationNumberAudBook);
                    Console.Clear();
                    #endregion
                    switch (operationNumberAudBook)
                    {
                        case 1:
                            {
                                #region Get Audio Book List
                                library.GetAudioBookList();
                                Console.WriteLine("\n");
                                #endregion
                            }
                            break;
                        case 2:
                            {
                                #region Add Book Form
                                Console.Write("Kitab adı:");
                                string name = Console.ReadLine();
                                Console.WriteLine("-----------");
                                Console.Write("Yazıçı:");
                                string author = Console.ReadLine();
                                Console.WriteLine("-----------");
                                Console.Write("Nəşriyyat ili:");
                                int.TryParse(Console.ReadLine(), out int year);
                                Console.WriteLine("-----------");
                                Console.Write("Janrı:");
                                string type = Console.ReadLine();
                                bool rent = false;
                                AudioBook audioBook = new AudioBook()
                                {
                                    BookName = name,
                                    Author = author,
                                    Type = type,
                                    IsRented = rent,
                                    Year = year
                                };
                                library.CreateAudioBook(audioBook);
                                PrintMessage("Səsli kitab uğurla əlavə olundu!", ConsoleColor.Green);
                                #endregion
                            }
                            break;
                        case 3:
                            library.GetAudioBookList();
                            Console.Write("Siləcəyiniz səsli kitabı seçin:");
                            int.TryParse(Console.ReadLine(), out int index);
                            index = index - 1;
                            var result = library.DeleteAudioBook(index);
                            if (result)
                            {
                                PrintMessage("Səsli kitab uğurla silindi!", ConsoleColor.Green);
                            }
                            else
                            {
                                PrintMessage("Bir xəta baş verdi!", ConsoleColor.Red);
                            }
                            break;
                        case 4:
                            {
                                Console.Write("Kitab adı:");
                                string name = Console.ReadLine();
                                Console.WriteLine("-----------");
                                Console.Write("Yazıçı:");
                                string author = Console.ReadLine();
                                Console.WriteLine("-----------");
                                Console.Write("Nəşriyyat ili:");
                                int.TryParse(Console.ReadLine(), out int year);
                                Console.WriteLine("-----------");
                                Console.Write("Janrı:");
                                string type = Console.ReadLine();
                                library.SearchAudioBook(name, author, year, type);
                            }
                            break;
                        case 5:
                            {
                                library.GetAudioBookList();
                                Console.Write("Kirayələmək istədiyiniz kitabı seçin:");
                                int.TryParse(Console.ReadLine(), out int updateIndex);
                                updateIndex = updateIndex - 1;
                                var updateResult = library.RentBook(updateIndex);
                                if (updateResult)
                                {
                                    PrintMessage("Kitab uğurla kirayələndi!", ConsoleColor.Green);
                                }
                                else
                                {
                                    PrintMessage("Bir xəta baş verdi!", ConsoleColor.Red);
                                }
                            }
                            break;
                        default:
                            PrintMessage("!!! Əməliyyat nömrəsi düzgün seçilmədi !!!!", ConsoleColor.DarkRed);
                            break;
                    }
                } while (isContinueAudio);
                break;
                #endregion
                break;
            case 4:
                PrintMessage("Hesabdan çıxıldı !", ConsoleColor.Green);
                break;
            default:
                PrintMessage("!!! Əməliyyat nömrəsi yanlışdır !!!!", ConsoleColor.DarkRed);
                break;
        }
    }

    #region Response Message
    void PrintMessage(string message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine("\n\n" + message + "\n\n");
        Console.ResetColor();
    }
}
#endregion