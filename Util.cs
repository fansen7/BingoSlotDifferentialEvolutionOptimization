﻿
using System;

namespace BingoSlotDifferentialEvolutionOptimization {
class Util {
	/**
	 * Select random initial solutions.
	 */
	public const bool RANDOM_INITIAL_REELS = true;

	/**
	 * Enforce symbols diversity.
	 */
	public const bool STRICT_SYMBOLS_DIVERSITY = false;

	/**
	 * Report in steps.
	 */
	public const bool REEVALUATE_TARGET_VECTOR = true;

	/**
	 * Report in steps.
	 */
	public const bool VERBOSE = false;

	/**
	* Pseudo-random number generator.
	*/
	public static Random prng = new Random ();
}
}

