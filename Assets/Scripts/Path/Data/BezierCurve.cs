﻿using UnityEngine;
using System.Collections;

public class BezierCurve : MonoBehaviour {
	
	public Vector3[] points;

	void Reset(){
		points = new Vector3[] {
			new Vector3 (1, 0, 0),
			new Vector3 (2, 0, 0),
			new Vector3 (3, 0, 0),
			new Vector3 (3, 0, 0)
		};
	}

	public Vector3 GetPoint(float t){
		return transform.TransformPoint (Bezier.GetPoint (t, points[0], points[1], points[2], points[3]));
	}

	public Vector3 GetVelocity(float t){
		return transform.TransformPoint (Bezier.GetDerivative (t, points[0], points[1], points[2], points[3]) - transform.position);
	}
}
