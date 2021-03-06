﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace AngelShare.Models
{
    public class SeedData : DropCreateDatabaseAlways<MyDbContext>
    {
        protected override void Seed(MyDbContext context)
        {
            Membership silver = new Membership()
            {
                MembershipName = "Silver",
                MembershipPrice = 49.99m
            };
            context.Memberships.Add(silver);
            Membership gold = new Membership()
            {
                MembershipName = "Gold",
                MembershipPrice = 99.99m
            };
            context.Memberships.Add(gold);
            Membership platinum = new Membership()
            {
                MembershipName = "Platinum",
                MembershipPrice = 199.99m
            };
            context.Memberships.Add(platinum);


            Whiskey jack = new Whiskey()
            {
                Age = 4,
                Cost = 20,
                ProductName = "Jack Daniels",
                Proof = 40m,
                Type = "Bourbon"

            };
            context.Whiskeys.Add(jack);

            Whiskey tullamoreDew = new Whiskey()
            {
                Age = 3,
                Cost = 23,
                ProductName = "Tullamore Dew",
                Proof = 40m,
                Type = "Irish"
            };
            context.Whiskeys.Add(tullamoreDew);
            Whiskey johnny = new Whiskey()
            {
                Age = 12,
                Cost = 23,
                ProductName = "Johnny Walker Black",
                Proof = 55m,
                Type = "Scotch"
            };
            context.Whiskeys.Add(johnny);
            Whiskey bullietRye = new Whiskey()
            {
                Age = 3,
                Cost = 23,
                ProductName = "Bulliet Rye",
                Proof = 40m,
                Type = "Rye"
            };
            context.Whiskeys.Add(bullietRye);
            Whiskey yamazaki18 = new Whiskey()
            {
                Age = 18,
                Cost = 200m,
                ProductName = "Yamazaki 18 Year",
                Proof = 40m,
                Type = "Japanese"
            };
            context.Whiskeys.Add(yamazaki18);

            context.WhiskeyBoxes.Add(new WhiskeyBox()
            {
               Whiskey = yamazaki18,
               Membership = platinum         
            });
            context.WhiskeyBoxes.Add(new WhiskeyBox()
            {
                Whiskey = bullietRye,
                Membership = silver
            });
            context.WhiskeyBoxes.Add(new WhiskeyBox()
            {
                Whiskey = jack,
                Membership = silver
                
            });
            context.WhiskeyBoxes.Add(new WhiskeyBox()
            {
                Whiskey = tullamoreDew,
                Membership = silver
            });
            context.WhiskeyBoxes.Add(new WhiskeyBox()
            {
                Whiskey = bullietRye,
                Membership = silver
            });
            context.WhiskeyBoxes.Add(new WhiskeyBox()
            {
                Whiskey = johnny,
                Membership = gold
            });

            context.SaveChanges();
        }
    }
}