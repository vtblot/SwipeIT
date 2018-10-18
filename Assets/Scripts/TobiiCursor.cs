using UnityEngine;
using Tobii.Gaming;

public class TobiiCursor : MonoBehaviour{

	private Vector2 filteredPoint;
	public Vector2 GetCursorPosition()
	{
		// TODO: peut être ajouté un bool pour être en mode souris même si un Tobii Eye est connecté.
		if (TobiiAPI.IsConnected)
		{
			var gazePoint = TobiiAPI.GetGazePoint();
			if (gazePoint.IsValid)
			{
				filteredPoint = Vector2.Lerp(filteredPoint, gazePoint.Screen, 0.5f);
				return filteredPoint;
			}
		}
		// TODO: savoir si on smooth même la position de la souris.
		filteredPoint = Vector2.Lerp(filteredPoint, Input.mousePosition, 0.5f);
		
		return filteredPoint;
	}
}
