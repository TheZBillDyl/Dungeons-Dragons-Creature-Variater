using System;

public class Creature
{
	/*
	 * Might remove the Creature class. May not need
	 * 
	 */
	public string Name {  get; set; }
	public int AC {  get; set; }
	public int Health {  get; set; }
	public int Strength {  get; set; }
	public int Dexterity { get; set; }
	public int Constitution { get; set; }
	public int Intelligence { get; set; }
	public int Wisdom { get; set; }
	public int Charisma { get; set; }
	
	public Creature()
	{
		Name = "";
		AC = 0;
		Health = 0;
		Strength = 10;
		Dexterity = 10;
		Constitution = 10;
		Intelligence = 10;
		Wisdom = 10;
		Charisma = 10;
	}
}

public class Weapon
{
	public string Name {  get; set; }
	public int DamageDie {  get; set; }
	public int DamageDieAmount { get; set; }
	public int Modifier {  get; set; }
	public string FilePath {  get; set; }
}

public class Armor
{
	public string Name {  get; set; }
	public int AC {  get; set; }
	public int MaxAC {  get; set; }
	public bool StealthDisadvantage {  get; set; }
	public string FilePath {  get; set; }

    public Armor()
    {
		Name = "Armor";
		AC = 10;
		MaxAC = 0;
		StealthDisadvantage = false;
    }
}