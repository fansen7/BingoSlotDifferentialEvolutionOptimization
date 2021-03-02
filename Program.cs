﻿using System;

namespace BingoSlotDifferentialEvolutionOptimization {
class MainClass {
	public static void Main (string[] args) {
		double[] targets = {0.90, 0.91, 0.92, 0.93, 0.94, 0.95, 0.96, 0.97, 0.98, 0.99};

		int[][][] reels = {
				/* 90% */
			new int[][] {
new int[] {10,12,6,4,7,10,4,5,7,12,6,9,3,5,8,10,9,6,11,8,10,4,7,9,4,12,3,7,11,6,10,5,4,8,11,3,8,10,11,5,7,4,6,9,3,10,11,9,5,4,3,6,12,7,6,4,7,5,8,10,11,5,8,},
new int[] {10,3,6,5,11,7,12,5,4,11,8,9,11,3,9,5,12,6,8,11,12,3,4,6,11,10,5,6,7,12,8,4,9,12,3,6,12,8,9,3,6,10,3,7,5,3,9,10,3,4,11,10,3,8,5,7,8,12,6,11,7,8,12,},
new int[] {9,4,5,12,7,5,8,10,9,4,5,6,10,11,8,5,6,8,9,7,11,6,8,12,7,9,4,6,9,12,8,4,7,5,8,6,11,8,4,7,8,12,10,8,5,7,12,5,8,3,6,11,4,5,10,11,4,3,11,4,5,11,12,},
new int[] {3,10,8,3,10,11,5,12,6,9,7,5,3,9,6,7,5,12,8,5,4,7,5,11,6,4,12,10,6,4,11,10,3,7,6,10,7,12,11,9,6,12,5,7,4,3,12,8,3,5,7,9,4,5,3,4,10,6,3,9,7,12,5,},
new int[] {10,5,12,6,11,7,12,5,10,9,6,12,11,5,8,10,7,4,8,3,6,12,11,10,5,7,6,10,7,3,6,11,10,6,9,10,7,9,10,11,8,12,4,5,6,9,4,8,3,7,4,5,7,11,9,10,7,8,4,6,7,5,4,},
			},

				/* 91% */
			new int[][] {
new int[] {7,10,3,9,6,10,11,5,4,9,11,4,3,7,9,5,7,9,4,5,8,9,11,10,5,8,12,3,9,7,4,11,12,4,6,9,10,6,5,11,8,5,10,6,11,12,9,7,11,3,8,7,5,6,11,7,10,4,9,6,10,4,9,},
new int[] {3,6,8,4,10,6,12,10,8,11,12,5,11,8,4,10,12,9,7,4,5,7,9,3,7,5,10,11,7,10,11,6,4,8,12,4,3,6,8,11,5,9,6,10,9,5,8,7,3,10,8,9,11,5,7,4,8,6,7,11,4,5,7,},
new int[] {5,7,8,10,3,8,7,4,8,11,12,5,9,8,5,9,6,4,9,8,11,7,4,10,6,4,11,9,8,7,6,11,9,4,11,8,5,7,6,10,4,8,6,11,8,12,11,7,6,8,4,9,3,8,11,6,4,5,12,3,5,7,6,},
new int[] {9,4,5,8,3,12,7,4,11,9,7,6,8,10,4,12,7,9,11,4,3,9,7,3,4,12,11,9,8,3,12,10,3,9,10,6,11,4,3,9,11,12,10,11,8,4,10,7,12,4,5,7,3,11,6,7,8,9,10,11,4,10,3,},
new int[] {9,6,7,8,12,10,9,12,7,5,12,10,7,3,10,4,3,7,8,5,3,10,9,11,6,8,3,10,4,5,11,9,6,3,8,6,10,12,5,8,10,11,7,4,8,10,12,7,5,10,4,3,10,8,11,6,4,10,12,7,6,11,8,},
			},

				/* 92% */
			new int[][] {
new int[] {8,7,3,12,6,10,11,9,6,5,9,11,5,6,7,8,5,9,10,12,4,6,10,8,5,6,9,11,6,4,9,10,12,9,11,4,6,12,5,9,12,7,5,11,7,12,3,4,10,3,9,5,7,6,11,7,8,10,3,7,8,6,10,},
new int[] {3,11,4,12,7,4,10,5,9,8,3,9,4,7,5,4,10,11,8,12,6,8,4,12,8,10,9,8,10,4,5,6,10,12,5,11,3,10,5,8,7,10,5,7,12,6,11,9,7,8,9,6,4,9,7,6,8,10,7,6,5,9,4,},
new int[] {8,4,9,8,5,9,3,4,9,5,3,9,4,6,7,4,5,9,8,12,5,10,11,6,5,4,9,5,11,8,3,11,12,7,5,3,7,9,12,8,6,11,9,7,5,11,7,4,10,5,6,3,11,7,8,4,9,10,4,9,5,3,9,},
new int[] {11,9,7,5,8,3,5,6,11,5,10,6,4,7,9,5,4,10,7,5,4,3,11,4,12,8,4,7,8,3,5,10,11,5,7,9,5,3,9,4,6,5,11,4,3,6,11,9,7,12,10,7,11,9,3,4,8,12,5,6,7,3,10,},
new int[] {10,12,4,11,3,4,9,5,10,11,12,9,10,3,5,4,11,8,7,5,3,11,6,7,12,6,8,5,10,11,6,4,10,7,5,11,9,8,4,6,9,3,11,8,6,12,11,6,5,12,10,5,9,8,10,4,5,3,6,7,11,9,8,},
			},

				/* 93% */
			new int[][] {
new int[] {7,9,6,10,8,3,4,8,10,6,7,10,5,8,4,9,6,10,12,11,3,8,5,7,4,6,8,4,11,3,8,6,12,11,7,12,3,9,11,5,8,4,5,10,7,4,10,9,3,6,7,4,5,10,9,6,4,10,8,11,4,10,6,},
new int[] {5,7,10,9,6,11,12,6,9,3,7,4,11,6,4,7,6,3,5,7,8,11,5,9,4,6,9,5,8,7,6,5,9,10,7,5,8,10,11,5,6,4,7,11,5,12,10,9,7,6,11,5,10,6,11,9,12,8,5,7,3,8,4,},
new int[] {10,7,11,10,5,4,10,6,11,12,7,10,9,12,10,6,12,4,9,12,4,9,8,5,7,10,3,11,8,10,7,3,9,7,12,6,11,4,7,8,9,3,4,9,12,5,3,7,11,3,7,5,8,9,7,4,6,5,3,9,6,11,3,},
new int[] {8,9,7,5,4,7,6,11,12,4,10,12,9,6,7,5,3,10,4,12,5,9,8,10,9,5,10,12,5,6,10,12,4,8,5,4,11,9,7,12,11,6,9,3,8,11,4,6,7,11,6,3,5,4,10,6,5,4,10,7,6,9,10,},
new int[] {10,12,6,5,4,11,3,12,7,4,6,9,8,4,11,6,9,7,3,6,9,3,10,7,6,4,11,5,9,7,6,11,10,5,8,4,12,3,10,8,6,12,7,10,4,6,10,9,7,12,8,4,7,11,3,6,9,4,3,12,11,6,8,},
			},

				/* 94% */
			new int[][] {
new int[] {10,4,9,6,11,12,9,10,5,8,6,7,12,3,5,11,12,4,7,9,6,3,7,6,11,8,12,10,8,7,5,11,12,9,7,4,5,10,8,9,4,3,6,8,3,7,5,4,9,6,8,5,4,11,5,4,11,7,6,5,11,9,12,},
new int[] {8,4,12,7,6,8,9,6,5,4,10,5,8,4,10,6,7,4,10,5,3,6,11,10,6,4,12,8,5,10,9,12,5,7,6,8,12,6,11,12,7,5,12,10,5,11,9,12,3,11,10,7,3,9,11,7,4,8,11,9,4,12,10,},
new int[] {12,4,3,6,12,9,4,7,11,10,8,3,11,9,4,7,8,6,3,9,10,6,9,7,10,3,9,6,10,11,9,5,3,6,8,7,3,10,11,9,10,6,5,4,11,8,5,9,8,4,11,5,9,12,4,6,5,4,8,6,12,5,3,},
new int[] {5,7,9,3,7,9,4,3,6,5,4,12,10,11,3,5,7,6,10,4,5,6,7,11,3,12,6,8,11,7,5,3,12,5,6,3,11,12,3,9,12,4,11,8,5,3,9,8,10,3,11,8,5,9,7,8,9,11,10,4,7,3,10,},
new int[] {7,8,5,9,6,7,10,12,9,3,7,8,6,11,8,7,4,9,6,7,10,11,12,7,9,6,4,8,3,10,6,4,7,3,9,6,11,5,3,6,10,12,5,11,3,12,8,7,5,6,7,8,12,7,5,12,7,5,9,3,8,9,10,},
			},

				/* 95% */
			new int[][] {
new int[] {10,5,9,12,3,8,4,7,8,3,12,9,6,4,10,7,9,3,8,4,5,9,12,4,5,11,12,6,3,5,8,3,10,7,9,4,8,5,11,8,4,12,8,5,6,7,3,11,10,6,4,10,12,5,4,8,10,7,11,10,6,3,8,},
new int[] {5,6,10,3,5,10,11,5,9,6,3,12,7,11,10,6,7,4,12,10,9,6,11,9,5,8,4,6,5,7,11,4,10,11,9,3,4,10,11,9,8,5,12,8,4,10,11,9,12,6,9,12,7,6,9,5,8,4,5,11,9,6,8,},
new int[] {7,4,6,5,10,8,6,10,5,4,7,9,10,7,12,11,5,6,7,5,4,10,6,3,12,4,9,5,11,6,9,8,12,4,7,3,10,11,7,12,10,4,11,5,3,9,8,10,9,12,11,6,10,9,11,4,7,6,8,5,4,6,11,},
new int[] {9,12,3,6,10,3,4,5,7,4,5,8,9,10,12,5,4,8,5,11,12,10,3,11,6,5,12,3,6,8,4,10,8,7,6,12,8,5,3,6,10,9,5,7,9,5,8,10,3,12,5,11,3,5,4,10,3,4,8,3,6,7,4,},
new int[] {12,8,9,7,8,6,5,11,3,5,7,9,6,3,11,4,12,7,3,5,8,11,4,5,11,7,9,3,10,5,3,7,8,4,9,6,7,8,4,10,3,12,10,7,5,12,6,9,10,5,7,9,12,10,5,6,12,11,8,3,10,4,3,},
			},

				/* 96% */
			new int[][] {
new int[] {3,4,10,7,11,9,6,7,4,8,9,10,3,7,12,6,7,5,6,4,11,7,10,11,6,7,10,3,11,6,10,8,4,12,3,5,8,4,9,11,6,10,5,8,12,7,4,10,7,5,12,4,6,12,11,5,9,8,12,5,8,9,7,},
new int[] {9,3,5,6,8,4,5,6,11,7,9,11,10,9,5,6,12,3,6,9,5,8,6,9,3,7,11,10,7,4,6,12,9,11,4,3,7,12,3,5,9,10,7,11,8,12,7,5,3,7,10,12,9,11,4,7,3,4,5,9,4,12,11,},
new int[] {5,11,4,9,7,12,4,8,10,6,8,9,5,3,10,4,3,6,12,4,8,10,6,12,8,6,12,10,7,11,4,8,11,12,10,11,4,9,8,5,3,7,5,8,12,10,6,5,11,12,9,4,6,5,12,4,8,5,9,7,10,4,3,},
new int[] {12,6,5,7,11,8,6,5,11,9,6,7,8,12,3,11,5,10,8,5,11,4,5,10,11,5,12,8,10,11,8,6,4,9,3,6,8,11,6,12,5,4,8,10,5,6,9,10,3,11,7,5,8,7,5,8,12,3,4,9,10,8,3,},
new int[] {9,3,8,11,7,8,11,4,5,3,11,12,6,5,9,7,5,9,10,3,4,7,3,8,11,9,7,5,12,6,8,12,3,4,6,5,7,4,5,12,11,5,3,7,9,6,11,9,7,10,6,11,5,8,9,10,8,12,11,10,7,5,10,},
			},

				/* 97% */
			new int[][] {
new int[] {10,4,6,10,9,8,3,10,11,4,10,6,8,10,3,7,11,3,4,7,6,5,3,12,6,5,12,3,8,4,7,8,4,11,6,4,8,7,5,12,9,3,12,9,7,5,9,11,3,6,10,5,6,12,8,3,12,8,5,7,6,8,7,},
new int[] {11,6,7,5,8,3,12,11,8,4,5,8,4,9,11,6,8,7,4,6,11,12,6,10,5,7,12,9,7,12,8,6,4,12,11,8,5,7,10,12,6,10,9,12,3,6,4,9,6,4,5,9,4,7,9,5,11,3,12,7,5,6,8,},
new int[] {7,10,5,8,11,5,4,7,10,5,3,9,7,11,5,6,4,11,10,8,4,12,11,5,9,10,7,6,9,8,6,10,11,5,8,3,5,9,11,10,6,4,10,5,7,9,11,4,5,8,3,6,4,9,3,7,11,5,8,12,5,9,11,},
new int[] {4,5,11,8,6,3,7,8,6,4,7,6,11,7,5,4,11,7,10,11,8,6,9,3,12,6,4,7,5,6,10,12,9,10,5,7,4,8,11,10,4,9,12,10,9,3,11,12,4,7,8,9,7,8,12,4,8,3,9,6,5,8,10,},
new int[] {11,4,12,11,5,8,4,11,9,3,6,10,3,7,4,6,5,7,10,8,5,11,7,9,4,8,11,9,12,6,9,12,7,8,9,7,4,11,8,10,7,4,5,9,7,8,10,3,5,11,12,6,10,4,9,11,7,5,4,11,8,6,10,},
			},

				/* 98% */
			new int[][] {
new int[] {5,7,11,10,6,7,12,6,7,9,10,5,6,7,8,3,7,6,4,7,5,6,9,5,12,11,8,6,10,4,11,10,6,8,10,5,4,8,6,10,11,4,7,9,5,12,3,8,4,10,7,5,11,8,6,4,12,11,7,3,12,4,9,},
new int[] {11,6,9,7,4,9,12,6,3,9,11,10,12,4,7,10,12,9,10,5,4,7,10,4,5,6,4,3,9,8,7,5,9,7,8,5,11,6,4,8,6,3,7,6,4,9,6,8,5,7,10,4,7,3,10,11,9,12,5,6,4,10,8,},
new int[] {8,10,7,9,4,12,3,11,5,10,7,12,11,9,3,11,10,7,11,8,6,3,5,11,7,4,11,8,9,5,11,4,12,10,5,12,6,3,7,10,4,5,7,6,11,5,4,7,3,6,7,4,9,12,7,8,11,4,7,9,10,5,7,},
new int[] {12,7,3,6,7,10,12,3,5,11,4,6,12,8,6,3,11,8,5,11,7,5,4,6,8,4,3,10,4,5,11,10,6,7,5,4,9,7,5,3,11,8,10,3,9,5,10,7,9,10,5,6,3,10,7,5,9,11,7,10,9,11,6,},
new int[] {3,12,7,3,6,12,7,4,12,3,7,8,11,3,4,7,9,5,11,7,8,4,10,3,8,11,3,7,8,5,7,10,3,11,12,9,7,4,9,11,10,7,5,8,4,11,9,3,8,5,6,11,12,8,3,10,6,3,10,11,3,8,7,},
			},

				/* 99% */
			new int[][] {
new int[] {11,6,7,11,5,10,9,8,4,10,6,3,7,9,6,5,4,11,12,10,6,5,7,11,12,5,4,7,10,11,7,9,11,7,6,10,8,5,9,4,12,6,11,8,10,7,3,9,10,7,4,6,10,8,4,6,3,4,8,3,6,4,7,},
new int[] {11,3,8,4,5,3,10,6,4,5,11,7,10,3,6,8,4,10,7,12,5,10,11,9,8,4,5,7,11,3,4,7,10,12,6,4,10,6,7,10,12,5,3,11,8,5,3,7,6,4,11,9,8,11,4,5,6,10,7,11,10,8,6,},
new int[] {10,4,12,3,10,9,7,5,10,7,8,10,4,9,6,5,10,6,8,5,12,10,5,6,10,4,7,8,11,5,9,3,5,8,12,7,6,11,3,6,12,10,7,3,9,6,4,12,11,9,5,7,9,6,12,7,5,9,11,7,4,8,7,},
new int[] {6,9,11,10,8,9,6,5,11,8,5,7,12,9,11,7,10,11,7,6,9,4,3,8,5,4,11,7,4,9,11,6,9,12,4,6,3,8,6,12,10,9,11,5,10,4,7,11,3,4,8,11,4,5,11,12,8,3,9,7,8,5,7,},
new int[] {5,9,10,11,4,5,8,4,10,5,6,11,10,6,8,3,6,7,11,6,9,10,12,4,10,12,4,8,9,4,6,9,12,4,5,11,3,8,7,4,10,5,6,8,4,3,11,5,8,9,10,5,8,3,6,11,8,7,12,4,5,10,8,},
			},
		};

		for(int i=5; i<targets.Length && i < reels.Length; i++) {
			DiscreteDifferentialEvolution dde = new DiscreteDifferentialEvolution (reels[i], targets[i], 3);
			dde.optimize ();
			//Console.WriteLine( dde );
			SlotMachineSimulation simulation = new SlotMachineSimulation ();
			simulation.load( dde.best() );
			simulation.simulate( 3 );
			Console.WriteLine("Target RTP:\t" + targets[i]);
			Console.WriteLine ();
			Console.WriteLine (dde);
			Console.WriteLine(simulation);
		}
	}
}
}
