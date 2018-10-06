﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MovieTime2.Models
{
    public class DBInit : DropCreateDatabaseAlways<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            var Action = new Genre
            {
                Id = 1,
                Title = "Action"
            };
            context.Genre.Add(Action);

            var Animation = new Genre
            {
                Id = 2,
                Title = "Animation"
            };
            context.Genre.Add(Animation);

            var Comedy = new Genre
            {
                Id = 3,
                Title = "Comedy"
            };
            context.Genre.Add(Comedy);

            var Drama = new Genre
            {
                Id = 4,
                Title = "Drama"
            };
            context.Genre.Add(Drama);
            /* context.Genre.Add(Horror);
             var Romance = new Genre
             {
                 Id = 6,
                 Title = "Romance"
             };
             context.Genre.Add(Romance);
             var SciFi = new Genre
             {
                 Id = 7,
                 Title = "Sci-Fi"
             };
             context.Genre.Add(SciFi);
             var Western = new Genre
             {
                 Id = 8,
                 Title = "Western"
             };
             context.Genre.Add(Western); */



            var Bruce = new Movie
            {
                Title = "Bruce Almighty",
                Summary = "A guy who complains about God too often is given almighty powers to teach him how difficult it is to run the world.",
                Price =  45,
                ImageURL= "/content/Images/BruceAllmighty.jpg"

            };
            List<Genre> ComedyList = new List<Genre>();
            ComedyList.Add(Comedy);
            Bruce.Genre = ComedyList;
            context.Movie.Add(Bruce);

            var Black = new Movie
            {
                Title = "BlacKkKlansman",
                Summary = "Ron Stallworth, an African-American police officer from Colorado, successfully manages to infiltrate the local Ku Klux Klan with the help of a white surrogate, who eventually becomes head of the local branch.",
                Price = 45,
                ImageURL = "/Content/Images/BlacKkKlansman.jpg"

            };
            List<Genre> DramaList = new List<Genre>();
            DramaList.Add(Drama);
            Black.Genre = DramaList;
            context.Movie.Add(Black);
            
            var Bumble = new Movie
            {
                Title = "Bumblebee",
                Summary = "On the run in the year 1987, Bumblebee finds refuge in a junkyard in a small Californian beach town. Charlie, on the cusp of turning 18 and trying to find her place in the world, discovers Bumblebee, battle-scarred and broken.",
                Price = 45,
                ImageURL = "/Content/Images/Bumblebee.jpg"

            };
            List<Genre> ActionList = new List<Genre>();
            ActionList.Add(Action);
            Bumble.Genre = ActionList;
            context.Movie.Add(Bumble);
            
            var Coco = new Movie
            {
                Title = "Coco",
                Summary = "Aspiring musician Miguel, confronted with his family's ancestral ban on music, enters the Land of the Dead to find his great-great-grandfather, a legendary singer.",
                Price = 45,
                ImageURL = "/Content/Images/Coco.jpg"

            };
            List<Genre> AnimationList = new List<Genre>();
            AnimationList.Add(Animation);
            Coco.Genre = AnimationList;
            context.Movie.Add(Coco);

            var Finding = new Movie
            {
                Title = "Finding Nemo",
                Summary = "After his son is captured in the Great Barrier Reef and taken to Sydney, a timid clownfish sets out on a journey to bring him home.",
                Price = 45,
                ImageURL = "/Content/Images/FindingNemo.jpg"

            };
            List<Genre> AnimationList2 = new List<Genre>();
            AnimationList2.Add(Animation);
            Finding.Genre = AnimationList2;
            context.Movie.Add(Finding);

            var Dragon = new Movie
            {
                Title = "How To Train Your Dragon",
                Summary = "A hapless young Viking who aspires to hunt dragons becomes the unlikely friend of a young dragon himself, and learns there may be more to the creatures than he assumed.",
                Price = 45,
                ImageURL = "/Content/Images/HowToTrainYourDragon.jpg"

            };
            List<Genre> AnimationList3 = new List<Genre>();
            AnimationList3.Add(Animation);
            Dragon.Genre = AnimationList3;
            context.Movie.Add(Dragon);

            var Totoro = new Movie
            {
                Title = "My Neoghbor Totoro",
                Summary = "",
                Price = 45,
                ImageURL = "/Content/Images/MyNeighborTotoro.jpg"

            };
            List<Genre> AnimationList4 = new List<Genre>();
            AnimationList4.Add(Animation);
            Totoro.Genre = AnimationList4;
            context.Movie.Add(Totoro);

            var Princess = new Movie
            {
                Title = "Princess Mononoke",
                Summary = "On a journey to find the cure for a Tatarigami's curse, Ashitaka finds himself in the middle of a war between the forest gods and Tatara, a mining colony. In this quest he also meets San, the Mononoke Hime.",
                Price = 45,
                ImageURL = "/Content/Images/PrincessMononoke.jpg"

            };
            List<Genre> AnimationList5 = new List<Genre>();
            AnimationList5.Add(Animation);
            Princess.Genre = AnimationList5;
            context.Movie.Add(Princess);

            var Spirit = new Movie
            {
                Title = "Spirited Away",
                Summary = "During her family's move to the suburbs, a sullen 10-year-old girl wanders into a world ruled by gods, witches, and spirits, and where humans are changed into beasts.",
                Price = 45,
                ImageURL = "/Content/Images/SpiritedAway.jpg"

            };
            List<Genre> AnimationList6 = new List<Genre>();
            AnimationList6.Add(Animation);
            Spirit.Genre = AnimationList6;
            context.Movie.Add(Spirit);

            var UP = new Movie
            {
                Title = "UP",
                Summary = "Seventy-eight year old Carl Fredricksen travels to Paradise Falls in his home equipped with balloons, inadvertently taking a young stowaway.",
                Price = 45,
                ImageURL = "/Content/Images/Up.jpg"

            };
            List<Genre> AnimationList7 = new List<Genre>();
            AnimationList7.Add(Animation);
            UP.Genre = AnimationList7;
            context.Movie.Add(UP);

            var Wall = new Movie
            {
                Title = "Wall-E",
                Summary = "In the distant future, a small waste-collecting robot inadvertently embarks on a space journey that will ultimately decide the fate of mankind.",
                Price = 45,
                ImageURL = "/Content/Images/Wall-E.jpg"

            };
            List<Genre> AnimationList8 = new List<Genre>();
            AnimationList8.Add(Animation);
            Wall.Genre = AnimationList8;
            context.Movie.Add(Wall);

            var Your = new Movie
            {
                Title = "Your Name",
                Summary = "Two strangers find themselves linked in a bizarre way. When a connection forms, will distance be the only thing to keep them apart?",
                Price = 45,
                ImageURL = "/Content/Images/YourName.jpg"

            };
            List<Genre> AnimationList9 = new List<Genre>();
            AnimationList9.Add(Animation);
            Your.Genre = AnimationList9;
            context.Movie.Add(Your);


            var Ace = new Movie
            {
                Title = "Ace Ventura",
                Summary = "A goofy detective specializing in animals goes in search of the missing mascot of the Miami Dolphins.",
                Price = 45,
                ImageURL = "/Content/Images/AceVentura.jpg"

            };
            List<Genre> ComedyList2 = new List<Genre>();
            ComedyList2.Add(Comedy);
            Ace.Genre = ComedyList2;
            context.Movie.Add(Ace);

            var Central = new Movie
            {
                Title = "Central Intelligence",
                Summary = "After he reconnects with an awkward pal from high school through Facebook, a mild-mannered accountant is lured into the world of international espionage.",
                Price = 45,
                ImageURL = "/Content/Images/CentralIntelligence.jpg"

            };
            List<Genre> ComedyList3 = new List<Genre>();
            ComedyList3.Add(Comedy);
            Central.Genre = ComedyList3;
            context.Movie.Add(Central);

            var Klown = new Movie
            {
                Title = "Klown",
                Summary = "In order to prove his fatherhood potential to his pregnant girlfriend, Frank 'kidnaps' her 12-year-old nephew and tags along on his best friend Casper's debauched weekend canoe trip.",
                Price = 45,
                ImageURL = "/Content/Images/Klown.jpg"

            };
            List<Genre> ComedyList4 = new List<Genre>();
            ComedyList4.Add(Comedy);
            Klown.Genre = ComedyList4;
            context.Movie.Add(Klown);

            var Ride = new Movie
            {
                Title = "Ride Along",
                Summary = "Security guard Ben must prove himself to his girlfriend's brother, top police officer James. He rides along James on a 24-hour patrol of Atlanta.",
                Price = 45,
                ImageURL = "/Content/Images/RideAlong.jpg"

            };
            List<Genre> ComedyList5 = new List<Genre>();
            ComedyList5.Add(Comedy);
            Ride.Genre = ComedyList5;
            context.Movie.Add(Ride);

            var Night = new Movie
            {
                Title = "NightSchool",
                Summary = "A group of troublemakers are forced to attend night school in hope that they'll pass the GED exam to finish high school.",
                Price = 45,
                ImageURL = "/Content/Images/NightSchool.jpg"

            };
            List<Genre> ComedyList6 = new List<Genre>();
            ComedyList6.Add(Comedy);
            Night.Genre = ComedyList6;
            context.Movie.Add(Night);

            var Borat = new Movie
            {
                Title = "Borat",
                Summary = "Kazakh TV talking head Borat is dispatched to the United States to report on the greatest country in the world. With a documentary crew in tow, Borat becomes more interested in locating and marrying Pamela Anderson.",
                Price = 45,
                ImageURL = "/Content/Images/Borat.jpg"

            };
            List<Genre> ComedyList7 = new List<Genre>();
            ComedyList7.Add(Comedy);
            Borat.Genre = ComedyList7;
            context.Movie.Add(Borat);

            var Hot = new Movie
            {
                Title = "Hot Fuzz",
                Summary = "A skilled London police officer is transferred to a small town that's harbouring a dark secret.",
                Price = 45,
                ImageURL = "/Content/Images/HotFuzz.jpg"

            };
            List<Genre> ComedyList8 = new List<Genre>();
            ComedyList8.Add(Comedy);
            Hot.Genre = ComedyList8;
            context.Movie.Add(Hot);

            var Mean = new Movie
            {
                Title = "Mean Girls",
                Summary = "Cady Heron is a hit with The Plastics, the A-list girl clique at her new school, until she makes the mistake of falling for Aaron Samuels, the ex-boyfriend of alpha Plastic Regina George.",
                Price = 45,
                ImageURL = "/Content/Images/MeanGirls.jpg"

            };
            List<Genre> ComedyList9 = new List<Genre>();
            ComedyList9.Add(Comedy);
            Mean.Genre = ComedyList9;
            context.Movie.Add(Mean);


            base.Seed(context);
        }
    }
}