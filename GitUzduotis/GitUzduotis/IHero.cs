namespace GitUzduotis
{
    public interface IHero
    {
        string UserName { get; set; }
        int Level { get; set; }

        void Strength();
        double AddPower(double power);
    }
}
