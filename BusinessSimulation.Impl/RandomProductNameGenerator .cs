﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessSimulation.Impl
{
    public static class RandomProductNameGenerator
    {
        private static Random _random = new Random();
        private static List<string> _candidatesNames = new List<string> {

"bœuf",
"veau",
"porc",
"Volaille",
"saucisses",
"Burger",
"nuggets",
"manchon",
"Steacks",
"hachés",
"agneau",
"lapin",
"poisson",
"jambon blanc",
"jambon cru",
"jambon de volaille",
"saucisson",
"pâté",
"rillette",
"terrine",
"saucisses",
"knackis",
"lardons",
"bacon",
"Pommes de terre",
"Tomates",
"concombre",
"courgettes",
"aubergines",
"potiron",
"Salades vertes",
"choux",
"choux fleurs",
"poireaux",
"carottes",
"poivrons",
"haricots verts/blancs",
"brocolis",
"champignons",
"avocats",
"navets",
"épinards",
"autres légumes",
"Ail",
"Oignon",
"Echalotte",
"Herbes fraiches",
"Saumon fume",
"Foies gras",
"Barquettes de crudités",
"Soupes",
"Gazpacho",
"Croques",
"crepes",
"galettes",
"Pizza",
"quiches",
"tartes",
"Panes",
"cordons bleus",
"manchons",
"Plats cuisines",
"Produits vegetaux",
"tofu",
"Pates fraiches",
"quenelles",
"Pates a tarte/ a gateau",
"Houmous",
"tazziki",
"guacamole",
"Blinis",
"caviar",
"lompe",
"tarama",
"Surimi",
"steak",
"crevettes",
"anchois",
"beurre doux",
"beurre salé",
"margarine",
"œufs",
"crème  fraîche épaisse",
"crème  fraîche liquide",
"sauces",
"mayonnaise",
"yaourts natures",
"yaourts aux fruits",
"yaourts enfants",
"yaourts à boire",
"yaourts santé/minceur",
"petits suisses",
"fromages blancs",
"Agrumes",
"Pommes",
"Poires",
"Bananes",
"Fruits rouges",
"Fruits exotiques",
"Autres Fruits",
"Poilane",
"Pain de mie",
"hamburgers",
"Pain et baguette",
"Brioches",
"briochettes",
"Pain au lait",
"croissant",
"gouter", 
"Crepes",
"pancakes",
"muffins",
"Emmental",
"Comte",
"Cantal",
"Camembert",
"Coulomier",
"Brie",
"chèvre / brebis",
"Roquefort",
"bleu",
"Mozzarella",
"feta",
"Rape",
"parmesan",
"Fromage a  tartiner",
"Fromage pour enfants",
"autres",
"Compotes en gourdes",
"Compotes standards",
"Salades de fruits",
"Boisson lactee",
"Smoothie",
"Jus d'orange",
"Jus de fruits",
"Jus de fruits et legumes",
"Galettes",
"Sables",
"Biscuits chocolats",
"Biscuits aux fruits",
"Equilibre",
"Bien être",
"Gouters Fourrés",
"Biscuits Petit Dejeuner",
"Quatre Quarts",
"Cake",
"Pain d'epices",
"Madeleines",
"Gaufres",
"Barres chocolatees",
"Bonbons",
"Chewing gum",
"Chocolat Noir",
"Chocolat au lait",
"Chocolat Blanc",
"Chocolat Dessert",
"Compotes",
"Creme dessert",
"Riz au lait",
"Fruits au sirop",
"Petits pois",
"haricots verts",
"blancs",
"rouges",
"carottes",
"autres légumes",
"thon",
"sardines",
"autres poissons",
"plats cuisinés",
"pâtés",
"soupes",
"croutons",
"purée",
"pates",
"riz",
"blé",
"semoule",
"Produits exotiques",
"légumes secs",
"autres",
"Farine",
"Preparations",
"Maizena",
"fecule",
"Chapelure",
"Sucre en morceaux",
"Sucre en poudre",
"Chocolat patissier",
"Levure",
"sucre vanillé",
"Nappage & cremes",
"Aromes",
"décoration",
"Fruits secs",
"cornichons",
"sel / épices",
"sauce tomate",
"ketchup",
"mayonnaise",
"huile",
"vinaigre", 
"moutarde",
"autres",
"Chips",
"Tuilles",
"Pistaches",
"Amandes",
"cacahouettes",
"cajoux",
"Olives",
"Crackers",
"feuilletés",
"bretzel",
"autres",
"confiture de fraise",
"autres confitures",
"miel",
"nutella",
"autre",
"céréales enfants",
"autres céréales",
"biscottes",
"pain suédois",
"autres",
"Cafés Classiques",
"Expresso",
"Decafeines & Doux",
"Dosettes",
"Chicorés",
"Chocolats en poudre",
"Thé nature",
"Thés parfumés",
"Infusions",
"Filtres",
"autres",
"papier alu / cuisson / film plastique",
"sacs congélation",
"allume gaz / bougies",
"vaisselle jetable",
"piles",
"autres",
"litière", 
"croquettes",
"boites",
"autres",
"brosse à dents",
"dentifrice",
"déodorant",
"coton",
"coton tige",
"soin visage",
"Savon",
"gel douche",
"shampoing",
"soin du cheveux",
"soin du corps",
"rasoirs",
"mousse à raser",
"épilation",
"couches bébé",
"hygiène bébé",
"hygiène féminine",
"mouchoirs",
"papier toilette", 
"autres",
"produit vitre",
"anticalcaire",
"dégraissant",
"nettoyant four",
"javel",
"produit sol",
"liquide multi-usage",
"liquide vaisselle main", 
"Produit lave vaisselle",
"détartrant WC",
"éponges",
"gants ménage",
"Lessive classique",
"lessive spéciale linge noir",
"lessive spéciale laine",
"assouplissant",
"anti-tâche",
"essuie-tout",
"sacs poubelle",
"autres",
"lait",
"eau minérale plate / gazeuse",
"jus fruits",
"sodas",
"sirops",
"vin",
"alcools"
        };

        public static string Generate()
        {
            throw new NotImplementedException();
        }
    }
}
