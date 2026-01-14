using System.Diagnostics.Eventing.Reader;
using System.Speech.Synthesis;

namespace SmartBusProject
{
    internal static class Program
    {
        //Users Lists
        public static List<User> users = new List<User>();
        public static User userInstance;

        //Cafe Lists
        public static List<Cafes> cafes = new List<Cafes>();
        public static List<Product> product = new List<Product>();
        public static List<CartItem> cartProducts = new List<CartItem>();

        //BusStop List
        public static List<BusStops> busStops = new List<BusStops>();

        //Wander Data
        public static string Acropoli = "Ακρόπολη";
        public static string Acropoli_Desc = "Η Ακρόπολη Αθηνών είναι βραχώδης λόφος ύψους 157 μ. από την επιφάνεια της θάλασσας και 70 μ. περίπου από το επίπεδο της πόλεως των Αθηνών. Η κορυφή του έχει σχήμα τραπεζοειδές μήκους 300 μ. και μέγιστου πλάτους 150 μ. Ο λόφος είναι απρόσιτος απ’ όλες τις πλευρές εκτός της δυτικής, όπου και βρίσκεται η οχυρή είσοδος, η διακοσμημένη με τα λαμπρά Προπύλαια.";

        public static string Theseio = "Ναός του Ηφαίστου";
        public static string Theseio_Desc = "Ο Ναός του Ηφαίστου (αποκαλούμενος και Θησείο) είναι ένας από τους πλέον διατηρημένους αρχαίους ναούς του ελληνικού χώρου. Ήταν αφιερωμένος στον θεό Ήφαιστο και στην Εργάνη Αθηνά. Βρίσκεται στην περιοχή του Θησείου, που πήρε το όνομά του λόγω της παλιάς, σήμερα αναθεωρημένης απόδοσης του ναού στον Θησέα. Ο ναός του Ηφαίστου είναι προσβάσιμος για το κοινό, καθώς αποτελεί τμήμα του αρχαιολογικού χώρου της Αρχαίας Αγοράς. Πρόκειται για ένα από τα καλύτερα διατηρημένα μνημεία της Αγοράς και τον καλύτερα σωζόμενο ναό δωρικού ρυθμού στον Ελλαδικό χώρο.\r\n\r\nΟ Ναός αυτός είναι χτισμένος πάνω στον λόφο του Αγοραίου Κολωνού, στο δυτικό μέρος της Αρχαίας Αγοράς, κατά διεύθυνση Ανατολή - Δύση με είσοδο από την Ανατολή. Είναι δωρικού ρυθμού, περίπτερος, εξάστυλος ναός, κτισμένος ίσως από τον αρχιτέκτονα Ικτίνο από πεντελικό μάρμαρο. Έχει 13 κίονες σε κάθε πλευρά μήκους και 6 (συναριθμούμενοι) κατά πλάτος. Ο σηκός του χωρίζεται σε πρόναο, κυρίως ναό και οπισθόδομο. Κτίστηκε στα μέσα του 5ου αιώνα π.Χ. και αργότερα μετατράπηκε σε χριστιανική εκκλησία, μέχρι το 1834, και μουσείο.";

        public static string Ethniko_Mouseio = "Λόφος της Πνύκας";
        public static string Ethniko_Mouseio_Desc = "Η Πνύκα (η Πνύξ, της Πνυκός ή Πυκνός) είναι η θέση - περιοχή όπου συγκαλούνταν η Εκκλησία του δήμου, δηλαδή η συνέλευση των Αθηναίων, στην Αρχαία Αθήνα, από τον 6ο αιώνα μέχρι το τέλος του 4ου αιώνα π.Χ.. Βρίσκεται στο μέσον της κατά διεύθυνση βορρά-νότου λοφοσειράς έναντι και δυτικά της Ακρόπολης και μεταξύ των ακραίων υψωμάτων, του λόφου Νυμφών (βόρειο άκρο) και λόφου Μουσών ή Φιλοπάππου (νότιο άκρο).\r\n\r\nΑπό το αρχαίο βήμα του ιερού χώρου αυτού αγόρευσαν σπουδαίοι πολιτικοί, στρατηγοί και ρήτορες όπως ο Θεμιστοκλής, ο Αριστείδης, ο Περικλής, ο Δημοσθένης, ο Ούβας, ο Αισχίνης αλλά και στη σύγχρονη εποχή ο Θεόδωρος Κολοκοτρώνης.";

