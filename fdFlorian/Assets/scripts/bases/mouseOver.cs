using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseOver : MonoBehaviour
{
	[SerializeField] private draw_path draw_;
	private void OnMouseEnter()
	{
        if (!draw_.drawing)
        {
			draw_.canStart = true;
		}
        if (draw_.drawing)
        {
			draw_.canFinish = true;
        }
	}
    private void OnMouseExit()
    {
		if (!draw_.drawing)
		{
			draw_.canStart = false;
		}
		if (draw_.drawing)
		{
			draw_.canFinish = false;
		}
	}
}
