namespace human 
{
    public class Person 
    {
        public string name;
        public int strength;
        public int intelligence;
        public int dexterity;
        public int health;
        public double distance;
        public Person(string nam = "Bill")
        {
            name = nam;
            strength = 3;
            intelligence = 3;
            dexterity = 3;
            health = 100;
            distance = 0.0;
        }
        public Person(string nam, int stren, int intell, int dext, int heal)
        {
            name = nam;
            strength = stren;
            intelligence = intell;
            dexterity = dext;
            health = heal;
            distance = 0.0;            
        }
        public void Run(double miles)
        {
            distance += miles;
        }
        public void Attack(object target)
        {
            Person enemy = target as Person;
                if (enemy != null)
                {
                    enemy.health -= 5 * strength;
                }
        }
    }




}