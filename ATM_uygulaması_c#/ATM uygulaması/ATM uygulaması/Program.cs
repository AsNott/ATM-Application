namespace ATM_uygulaması
{
    internal class Program
    {
        public static int amount = 0;

        static void Main(string[] args)
        {
            dilSec(); 
        }

        public static void dilSec()
        {
        again:

            Console.Write("Dil Seçiniz / Choose Language (1- Türkçe 2- English 0- Çıkış/Exit): ");
            int Ch_language = Convert.ToInt32(Console.ReadLine());

            switch (Ch_language)
            {
                case 1:
                    Turkce();
                    break;
                case 2:
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    goto again;

            }
        }
        //TÜRKÇE
        public static void Turkce()
        {
            again:
            Console.WriteLine("*********************");
            Console.WriteLine("0- Çıkış");
            Console.WriteLine("1- Para Yatır");
            Console.WriteLine("2- Para Çek");
            Console.WriteLine("3- Bakiye Kontrol Et");
            Console.WriteLine("*********************\n");

            Console.Write("İşlem seçiniz: ");
            int işlem = Convert.ToInt32(Console.ReadLine());

            switch (işlem)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    paraYatır();
                    goto again;
                    
                case 2:
                    paraÇek();
                    goto again;
                case 3:
                    bakiyeKontrol();
                    goto again;

                default:
                    goto again;
                    
            }
        }

        public static void paraYatır()
        {
            
            Console.WriteLine("---");
            Console.Write("Yatırılacak Tutar Giriniz: ");
            int yatir = Convert.ToInt32(Console.ReadLine());
            amount += yatir;
            Console.WriteLine("Yatırma başarılı");
            Console.WriteLine("Güncel bakiyeniz: {0}", amount);
            Console.WriteLine("---");
            
        }

        public static void paraÇek()
        {
            
            Console.Write("Çekilecek Tutar giriniz: ");
            int cek = Convert.ToInt32(Console.ReadLine());
            if (amount >= cek)
            {
                amount -= cek;
                Console.WriteLine("---");
                Console.WriteLine("Çekim başarılı");
                Console.WriteLine("Güncel bakiyeniz: {0}", amount);
                Console.WriteLine("---");
            }
            else
            {
                Console.WriteLine("->");
                Console.WriteLine("Bakiyeniz Yetersiz! Menüye Yönlendiriliyorsunuz... \n\n");
                Turkce();
            }
           
        }
        public static void bakiyeKontrol()
        {
            Console.WriteLine("---");
            Console.WriteLine("Güncel bakiyeniz: {0}", amount);
            Console.WriteLine("---");
        }

        //ENGLİSH

        public static void English()
        {
        again:
            Console.WriteLine("*********************");
            Console.WriteLine("0- Exit");
            Console.WriteLine("1- Deposit Money");
            Console.WriteLine("2- Withdrawal Money");
            Console.WriteLine("3- Check Balance");
            Console.WriteLine("*********************\n");

            Console.Write("Select Transaction: ");
            int işlem = Convert.ToInt32(Console.ReadLine());

            switch (işlem)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    deposit();
                    goto again;

                case 2:
                    withdrawal();
                    goto again;
                case 3:
                    checkBalance();
                    goto again;

                default:
                    goto again;

            }
        }

        public static void deposit()
        {

            Console.WriteLine("---");
            Console.Write("Enter the amount to deposit: ");
            int yatir = Convert.ToInt32(Console.ReadLine());
            amount += yatir;
            Console.WriteLine("Deposit successful");
            Console.WriteLine("Current balance: {0}", amount);
            Console.WriteLine("---");

        }

        public static void withdrawal()
        {

            Console.Write("Enter Amount to Withdrawal: ");
            int cek = Convert.ToInt32(Console.ReadLine());
            if (amount >= cek)
            {
                amount -= cek;
                Console.WriteLine("---");
                Console.WriteLine("Withdrawal successful");
                Console.WriteLine("Current balance: {0}", amount);
                Console.WriteLine("---");
            }
            else
            {
                Console.WriteLine("->");
                Console.WriteLine("Insufficient balance! You are being redirected to the menu... \n\n");
                Turkce();
            }

        }
        public static void checkBalance()
        {
            Console.WriteLine("---");
            Console.WriteLine("Current balance: {0}", amount);
            Console.WriteLine("---");
        }
    }
}