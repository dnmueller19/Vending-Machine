﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone.Classes;

namespace Capstone.Classes
{
	public class Change
	{
		//variables 
		//if we just want to convert all prices to pennies these could be int(q,d,n) 
		//and double for (TC)
		private decimal quarters;
		private decimal dimes;
		private decimal nickels;
		private decimal totalChange;


		//properties (derived)
		public decimal Quarters
		{
			get
			{
				return quarters;
			}
		}
		public decimal Dimes
		{
			get
			{
				return dimes;
			}
		}
		public decimal Nickels
		{
			get
			{
				return nickels;
			}
		}
		
		public decimal TotalChange
		{
			get
			{
				return totalChange;
			}
		}

		
		/// <summary>
		/// CONSTRUCTOR: creates a change object
		/// </summary>
		/// <param name="changeInCents"></param>
		public Change(decimal changeInCents)
		{
			totalChange = changeInCents;

			decimal changeThatMakesCents = changeInCents;

			while (changeThatMakesCents > 0)
			{
				if (changeThatMakesCents >= .25M)
				{
					quarters++;

					changeThatMakesCents = changeThatMakesCents - .25M;
				}
				else if (changeThatMakesCents >= .10M)
				{
					dimes++;
					changeThatMakesCents = changeThatMakesCents - .10M;
				}
				else if (changeThatMakesCents >= .05M)
				{
					nickels++;
					changeThatMakesCents = changeThatMakesCents - .05M;
				}



			}

		}
	}
}
