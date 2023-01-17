// See https://aka.ms/new-console-template for more information
using ConsoleApp7_BouncyCastle;


Console.WriteLine("Hello, World!");
Console.Write("Enter the text to Encrypt: ");
var text = Console.ReadLine();
File.WriteAllText(@"D:\WorkSpace\Data\Execution\input.txt",text);
Pgp.EncryptFile(@"D:\WorkSpace\Data\Execution\output.txt", @"D:\WorkSpace\Data\Execution\input.txt", @"D:\WorkSpace\Data\PGPKeys\PublicKey.asc", true, true);

Pgp.DecryptFile(@"D:\WorkSpace\Data\Execution\output.txt", @"D:\WorkSpace\Data\PGPKeys\PrivateKey.asc", "Pass@123".ToCharArray(), @"D:\WorkSpace\Data\Execution\DecryptedData.txt");