namespace Kovah
{
	[HavokClass(EVersion.Havok_7_1_0_r1)]
	[HavokClass(EVersion.hk_2012_1_0_r1)]
	[HavokClass(EVersion.hk_2014_1_0_r1)]
	public partial class hkColor
	{
		public enum ExtendedColors
		{
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -8388608)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -8388608)]
			MAROON,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -7667712)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -7667712)]
			DARKRED,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -65536)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -65536)]
			RED,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -18751)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -18751)]
			LIGHTPINK,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -2354116)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -2354116)]
			CRIMSON,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -2396013)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -2396013)]
			PALEVIOLETRED,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -38476)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -38476)]
			HOTPINK,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -60269)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -60269)]
			DEEPPINK,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -3730043)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -3730043)]
			MEDIUMVIOLETRED,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -8388480)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -8388480)]
			PURPLE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -7667573)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -7667573)]
			DARKMAGENTA,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -2461482)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -2461482)]
			ORCHID,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -2572328)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -2572328)]
			THISTLE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -2252579)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -2252579)]
			PLUM,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -1146130)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -1146130)]
			VIOLET,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -65281)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -65281)]
			FUCHSIA,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -65281)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -65281)]
			MAGENTA,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -4565549)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -4565549)]
			MEDIUMORCHID,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -7077677)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -7077677)]
			DARKVIOLET,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -6737204)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -6737204)]
			DARKORCHID,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -7722014)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -7722014)]
			BLUEVIOLET,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -11861886)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -11861886)]
			INDIGO,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -7114533)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -7114533)]
			MEDIUMPURPLE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -9807155)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -9807155)]
			SLATEBLUE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -8689426)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -8689426)]
			MEDIUMSLATEBLUE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -16777077)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -16777077)]
			DARKBLUE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -16777011)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -16777011)]
			MEDIUMBLUE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -16776961)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -16776961)]
			BLUE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -16777088)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -16777088)]
			NAVY,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -15132304)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -15132304)]
			MIDNIGHTBLUE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -12042869)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -12042869)]
			DARKSLATEBLUE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -12490271)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -12490271)]
			ROYALBLUE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -10185235)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -10185235)]
			CORNFLOWERBLUE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -5192482)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -5192482)]
			LIGHTSTEELBLUE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -984833)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -984833)]
			ALICEBLUE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -460545)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -460545)]
			GHOSTWHITE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -1644806)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -1644806)]
			LAVENDER,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -14774017)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -14774017)]
			DODGERBLUE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -12156236)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -12156236)]
			STEELBLUE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -16728065)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -16728065)]
			DEEPSKYBLUE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -9404272)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -9404272)]
			SLATEGRAY,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -8943463)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -8943463)]
			LIGHTSLATEGRAY,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -7876870)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -7876870)]
			LIGHTSKYBLUE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -7876885)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -7876885)]
			SKYBLUE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -5383962)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -5383962)]
			LIGHTBLUE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -16744320)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -16744320)]
			TEAL,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -16741493)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -16741493)]
			DARKCYAN,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -16724271)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -16724271)]
			DARKTURQUOISE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -16711681)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -16711681)]
			CYAN,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -12004916)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -12004916)]
			MEDIUMTURQUOISE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -10510688)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -10510688)]
			CADETBLUE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -5247250)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -5247250)]
			PALETURQUOISE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -2031617)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -2031617)]
			LIGHTCYAN,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -983041)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -983041)]
			AZURE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -14634326)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -14634326)]
			LIGHTSEAGREEN,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -12525360)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -12525360)]
			TURQUOISE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -5185306)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -5185306)]
			POWDERBLUE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -13676721)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -13676721)]
			DARKSLATEGRAY,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -8388652)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -8388652)]
			AQUAMARINE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -16713062)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -16713062)]
			MEDIUMSPRINGGREEN,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -10039894)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -10039894)]
			MEDIUMAQUAMARINE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -16711809)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -16711809)]
			SPRINGGREEN,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -12799119)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -12799119)]
			MEDIUMSEAGREEN,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -13726889)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -13726889)]
			SEAGREEN,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -13447886)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -13447886)]
			LIMEGREEN,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -16751616)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -16751616)]
			DARKGREEN,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -16744448)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -16744448)]
			GREEN,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -16711936)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -16711936)]
			LIME,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -14513374)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -14513374)]
			FORESTGREEN,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -7357297)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -7357297)]
			DARKSEAGREEN,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -7278960)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -7278960)]
			LIGHTGREEN,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -6751336)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -6751336)]
			PALEGREEN,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -655366)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -655366)]
			MINTCREAM,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -983056)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -983056)]
			HONEYDEW,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -8388864)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -8388864)]
			CHARTREUSE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -8586240)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -8586240)]
			LAWNGREEN,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -9728477)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -9728477)]
			OLIVEDRAB,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -11179217)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -11179217)]
			DARKOLIVEGREEN,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -6632142)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -6632142)]
			YELLOWGREEN,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -5374161)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -5374161)]
			GREENYELLOW,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -657956)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -657956)]
			BEIGE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -331546)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -331546)]
			LINEN,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -329006)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -329006)]
			LIGHTGOLDENRODYELLOW,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -8355840)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -8355840)]
			OLIVE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -256)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -256)]
			YELLOW,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -32)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -32)]
			LIGHTYELLOW,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -16)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -16)]
			IVORY,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -4343957)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -4343957)]
			DARKKHAKI,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -989556)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -989556)]
			KHAKI,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -1120086)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -1120086)]
			PALEGOLDENROD,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -663885)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -663885)]
			WHEAT,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -10496)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -10496)]
			GOLD,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -1331)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -1331)]
			LEMONCHIFFON,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -4139)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -4139)]
			PAPAYAWHIP,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -4684277)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -4684277)]
			DARKGOLDENROD,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -2448096)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -2448096)]
			GOLDENROD,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -332841)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -332841)]
			ANTIQUEWHITE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -1828)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -1828)]
			CORNSILK,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -133658)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -133658)]
			OLDLACE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -6987)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -6987)]
			MOCCASIN,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -8531)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -8531)]
			NAVAJOWHITE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -23296)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -23296)]
			ORANGE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -6972)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -6972)]
			BISQUE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -2968436)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -2968436)]
			TAN,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -29696)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -29696)]
			DARKORANGE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -2180985)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -2180985)]
			BURLYWOOD,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -7650029)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -7650029)]
			SADDLEBROWN,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -744352)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -744352)]
			SANDYBROWN,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -5171)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -5171)]
			BLANCHEDALMOND,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -3851)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -3851)]
			LAVENDERBLUSH,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -2578)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -2578)]
			SEASHELL,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -1296)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -1296)]
			FLORALWHITE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -1286)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -1286)]
			SNOW,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -3308225)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -3308225)]
			PERU,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -9543)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -9543)]
			PEACHPUFF,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -2987746)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -2987746)]
			CHOCOLATE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -6270419)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -6270419)]
			SIENNA,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -24454)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -24454)]
			LIGHTSALMON,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -32944)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -32944)]
			CORAL,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -1468806)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -1468806)]
			DARKSALMON,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -6943)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -6943)]
			MISTYROSE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -47872)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -47872)]
			ORANGERED,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -360334)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -360334)]
			SALMON,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -40121)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -40121)]
			TOMATO,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -4419697)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -4419697)]
			ROSYBROWN,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -16181)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -16181)]
			PINK,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -3318692)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -3318692)]
			INDIANRED,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -1015680)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -1015680)]
			LIGHTCORAL,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -5952982)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -5952982)]
			BROWN,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -5103070)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -5103070)]
			FIREBRICK,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -16777216)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -16777216)]
			BLACK,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -9868951)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -9868951)]
			DIMGRAY,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -8355712)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -8355712)]
			GRAY,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -5658199)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -5658199)]
			DARKGRAY,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -4144960)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -4144960)]
			SILVER,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -2894893)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -2894893)]
			LIGHTGREY,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -2302756)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -2302756)]
			GAINSBORO,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -657931)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -657931)]
			WHITESMOKE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -1)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -1)]
			WHITE,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -7829368)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -7829368)]
			GREY,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -12566464)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -12566464)]
			GREY25,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -8355712)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -8355712)]
			GREY50,
			[HavokEnumItem(EVersion.Havok_7_1_0_r1, -4144960)]
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -4144960)]
			GREY75,
			
		}
		public enum ProductColors
		{
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -19712)]
			PHYSICS,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -2424800)]
			DESTRUCTION,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -16604629)]
			ANIMATION,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -13406024)]
			BEHAVIOR,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -5071652)]
			CLOTH,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -5452048)]
			AI,
			[HavokEnumItem(EVersion.hk_2012_1_0_r1, -4213200)]
			SCRIPT,
			
		}
	}
}
