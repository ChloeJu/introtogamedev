using UnityEngine;
using System;

public class round : MonoBehaviour
{
	public Transform m_Transform;
	public float m_Radius = 1; //的半径
	public float m_Theta = 0.1f; //越低越平滑
	public Color m_Color = Color.green; // 框色

	void Start()
	{
		if (m_Transform == null)
		{
			throw new Exception("Transform is NULL.");
		}
	}

	void OnDrawGizmos()
	{
		if (m_Transform == null) return;
		if (m_Theta < 0.0001f) m_Theta = 0.0001f;

		// 置矩
		Matrix4x4 defaultMatrix = Gizmos.matrix;
		Gizmos.matrix = m_Transform.localToWorldMatrix;

		// 置色
		Color defaultColor = Gizmos.color;
		Gizmos.color = m_Color;
	
		// 制
		Vector3 beginPoint = Vector3.zero;
		Vector3 firstPoint = Vector3.zero;
		for (float theta = 0; theta < 2 * Mathf.PI; theta += m_Theta)
		{
			float x = m_Radius * Mathf.Cos(theta);
			float z = m_Radius * Mathf.Sin(theta);
			Vector3 endPoint = new Vector3(x, 0, z);
			if (theta == 0)
			{
				firstPoint = endPoint;
			}
			else
			{
				Gizmos.DrawLine(beginPoint, endPoint);
			}
			beginPoint = endPoint;
		}

		// 制最后一条段
		Gizmos.DrawLine(firstPoint, beginPoint);

		// 恢复默色
		Gizmos.color = defaultColor;

		// 恢复默矩
		Gizmos.matrix = defaultMatrix;
	}
}