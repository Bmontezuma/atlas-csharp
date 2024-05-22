using System;

class Program
{
    static void Main(string[] args)
    {
        // Test case 0
        Player player0 = new Player("Plant Dinosaur");
        CalculateModifier mod0 = new CalculateModifier(player0.ApplyModifier);

        player0.PrintHealth();
        player0.TakeDamage(mod0(39f, Modifier.Base));
        player0.PrintHealth();

        // Test case 1
        Player player1 = new Player("Plant Dinosaur");
        CalculateModifier mod1 = new CalculateModifier(player1.ApplyModifier);

        player1.PrintHealth();
        player1.TakeDamage(mod1(39f, Modifier.Base));
        player1.PrintHealth();
        player1.HealDamage(mod1(18.9f, Modifier.Strong));
        player1.PrintHealth();

        // Test case 2
        Player player2 = new Player("Plant Dinosaur");
        CalculateModifier mod2 = new CalculateModifier(player2.ApplyModifier);

        player2.PrintHealth();
        player2.TakeDamage(mod2(30.25f, Modifier.Base));
        player2.PrintHealth();

        // Test case 3
        Player player3 = new Player("Plant Dinosaur");
        CalculateModifier mod3 = new CalculateModifier(player3.ApplyModifier);

        player3.PrintHealth();
        player3.TakeDamage(mod3(30.25f, Modifier.Base));
        player3.PrintHealth();
        player3.HealDamage(mod3(20f, Modifier.Base));
        player3.PrintHealth();

        // Test case 4
        Player player4 = new Player("Plant Dinosaur");
        CalculateModifier mod4 = new CalculateModifier(player4.ApplyModifier);

        player4.PrintHealth();
        player4.TakeDamage(mod4(100f, Modifier.Base));
        player4.PrintHealth();

        // Test case 5
        Player player5 = new Player("Plant Dinosaur");
        CalculateModifier mod5 = new CalculateModifier(player5.ApplyModifier);

        player5.PrintHealth();
        player5.TakeDamage(mod5(100f, Modifier.Base));
        player5.PrintHealth();
        player5.HealDamage(mod5(1f, Modifier.Base));
        player5.PrintHealth();

        // Test case 6
        Player player6 = new Player("Plant Dinosaur");
        CalculateModifier mod6 = new CalculateModifier(player6.ApplyModifier);

        player6.PrintHealth();
        player6.TakeDamage(mod6(0f, Modifier.Base));
        player6.PrintHealth();

        // Test case 7
        Player player7 = new Player("Plant Dinosaur");
        CalculateModifier mod7 = new CalculateModifier(player7.ApplyModifier);

        player7.PrintHealth();
        player7.HealDamage(mod7(0f, Modifier.Base));
        player7.PrintHealth();

        // Test case 8
        Player player8 = new Player("Plant Dinosaur");
        CalculateModifier mod8 = new CalculateModifier(player8.ApplyModifier);

        player8.PrintHealth();
        player8.TakeDamage(mod8(0f, Modifier.Base));
        player8.PrintHealth();

        // Test case 9
        Player player9 = new Player("Plant Dinosaur");
        CalculateModifier mod9 = new CalculateModifier(player9.ApplyModifier);

        player9.PrintHealth();
        player9.HealDamage(mod9(0f, Modifier.Base));
        player9.PrintHealth();

        // Test case 10
        Player player10 = new Player("Plant Dinosaur");
        CalculateModifier mod10 = new CalculateModifier(player10.ApplyModifier);

        player10.PrintHealth();
        player10.TakeDamage(mod10(0f, Modifier.Base));
        player10.PrintHealth();
    }
}
