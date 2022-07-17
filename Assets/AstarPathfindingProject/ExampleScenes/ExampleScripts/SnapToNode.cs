using UnityEngine;
using System.Collections;
using Pathfinding;

/// <summary>
/// Helper editor script to snap an object to the closest node.
/// Used in the "Turn Based" example scene for snapping obstacles to the hexagon grid.
/// </summary>
[ExecuteInEditMode]
[HelpURL("http://arongranberg.com/astar/docs/class_snap_to_node.php")]
public class SnapToNode : MonoBehaviour {
	void Update () {
		if (transform.hasChanged && AstarPath.active != null) {
			var node = AstarPath.active.GetNearest(transform.position, NNConstraint.None).node;
			if (node != null) {
				transform.position = (Vector3)node.position;
				//transform.position = new Vector3(node.position.x + 0.56f, node.position.y + 0.068f, node.position.z);
				transform.hasChanged = false;
			}
		}
	}
}
