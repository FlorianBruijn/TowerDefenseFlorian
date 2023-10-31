using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseOver : MonoBehaviour
{
	[SerializeField] private draw_path draw_;
	private void OnMouseEnter()
	{
        if (!draw_.drawing && draw_.starttag == tag)
        {
			draw_.canStart = true;
			draw_.starttag = tag;
		}
        if (draw_.drawing && draw_.starttag != tag)
        {
			draw_.drawing = false;
			draw_.Stop = true;
        }
	}
    private void OnMouseExit()
    {
		if (!draw_.drawing && draw_.starttag == tag)
		{
			draw_.canStart = false;
		}
	}
}
