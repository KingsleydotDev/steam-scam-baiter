using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Security.Policy;
using System.Net.Http;
using System.Threading;

namespace Steam_Scam_Baiter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] names = new string[] 
        {
            "Aaron", "Abigail", "Adam", "Adeline", "Adrian", "Aiden", "Ainsley", "Alan", "Alana", "Albert", "Alec", "Alexa", "Alexander", "Alexandra", "Alexis", "Alice", "Alicia", "Alina", "Alisha", "Allan", "Allison", "Alyssa", "Amara", "Amelia", "Amir", "Amy", "Andrea", "Andrew", "Angela", "Angelina", "Anita", "Anna", "Annabelle", "Anthony", "Aria", "Ariana", "Arianna", "Arthur", "Asher", "Ashley", "Ashton", "Aubrey", "Audrey", "Austin", "Autumn", "Ava", "Avery", "Barbara", "Barry", "Beatrice", "Beau", "Bella", "Benjamin", "Bennett", "Bernard", "Bethany", "Beverly", "Blake", "Braden", "Bradley", "Brandon", "Brayden", "Brenda", "Brianna", "Brian", "Brittany", "Brody", "Brooklyn", "Bryan", "Bryce", "Caleb", "Callie", "Camila", "Cameron", "Candice", "Carl", "Carla", "Carlos", "Carmen", "Caroline", "Carter", "Casey", "Cassandra", "Cassidy", "Catherine", "Cecilia", "Cedric", "Celeste", "Chad", "Charles", "Charlotte", "Chase", "Chelsea", "Cheryl", "Chris", "Christian", "Christina", "Christopher", "Claire", "Clara", "Clarence", "Claudia", "Clayton", "Clifford", "Clint", "Clinton", "Cole", "Colin", "Colleen", "Connor", "Conrad", "Cooper", "Courtney", "Craig", "Crystal", "Curtis", "Cynthia", "Daisy", "Dakota", "Dale", "Dallas", "Damian", "Dana", "Daniel", "Danielle", "Daphne", "Darcy", "Darlene", "Darrell", "Darren", "David", "Dawn", "Dean", "Deborah", "Declan", "Delaney", "Delilah", "Denise", "Derek", "Desmond", "Destiny", "Devin", "Diana", "Diane", "Diego", "Dillon", "Dominic", "Donna", "Donovan", "Dorothy", "Douglas", "Drew", "Duncan", "Dustin", "Dylan", "Earl", "Easton", "Ebony", "Eden", "Edgar", "Edith", "Edmund", "Edward", "Edwin", "Eileen", "Elaine", "Eleanor", "Elena", "Eli", "Eliana", "Elias", "Elijah", "Elisa", "Elise", "Eliza", "Elizabeth", "Ella", "Ellen", "Ellie", "Elliot", "Elliott", "Emerson", "Emery", "Emilia", "Emily", "Emma", "Emmanuel", "Emmett", "Eric", "Erica", "Erik", "Erin", "Esme", "Esther", "Ethan", "Eva", "Evan", "Evelyn", "Everett", "Ezra", "Faith", "Farrah", "Felix", "Fiona", "Finn", "Fiona", "Florence", "Ford", "Frances", "Francis", "Frank", "Franklin", "Gabriel", "Gabriella", "Gabrielle", "Gage", "Garrett", "Gavin", "Genevieve", "George", "Georgia", "Gerald", "Gianna", "Gideon", "Gina", "Giselle", "Gloria", "Gordon", "Grace", "Gracie", "Grant", "Gregory", "Gretchen", "Griffin", "Guadalupe", "Gwendolyn", "Hadley", "Hailey", "Haley", "Hannah", "Harley", "Harmony", "Harold", "Harper", "Harrison", "Harry", "Hayden", "Hazel", "Heath", "Heather", "Heidi", "Helen", "Helena", "Henry", "Herbert", "Holly", "Hope", "Howard", "Hudson", "Hugh", "Hunter", "Ian", "Imogen", "India", "Inez", "Irene", "Iris", "Isabel", "Isabella", "Isabelle", "Isaiah", "Isla", "Ivan", "Ivy", "Jack", "Jackson", "Jacob", "Jacqueline", "Jade", "Jaden", "Jake", "James", "Jameson", "Jamie", "Jane", "Janelle", "Jasmine", "Jason", "Javier", "Jay", "Jayden", "Jean", "Jeanette", "Jeffrey", "Jenna", "Jennifer", "Jenny", "Jeremiah", "Jeremy", "Jerome", "Jerry", "Jessica", "Jesus", "Jill", "Jillian", "Jim", "Joan", "Joanna", "Jocelyn", "Joe", "Joel", "Joey", "John", "Johnny", "Jon", "Jonah", "Jonathan", "Jordan", "Jorge", "Jose", "Joseph", "Josephine", "Josh", "Joshua", "Josiah", "Joy", "Joyce", "Juan", "Judith", "Judy", "Julia", "Julian", "Juliana", "Julianna", "Julie", "Juliet", "June", "Justin", "Kaitlyn", "Kara", "Karen", "Karina", "Karl", "Karla", "Kate", "Katelyn", "Katherine", "Kathleen", "Kathryn", "Kathy", "Katie", "Katrina", "Kay", "Kayla", "Keira", "Keith", "Kelly", "Kelsey", "Kendall", "Kennedy", "Kenneth", "Kenzie", "Kevin", "Kim", "Kimberly", "Kirk", "Kristen", "Kristin", "Kristina", "Kurt", "Kyle", "Kylie", "Lacey", "Lana", "Landon", "Lara", "Laura", "Lauren", "Laurie", "Leah", "Leila", "Lena", "Leo", "Leon", "Leonard", "Leonardo", "Leslie", "Levi", "Liam", "Lila", "Lillian", "Lily", "Lincoln", "Linda", "Lindsay", "Lisa", "Logan", "Lois", "London", "Lorena", "Lori", "Louis", "Louise", "Lucas", "Lucia", "Lucille", "Lucy", "Luis", "Luke", "Lydia", "Lyla", "Mackenzie", "Maddox", "Madeline", "Madison", "Mae", "Maeve", "Maggie", "Mallory", "Mandy", "Manuel", "Marc", "Marcus", "Margaret", "Maria", "Mariah", "Mariam", "Marianne", "Marie", "Marilyn", "Marina", "Marion", "Marissa", "Mark", "Marshall", "Martha", "Martin", "Marvin", "Mary", "Mason", "Matilda", "Matthew", "Maureen", "Maverick", "Max", "Maxwell", "Maya", "Megan", "Meghan", "Melanie", "Melissa", "Melody", "Mercedes", "Meredith", "Micah", "Michael", "Michaela", "Michelle", "Mikayla", "Miles", "Millie", "Milo", "Milton", "Miranda", "Miriam", "Mitchell", "Molly", "Monica", "Morgan", "Moses", "Murphy", "Myra", "Nadia", "Nancy", "Naomi", "Natalia", "Natalie", "Natasha", "Nathan", "Nathaniel", "Neil", "Nell", "Nia", "Nicholas", "Nicole", "Nina", "Noah", "Noel", "Nolan", "Nora", "Norman", "Nova", "Olive", "Oliver", "Olivia", "Omar", "Ophelia", "Oscar", "Owen", "Paige", "Pamela", "Parker", "Patricia", "Patrick", "Paul", "Paula", "Paulina", "Pearl", "Pedro", "Penelope", "Penny", "Peter", "Peyton", "Philip", "Phoebe", "Pierce", "Preston", "Priscilla", "Quentin", "Quincy", "Quinn", "Rachael", "Rachel", "Rafael", "Raquel", "Ray", "Raymond", "Rebecca", "Reed", "Regina", "Reid", "Renee", "Rex", "Rhys", "Richard", "Riley", "Robert", "Roberta", "Robin", "Rocco", "Roger", "Roland", "Roman", "Ronald", "Rosa", "Rose", "Rosemary", "Ross", "Rowan", "Roy", "Ruby", "Russell", "Ruth", "Ryan", "Ryder", "Sabrina", "Sadie", "Sage", "Sally", "Sam", "Samantha", "Samuel", "Sandra", "Sara", "Sarah", "Savannah", "Sawyer", "Scarlett", "Scott", "Sean", "Sebastian", "Selena", "Serena", "Sergio", "Seth", "Shane", "Shannon", "Sharon", "Shaun", "Sheila", "Shelby", "Shirley", "Sidney", "Sierra", "Silas", "Simon", "Skylar", "Sofia", "Sophia", "Sophie", "Spencer", "Stacy", "Stanley", "Stefan", "Stella", "Stephanie", "Stephen", "Sterling", "Steven", "Stewart", "Stuart", "Summer", "Susan", "Susanna", "Sydney", "Sylvia", "Talia", "Tamara", "Tanner", "Tara", "Tate", "Taylor", "Ted", "Teresa", "Terrance", "Terry", "Theo", "Theodore", "Thomas", "Tiffany", "Timothy", "Tina", "Tobias", "Toby", "Todd", "Tom", "Tomas", "Tommy", "Tony", "Tracey", "Travis", "Trent", "Trevor", "Trey", "Tristan", "Troy", "Tucker", "Tyler", "Valentina", "Valerie", "Vanessa", "Vera", "Veronica", "Victor", "Victoria", "Vincent", "Violet", "Virginia", "Vivian", "Wade", "Walker", "Walter", "Warren", "Wayne", "Wesley", "Whitney", "Wilfred", "Will", "William", "Willow", "Wilson", "Winston", "Wyatt", "Xander", "Xavier", "Yasmin", "Yvette", "Yvonne", "Zachary", "Zane", "Zara", "Zoe", "Zoey"
        };
        string[] passwords = new string[]
        {
            "A8f$2kP!", "G9h#7Lm@", "W6p&4Zr%", "D3q*9Nj^", "T1v(8Bk!", "M2y@5Wx#", "H7c$3Qz*", "J4k^6Rl&", "F5p(7Ym@", "B9x#2Tv!", "Z8m$1Nq&", "R7w^3Pj#", "L6v*4Mx%", "K2n@8Fp!", "Q3y$5Wk*", "X1z(9Ml&", "C8f#7Rp@", "P5q*6Yj!", "T9m(2Zk&", "N4v^3Wl#", "Y7c$9Qn@", "H2k*5Fx!", "Z8w(3Rp&", "L1v@6Mj#", "N3y$4Wq*", "X5f^7Pl&", "B2z*8Fj@", "C9m$6Tk#", "R7x^2Nl&", "Q4p*5Ym!", "F8w(3Tk&", "M1v^9Qj#", "P6y$7Nl*", "K3f(4Wx&", "X9z@5Rp#", "L8m$2Yk*", "H7c^3Pl&", "T2w(9Qn!", "B5y@6Fj#", "N4f$7Ml*", "C1z*8Tk&", "R9x(3Nl@", "Q2v$5Wj#", "X6y^7Pq*", "L8m(1Fk!", "H3f$9Qx&", "P4k@6Tn#", "B7y$2Wx*", "N5z*8Fj&", "C9m@3Rk!", "T1x$4Nl#", "L6f^7Qy*", "X2v(9Pk@", "H8m$5Wj&", "N4y@7Tl#", "R3z*2Fk!", "C5x(9Qk&", "B6m@4Yj#", "Q8f$7Nl*", "X1y^5Rp@", "L9z*6Wk!", "P7m(3Fk&", "N2v$4Tl#", "T6y@8Qn*", "H5f$9Xj!", "R1m*2Pk&", "C8z@3Wl#", "B4x$7Qy*", "N9f(6Tk!", "P2v^5Xj&", "T8y$4Rl@", "L3z*7Wk#", "H9m(2Qn*", "X5f$8Pk&", "N1v^4Tl#", "R6z@7Xj*", "B2m$9Wk!", "Q8y(3Fl&", "T4f$6Pk#", "L9v*7Xj@", "P5z@8Nl*", "H2y$3Tk&", "R7m(4Ql#", "N6f^9Xj*", "C8v$1Pk@", "X3z@7Rl*", "T9y(6Fk&", "L2m*8Qk#", "B7f^5Nl@", "N4z$9Xk*", "R8y@2Wj&", "Q1m*7Pk#", "T5f(8Rl@", "L9v$3Xk*", "X2z@6Qj&", "N7y(5Fl#", "P8f^4Tk@", "C3z$9Nl*", "H6v@7Xj&", "R1m(4Pk#", "L2z*8Tl@", "B9f^5Ql*", "N6v(7Wj@", "T3z$8Pk&", "X4y@9Nl*", "P7f(2Qk@", "H5v*6Rl#", "C8z^3Tk&", "N1y@7Wk*", "L9m$4Qj&", "T6f(8Pk#", "R2z*5Nl@", "P8v^7Xk*", "X1y@3Tk&", "N4z$9Rl@", "C7m(6Wj*", "B3f^8Pk#", "L2y*7Nl@", "T9z(5Fk&", "H6v^4Ql*", "R8m@2Tk#", "N5f(7Xl@", "X3z$9Wk*", "L7v@8Qk#", "C1y(5Pl&", "P6f$3Rl@", "H8m^9Tk*", "R4v(7Xj&", "T2z*5Wk@", "N9f(6Pk#", "X7y@4Rl*", "P5m$3Qk&", "L1f^8Xl@", "C4v(9Tk*", "H6y$2Pk@", "T8z@7Nl#", "N3f(5Rl*", "P2v@9Wk#", "L7y^4Tl@", "R9m(3Fk&", "C6f@8Qk*", "H5v$2Rl#", "X8y^7Tk@", "L3m(9Pk&", "B9z$6Wj*", "T2v@5Nl#", "N7f(8Qk*", "P4y$3Rl@", "R6m@9Wk#", "X1f^7Tk*", "H8v$2Pk&", "C5z(6Nl@", "T7y^9Rl*", "L4m@3Wk#", "N9f$7Pk*", "X2z(8Rl&", "P6y@5Nl#", "H7m^4Qk*", "R3v$9Pk@", "T8y(2Wl#", "N1f^6Tk*", "C9z$7Rl&", "L5y@4Pk#", "H6m*8Wl@", "R7v(3Qk*", "P9y^5Rl&", "T2f@8Wk#", "X4z$6Pk*", "N1y*7Tl&", "H3v$9Rl#", "L8z(5Pk@", "T7y^6Xl*", "C2m$4Rl@", "R9v(3Tk#", "H5f*7Nl&", "P6z$8Wk@", "X3y^2Rl#", "N4m(9Pk*", "T8y@5Xl&", "C7z(3Qk#", "L9v$6Pk@", "R1y^8Wl*", "H3f(7Tk&", "P5z@2Rl#", "X6y*9Nl&", "T4m$7Pk@", "L2v(8Rl#", "C9z^5Wk*", "H7y@3Nl&", "R8f$6Pk#", "P1z(4Tk&", "X2y@7Rl*", "T5v$9Wk#", "L8z(6Tk&", "H3m@7Nl*", "N1f$8Pk@", "C5z^9Wl#", "P7y(3Rl*", "T9v@6Xk&", "R4z$2Pk#", "L5f*7Tl&", "H8m(9Nl@", "N2v@3Pk#", "C7z^8Rl*", "X9y$5Tk@", "T1v*7Wk&", "R3f(9Nl#", "P5z$8Tk&", "H2y@4Rl*", "L7v$6Pk@", "C8z(9Tl#", "N4f^7Xk&", "X6y*5Wl@", "T2v(3Pk#", "R9z$8Tl&", "H7f@6Nl*", "L5m(7Qk&", "P1y$4Wk#", "X9f^3Rl*", "C7z(2Tl@", "H8m@5Pk#", "N2f(9Xl*", "L3z*6Pk&", "P7y$8Wl@", "T9v@4Rl#", "H5f$6Pk*", "R8m(9Wl&", "C2y@3Tl#", "N7z*4Xk&", "L9v$8Rl@", "T1f(5Pk#", "X3z@7Wk&", "P5y$9Rl*", "H8v*2Tl&", "N4m$7Pk@", "C6z^9Wl#", "R7y@3Tl*", "T8f$6Xk&", "L9v@4Rl#", "H2z(5Pk*", "X7y*8Wk&", "N3m$6Rl@", "P5f^7Tl#", "L4z@8Pk*", "T9m(2Xk&", "R8f$3Nl@", "C6z*7Wl#", "N1v$5Tl*", "H7m@9Pk&", "P4z(6Xl#", "L2y*8Tl@", "T3v@5Pk#", "X6m$9Rl&", "R9f(7Tl*", "C8z@6Pk#", "L4y^7Nl&", "T5m*2Wk@", "N7v$9Rl#", "H8f@3Xk&", "X3z(4Tl@", "P1y@5Pk#", "C7m^6Xl&", "R8z$7Wk@", "L2y*9Tl#", "T9f(6Rl&", "N4v@3Pk#", "H6z^8Xl&", "P5m$7Tl@"
        };

        private void sendPayload_Click(object sender, EventArgs e)
        {
            try
            {
                WebClient wc = new WebClient();
                string webhookurl = webhookTextBox.Text;
                wc.Headers.Add("Content-Type", "application/json");
                string payload = "{\"content\": \"" + payloadTextBox.Text + "\"}";
                wc.UploadData(webhookurl, Encoding.UTF8.GetBytes(payload));
            }
            catch { }
        }

        private void generatePayload_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int i = random.Next(names.Length);
            int j = random.Next(passwords.Length);
            int randomNumber = random.Next(1990, 100000);

            payloadTextBox.Text = "login: " + names[i] + randomNumber.ToString() + " password: " + passwords[j];
        }

        private void nukeWebhook_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to permanently delete this web hook?", "Confirmation",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                attemptDisableWebhookAsync();
            }
            else
            {

            }
        }

        async Task attemptDisableWebhookAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.DeleteAsync(webhookTextBox.Text);

                    if (response.IsSuccessStatusCode)
                    {
                        WebClient wc = new WebClient();
                        string webhookurl = webhookTextBox.Text;
                        wc.Headers.Add("Content-Type", "application/json");
                        string payload = "{\"content\": \"" + "Deleting this webhook. -KingsleydotDev" + "\"}";
                        wc.UploadData(webhookurl, Encoding.UTF8.GetBytes(payload));
                        Thread.Sleep(1000);
                        MessageBox.Show("Webhook deleted successfully.");
                    }
                    else
                    {
                        string errorContent = await response.Content.ReadAsStringAsync();
                        MessageBox.Show(errorContent);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred: {ex.Message}");
            }
        }
    }
}
