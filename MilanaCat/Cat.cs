namespace MilanaCat
{
    internal class Cat
    {
        private string v1;
        private string v2;

        public Cat(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public int Hungry { get; internal set; }
    }
}