        public static string Hrodio = "Θέατρο Ηρώδειου Αττικού";
        public static string Hrodio_Desc = "Το Ωδείο Ηρώδου του Αττικού, περισσότερο γνωστό ως Ηρώδειο, είναι αρχαίο ρωμαϊκό θέατρο ανεγερθέν το 161 μ.Χ. στους πρόποδες του βράχου της Ακροπόλεως των Αθηνών, από τον Ηρώδη τον Αττικό, εις μνήμην της συζύγου του, Ρηγίλλης, αποβιώσασας το 160. Κατεστραμμένο, περίπου, εκατό χρόνια μετά την ολοκλήρωση των εργασιών ανέγερσής του, το ωδείο, στη συνέχεια, ενσωματώθηκε εντός του συστήματος οχυρώσεων της πόλης των Αθηνών. Εκ νέου ανακαλυφθέν κατά τη διάρκεια της πρώιμης νεότερης περιόδου, αποτέλεσε αντικείμενο αρχαιολογικών ανασκαφών, ενώ, παράλληλα, υπέστη εργασίες αναστήλωσης, κατά τη διάρκεια της περιόδου μεταξύ των μέσων του 18ου αιώνα και των μέσων του αμέσως επόμενου αιώνα. Εμβληματική τοποθεσία του Φεστιβάλ Αθηνών-Επιδαύρου, το ωδείο φιλοξενεί ετησίως πολιτισμικές εκδηλώσεις παγκόσμιας εμβέλειας.";

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Users
            users.Add(new User("driver", "driver", UserType.Driver));
            users.Add(new User("dimos", "12345", UserType.Passenger));
            users.Add(new User("fotfot", "12345", UserType.Passenger));

            //Cafes
            cafes.Add(new Cafes("Old Dog", "Address 12", 8));
            cafes.Add(new Cafes("Flocafe", "Address 18", 12));
            cafes.Add(new Cafes("Coffe Island", "Address 20", 10));
            cafes.Add(new Cafes("Coffe Berry", "Address 78", 5));
            cafes.Add(new Cafes("Everest", "Address 55", 10));
            
            //Products
            product.Add(new Product("Cappucino", 2.30));
            product.Add(new Product("Espresso", 2.10));
            product.Add(new Product("Latte", 3.00));
            product.Add(new Product("Irish Coffee", 3.80));
            product.Add(new Product("Freddo Cappucino", 2.80));
            product.Add(new Product("Freddo Espresso", 2.50));
            product.Add(new Product("Nescafe Frappe", 2.40));
            product.Add(new Product("Nescafe", 2.40));
            product.Add(new Product("Tost", 2.00));
            product.Add(new Product("Coca Cola", 1.20));
            product.Add(new Product("Sprite", 1.40));
            product.Add(new Product("Fanda Blue", 1.30));

            //BusStops
            var busStopThesio = new BusStops("Στάστη Θησείο");
            var busStopPnika = new BusStops("Στάση Πνύκα");
            var busStopHrodio = new BusStops("Στάση Ηρώδειο");
            var busStopAcropoli = new BusStops("Στάση Ακρόπολη");

            //Restaurants per stop
            busStopThesio.AddRestaurant(new Restaurants("Ταβέρνα ο Νίκος", "Νηλέως 5", "300μ."));
            busStopThesio.AddRestaurant(new Restaurants("Σουβλάκι Express","Ηρακλείδων 20", "500μ."));
            busStopThesio.AddRestaurant(new Restaurants("Μπαρμπαλιάς", "Επταχάλκου 12", "600μ."));
            busStopThesio.AddRestaurant(new Restaurants("Το στέκι του Μανώλη","Αδριανοού 25", "700μ."));

            busStopPnika.AddRestaurant(new Restaurants("Ταβέρνα 'Η θέα'", "Αστεροσκοπείου 45","100μ."));
            busStopPnika.AddRestaurant(new Restaurants("Bistro Bar", "Αρακύνθου 20", "1.2χλμ."));

            
            busStopHrodio.AddRestaurant(new Restaurants("Acropolis Upper View", "Διονυσίου Αρεοπαγίτου 5", "150μ."));

            busStopAcropoli.AddRestaurant(new Restaurants("Ουζερί 'Το πιο λαμπρό μπουζούκι'", "Τριπόδων 12", "800μ."));
            busStopAcropoli.AddRestaurant(new Restaurants("Ταβέρνα 'Ο Θεμιστοκλής'", "Κόδρου 7", "900μ."));


            //Insert into busStops
            busStops.Add(busStopThesio);
            busStops.Add(busStopPnika);
            busStops.Add(busStopHrodio);
            busStops.Add(busStopAcropoli);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new DriverMainForm());
        }
    }
}