using System;

public interface ImprimanteMultifonction
{
    void Imprimer(String content);
    void Scanner(String content);
    void Faxer(String content);
    void ImprimerRectoVerso(String content);
}

class ImprimanteSuperChere implements ImprimanteMultifonction
{
     public void Imprimer(String content)
{
    System.out.println("J'ai imprimé !");
}
public void Scanner(String content)
{
    System.out.println("J'ai scanné !");
}
public void Faxer(String content)
{
    System.out.println("J'ai faxé !");
}
public void ImprimerRectoVerso(String content)
{
    System.out.println("J'ai imprimé recto-verso !");
}
}

interface ImprimanteImprime implements ImprimanteMultifonction
{
    public void Imprimer(String content)
{
    System.out.println("J'ai imprimé !");
}
}

interface Scanner implements ImprimanteMultifonction
{
    public void Scanner(String content)
{
    System.out.println("J'ai scanné !");
}
}

interface Facer implements ImprimanteMultifonction
{
    public void Faxer(String content)
{
    System.out.println("J'ai faxé !");
}
}

interface ImprimanteRectoVerso implements ImprimanteMultifonction
{
    public void ImprimerRectoVerso(String content)
{
    System.out.println("J'ai imprimé recto-verso !");
}
}

class ImprimantePasChere implements ImprimanteImprime
{
     public void Imprimer(String content)
{
    System.out.println("J'ai imprimé !");
}

}
