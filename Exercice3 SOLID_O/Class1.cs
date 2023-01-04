using System;



class Client : Consommable
{
    feeling = "normal";
    energy = 1000;

    boire(boisson)
    {
        switch (boisson.nom)
        {
            case "CAFÉ:
            this.feeling = "réveillé";
                this.energy += boisson.calories;
                break;
            case "TISANE":
                this.feeling = "reposé";
                this.energy += boisson.calories;
                break;
            case "SOUPE":
                this.feeling = "rassasié";
                this.energy += boisson.calories;
                break;
        }
    }
}

class Boisson 
{
    name = "EAU";
    calories = 0;

    constructor(name, calories)
    {
        this.name = name;
        this.calories = calories;
    }
}

class Restaurant
{
    main()
    {
        client = new Client();
        cafe = new Boisson("CAFÉ", 1);
        client.boire(cafe);
        // Comment gérer de nouvelles boissons ?
        client.boire(new Boisson("THÉ", 1));
        // Comment passer energy du client à 0 ?
        client.boire(new Boisson("POISON", 0));
    }
}

interface Consommable(){
    boire(boisson)
    {
        switch (boisson.nom)
        {
            case "THÉ:
            this.feeling = "bien";
                this.energy += boisson.calories;
                break;
            case "POISON":
                this.feeling = "mort";
                this.energy = 0;
                break;
        }
    }
}