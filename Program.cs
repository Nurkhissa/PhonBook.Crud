using System;
using System.Runtime.CompilerServices;
using PhoneBook.Crud.Models;
using PhoneBook.Crud.Services.Contacts;

namespace PhoneBook.Crud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IContactService contactService = new ContactService();
              while (true)
            {
                Console.WriteLine("Operatsiyani tanlang:\n"+
                                  "1. Qo'shish\n"+
                                  "2. Barcha yozuvlarni ko'rish\n" +
                                  "3. ID boyicha yozuvni o'chirish\n"+
                                  "4. Chiqish");

                Console.Write("Qomandai tanlang: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Write("Ismni kiriting: ");
                        string name = Console.ReadLine();
                        Console.Write("Telefon raqamini kiriting: ");
                        string phone = Console.ReadLine();
                        contactService.AddContact();
                        Console.WriteLine("Foydalanuvchi qo'shildi.");
                        break;
                    case "2":
                        contactService.ShowContacts();
                        break;
                    case "3":
                        Console.Write("ID ni kiriting: ");
                        int deleteId = Convert.ToInt32(Console.ReadLine());;
                        contactService.DeleteContact();
                        break;
                    case "4":
                        Console.WriteLine("Dasturdan tugadi.");
                        return;
                    default:
                        Console.WriteLine("Noto'g'ri buyruq kiritildi)");
                        break;
                }

                Console.WriteLine();
            }

            
        }
    }
}
