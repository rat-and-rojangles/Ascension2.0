using UnityEngine;
using System.Collections;

public class Useful : ScriptableObject {

	// up to 4 decimal places
	//public static bool ColorsAlmostEqual(){
		
	//}

	public static bool approximatelyEqual(float val1, float val2, float deviation){
		return ((val1 > val2 - deviation) && (val1 < val2 + deviation));
	}
	//public static bool approximatelyEqual(int val1, int val2){	}

}
