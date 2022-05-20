using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ödev şimdilik eksiktir. Silme Fonksiyonu eklenmedi. 
            //Eklemede de küçük bir hata var daha sonra düzeltmek
            //üzere şimdilik es geçiyorum.
            Customer addCustomer = new Customer();
            CustomerManager customerManager = new CustomerManager();
            string choice = "a";
            while (choice != "4")
            {
                
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi tuşlayınız. \n" +
                                  "1) Müşteri Ekle \n" +
                                  "2) Müşteri Listele \n" +
                                  "3) Müşteri Sil \n" +
                                  "4) Programı Sonlandır");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.WriteLine("Müşteri Id:");
                    addCustomer.Id = int.Parse(Console.ReadLine());

                    Console.WriteLine("Müşteri Adı:");
                    addCustomer.Name = Console.ReadLine();

                    Console.WriteLine("Müşteri Soyadı:");
                    addCustomer.Surname = Console.ReadLine();

                    Console.WriteLine("Müşteri Hesap Bakiyesi:");
                    addCustomer.Money = decimal.Parse(Console.ReadLine());
                    customerManager.Add(addCustomer);
                }
                if (choice == "2")
                {
                    Console.WriteLine("|   Müşteri Id   |   Müşteri Adı  | Müşteri Soyadı |Müşteri Bakiyesi|");
                    foreach (var customer in customerManager.GetAll())
                    {
                        Console.WriteLine("|       " + customer.Id + "       " +
                                          "|   " + customer.Name + "   " +
                                          "|   " + customer.Surname + "   " +
                                          "|   " + customer.Money + "   ");
                    }
                }
                if (choice == "3")
                {

                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir seçim yapınız");
                }
            }
        }
    }
}
