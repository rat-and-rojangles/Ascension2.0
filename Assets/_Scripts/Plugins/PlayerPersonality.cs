using UnityEngine;
using System.Collections;

public class PlayerPersonality : ScriptableObject {

	//public static Color playerColor = Color.HSVToRGB(2f/6f,1.0f,0.5f);
	public static Color playerColor = Color.black;

	public static Color playerEnergyColor {	//inverts hue, brightens
		get{ 
			// 0 hue can be red, black, or white
			if (HSVColor.FromColor (playerColor).h == 0) {
				if (HSVColor.FromColor (playerColor).v == 0) {	//black
					//return Color.red;
					return Color.white;
				} else if (HSVColor.FromColor (playerColor).s == 0) {	//white
					return Color.blue;
				} else{
					return Color.cyan;
				}
			} else {
				return HSVColor.ToColor (new HSVColor (1 - HSVColor.FromColor (playerColor).h, 1.0f, 1.0f));
			}
		}
	}


}
