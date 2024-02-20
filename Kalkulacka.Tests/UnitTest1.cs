namespace Kalkulacka.Tests
{
    public class UnitTest1
    {

        double vysledek = 0;
        Kalkulacka mojeKalkulacka = new Kalkulacka();

        [Fact]
        public void TestSecti() //test pro sèítání
        {

            vysledek =  mojeKalkulacka.Secti(1, 5); 
            Assert.Equal(6, vysledek);

            vysledek = mojeKalkulacka.Secti(-2, 3);
            Assert.Equal(1, vysledek);

            vysledek = mojeKalkulacka.Secti(0.3, 0.1);
            Assert.Equal(0.4, vysledek, 0.0001);
        }

        [Fact]
        public void TestOdecti() //test pro odèítání
        {
            vysledek = mojeKalkulacka.Odecti(1, 5);
            Assert.Equal(-4, vysledek);

            vysledek = mojeKalkulacka.Odecti(-2, -5);
            Assert.Equal(3, vysledek);

            vysledek = mojeKalkulacka.Odecti(0.3, 0.2);
            Assert.Equal(0.1, vysledek, 0.0001); 
        }

        [Fact]
        public void TestVynasob() //test pro násobení
        {
            vysledek = mojeKalkulacka.Vynasob(2, 5);
            Assert.Equal(10, vysledek);

            vysledek = mojeKalkulacka.Vynasob(0.2, 0.6);
            Assert.Equal(0.12, vysledek);

            vysledek = mojeKalkulacka.Vynasob(-2, -3);
            Assert.Equal(6, vysledek, 0.0001);
        }

        [Fact]
        public void TestVydel() //test pro dìlení
        {
            vysledek = mojeKalkulacka.Vydel(10, 5);
            Assert.Equal(2, vysledek);

            vysledek = mojeKalkulacka.Vydel(2, 4);
            Assert.Equal(0.5, vysledek);

            vysledek = mojeKalkulacka.Vydel(1.2, 2.4);
            Assert.Equal(0.5, vysledek, 0.0001);
        }
    }
}