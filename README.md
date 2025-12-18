# AC03-Integracio-Continua-i-Test-Unitaris

## Interface configuration

### SonarCloud
SonarCloud is an online solution to work with SonarQube via cloud.

We need to **go to the service webpage** https://www.sonarsource.com/products/sonarqube/cloud/ , click "Start now" and **link your GitHub account**.

Once we are logged in, we install SonarCloud in the repositories we want to work and create an organization.

In this case, we create an organization called SonarCloud with the key sonarcloud25, choose the free plan and click "Create organization". Then, we must add the project we are working on. To do that, we may click "Analyze a new project" and select the repository we want to use.

### GitHub Actions

After we have configured SonarCloud, we have to use GitHub Actions and, for that, SonarCloud gives a token. We have to follow the path %RespositoryName > Settings > Secrets and Variables > Actions, click "Create new secret" and input SONAR_TOKEN as the name, and the tocken value as the secret. We procceed by clicking "Add secret".

When selecting the build options, we must choose .NET and create the build.yml as stated on the set-up process on our local machine, to then upload it to the repository.

And, with that, we should be settled.

> **Pregunta 1**: *En aquest anàlisi inicial del programa, es mostren resultats en l’apartat de cobertura de codi (coverage)? Raoneu la vostra resposta, incloent una captura de la pantalla de resum de SonarCloud.*
> <img width="1110" height="180" alt="image" src="https://github.com/user-attachments/assets/cf13676b-7907-41d6-a526-706a18f8dfe5" />

>
> Sense haver posat res cap test, el coverage és 0, ja que no s'està avaluant cap codi. Però sí que surt.

## Code Refactory

For this activity, we have been given a code we had to refactory.

The original code was:

``` C#
// Program.cs
using System;

namespace CodeWithIssues
{
    class Program
    {
        static void Main(string[] args)
        {
            int unusedVar = 10;

            Console.WriteLine("Benvingut al programa de càlculs!");
            Console.WriteLine("Benvingut al programa de càlculs!");

            int a = 5;
            int b = 10;
            int c = 15;
            int result = 0;

            if (a > 0)
            {
                if (b > 0)
                {
                    if (c > 0)
                    {
                        result = a + b + c;
                    }
                    else
                    {
                        result = a + b;
                    }
                }
                else
                {
                    result = a;
                }
            }
            else
            {
                result = 0;
            }

            if (result == 0)
            {
                Console.WriteLine("El resultat és zero.");
            }
            else if (result > 0)
            {
                Console.WriteLine("El resultat és positiu.");
            }
            else
            {
                Console.WriteLine("El resultat és negatiu.");
            }

            int counter = 0;
            while (true)
            {
                counter++;
                if (counter > 100)
                {
                    break;
                }
            }

            // int oldVar = 20;

            int x = 5;
            x = x + 0;

            Console.WriteLine("Finalitzant el programa...");
            Console.WriteLine("Finalitzant el programa...");
        }
    }
}
```# Credits

All SonarCloud configuration has been done following either SonarQube's manuals available on their webpage or the configuration's guide showed during the process itself.

Thanks to Raquel for answering all our doubts.
