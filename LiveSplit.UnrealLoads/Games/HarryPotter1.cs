﻿using LiveSplit.ComponentUtil;
using System;
using System.Collections.Generic;

namespace LiveSplit.UnrealLoads.Games
{
	class HarryPotter1 : GameSupport
	{
		public override HashSet<string> GameNames => new HashSet<string>
		{
			"Harry Potter 1",
			"Harry Potter and the Philosopher's Stone",
			"HP1",
			"HP 1"
		};

		public override HashSet<string> ProcessNames => new HashSet<string>
		{
			"hp"
		};

		public override HashSet<string> Maps => new HashSet<string>(StringComparer.OrdinalIgnoreCase)
		{
			"Lev_Tut1",
			"Lev_Tut1b",
			"Lev_Tut2",
			"Lev_Tut3",
			"Lev_Tut3b",
			"Lev2_fire1",
			"Lev2_Fire2",
			"Lev2_HogFront",
			"Lev2_HogFront_2",
			"Lev2_HogFront_3",
			"Lev2_Inc_A",
			"Lev2_Inc_B",
			"Lev2_Quid1",
			"Lev2_RemChase",
			"Lev3_Dungeon",
			"Lev3_DungeonB",
			"Lev3_Intro",
			"Lev3_Lumos",
			"Lev3_PreDungeon",
			"Lev3_PreTroll",
			"Lev3_Quid2",
			"Lev3_Troll",
			"Lev4_Sneak",
			"Lev4_Sneak2",
			"Lev5_Chess",
			"Lev5_Final",
			"Lev5_fluffy",
			"Lev5_FlyKeys",
			"Lev5_Snare",
			"Snapes_Office"
		};
	}
}
