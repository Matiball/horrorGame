using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudTrapEscape : MonoBehaviour 
{
	private BearTrap bearTrap;
	private float sekundyNaUvolnenie;

	private float progress = 3; // v sekundach
	private bool isUnlocking = false;

	public GameObject panel;
	public GameObject pcHint;
	public Image progressbar;

	public void FixedUpdate()
	{
		if (isUnlocking) // ak hrac drzi button na vyslobodenie
		{
			progress -= Time.deltaTime;
			progressbar.fillAmount = progress/ sekundyNaUvolnenie;

			if (progress < 0)
			{
				isUnlocking = false;
				progress = sekundyNaUvolnenie;
				UnlockPlayer();
			}
		}
		else // ak nedrzi hrac tlacidlo, tak zobrazovat progressBar naplno
		{
			progress = sekundyNaUvolnenie;
			progressbar.fillAmount = 1;
		}
	}

	public void Update()
	{
		if(Input.GetKey(KeyCode.E) && !PlayerInventory.instance.player.isDead)
		{
			isUnlocking = true;
		}
		else
		{
			isUnlocking = false;
		}
	}

	public void UnlockPlayer()
	{
		if(bearTrap != null)
		{
			bearTrap.MakePlayerFree();
			bearTrap = null;
			HideHud();
		}
	}

	public void ShowHud(BearTrap trap)
	{
		if (Application.platform == RuntimePlatform.Android)
			pcHint.SetActive(false);
		else
			pcHint.SetActive(true);

		panel.SetActive(true);
		bearTrap = trap;
		sekundyNaUvolnenie = trap.sekundyNaUvolnenie;
	}

	public void HideHud()
	{
		pcHint.SetActive(false);
		panel.SetActive(false);		
	}

	public void ButtonPressed()
	{
		isUnlocking = true;
	}

	public void ButtonUp()
	{
		isUnlocking = false;
	}
}
