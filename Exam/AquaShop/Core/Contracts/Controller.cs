using AquaShop.Models.Aquariums;
using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish;
using AquaShop.Models.Fish.Contracts;
using AquaShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaShop.Core.Contracts
{
    public class Controller : IController
    {
        private DecorationRepository decorations;
        private List<IAquarium> aquariums;
        public Controller()
        {
            decorations = new DecorationRepository();
            aquariums = new List<IAquarium>();
        }
        public string AddAquarium(string aquariumType, string aquariumName)
        {
            IAquarium newAqua=null;
            if (aquariumType == "FreshwaterAquarium")
                newAqua = new FreshwaterAquarium(aquariumName);
            else if (aquariumType == "SaltwaterAquarium")
                newAqua = new SaltwaterAquarium(aquariumName);
            else
            {
                throw new InvalidOperationException("Invalid aquarium type.");
            }
           this.aquariums.Add(newAqua);
            return $"Successfully added {aquariumType}.";
        }

        public string AddDecoration(string decorationType)
        {
            IDecoration decoration = null;
            if (decorationType == "Ornament")
                decoration = new Ornament();
            else if (decorationType == "Plant")
                decoration = new Plant();
            else
            {
                throw new InvalidOperationException("Invalid decoration type.");
            }
            this.decorations.Add(decoration);
            return $"Successfully added {decorationType}.";
        }

        public string AddFish(string aquariumName, string fishType, string fishName, string fishSpecies, decimal price)
        {
            IFish currentFish = null;
            if (fishType == "FreshwaterFish")
                currentFish = new FreshwaterFish(fishName, fishSpecies, price);
            else if (fishType == "SaltwaterFish")
                currentFish = new SaltwaterFish(fishName, fishSpecies, price);
            else
                throw new InvalidOperationException("Invalid fish type.");
            //IAquarium currentAqua = this.aquariums.FirstOrDefault(x => x.Name == aquariumName);
            foreach (var aqua in this.aquariums)
            {
                if (aqua.Name == aquariumName)
                {
                    if (currentFish.GetType().Name == "FreshwaterFish"
                        && aqua.GetType().Name != "FreshwaterAquarium")
                        return "Water not suitable.";
                    if (currentFish.GetType().Name== "SaltwaterFish" &&
                        aqua.GetType().Name != "SaltwaterAquarium")
                        return "Water not suitable.";
                    aqua.AddFish(currentFish);
                    return $"Successfully added {fishType} to {aquariumName}.";
                }
            } // dobavih nov return
            return "Invalid aquariumName";
        }

        public string CalculateValue(string aquariumName)
        {
            decimal resultPrice = 0;
            IAquarium currentAqua = this.aquariums.FirstOrDefault(x => x.Name == aquariumName);
            if (currentAqua == null)
                throw new InvalidOperationException("There is no such aquariumName");
            foreach (var item in currentAqua.Decorations)
            {
                resultPrice += item.Price;
            }
            foreach (var fish in currentAqua.Fish)
            {
                resultPrice += fish.Price;
            }
            return $"The value of Aquarium {aquariumName} is {resultPrice:f2}.";
        }

        public string FeedFish(string aquariumName)
        {
            int fedCount = 0;
            foreach (var aqua in aquariums)
            {
                if (aqua.Name == aquariumName)
                {
                    aqua.Feed();
                    fedCount = aqua.Fish.Count;
                }
            } // da proveria dali e nujna prowerka za sushtestvuvash aquarium
            return $"Fish fed: {fedCount}";
        }

        public string InsertDecoration(string aquariumName, string decorationType)
        {
            IDecoration currentDecor = null;
            //    this.decorations.FirstOrDeafault(x => x.GetType().Name == decorationType) as IDecoration;
            foreach (var dec in this.decorations.Models)
            {
                if (dec.GetType().Name == decorationType)
                    currentDecor = dec;
            }
            var currentAquarium = 
                this.aquariums.FirstOrDefault(x => x.Name == aquariumName);

            if (currentDecor != null)
            {
                foreach (var aqua in this.aquariums)
                {
                    if (aqua.Name == aquariumName)
                    {
                        aqua.AddDecoration(currentDecor);
                        this.decorations.Remove(currentDecor);
                        break;
                    }
                }
            }
            else
                throw new InvalidOperationException($"There isn't a decoration of type {decorationType}.");

            return $"Successfully added {decorationType} to {aquariumName}.";
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();
            foreach (var aqua in aquariums)
            {
                //result.AppendLine($"{aqua.Name} ({aqua.GetType().Name}):");
                result.AppendLine(aqua.GetInfo());
            }
            return result.ToString().TrimEnd();
        }
    }
}
