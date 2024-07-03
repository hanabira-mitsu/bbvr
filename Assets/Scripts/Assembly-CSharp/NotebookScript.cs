using System;
//using Rewired;
using UnityEngine;

// Token: 0x020000C3 RID: 195
public class NotebookScript : MonoBehaviour
{
	// Token: 0x0600098F RID: 2447 RVA: 0x00023FFB File Offset: 0x000223FB
	private void Start()
	{
		//this.playerInput = ReInput.players.GetPlayer(0);
		this.up = true;

		if (learningGameJR == gameObject)
		{
			learningGameJR = learningGame;
		}
	}

	// Token: 0x06000990 RID: 2448 RVA: 0x00024018 File Offset: 0x00022418
	private void Update()
	{
		if (this.gc.mode == "endless")
		{
			if (this.respawnTime > 0f)
			{
				if ((base.transform.position - this.player.position).magnitude > 60f)
				{
					this.respawnTime -= Time.deltaTime;
				}
			}
			else if (!this.up)
			{
				base.transform.position = new Vector3(base.transform.position.x, 4f, base.transform.position.z);
				this.up = true;
				this.audioDevice.Play();
			}
		}
		if (Input.GetButtonDown("XRI_Right_PrimaryButton") && Time.timeScale != 0f)
		{
			Ray ray = Camera.main.ViewportPointToRay(new Vector2(0.5f, 0.5f));
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit) && (raycastHit.transform.tag == "Notebook" & Vector3.Distance(this.player.position, base.transform.position) < this.openingDistance))
			{
				base.transform.position = new Vector3(base.transform.position.x, -20f, base.transform.position.z);
				this.up = false;
				this.respawnTime = 120f;
				this.gc.CollectNotebook();
				if ((PlayerPrefs.GetInt("ImmersiveNotebook") == 1) && learningGameJR!=null)
				{
					SummonGameJR();
                }
				else
				{
					SummonGame();
				}
				

            }
		}
	}

	private void SummonGame()
	{
        GameObject MathUI = UnityEngine.Object.Instantiate<GameObject>(this.learningGame);
        MathUI.GetComponent<MathGameScript>().gc = this.gc;
        MathUI.GetComponent<MathGameScript>().baldiScript = this.bsc;
        MathUI.GetComponent<MathGameScript>().playerPosition = this.player.position;
        playerCam = mainCamera.GetComponent<Camera>();
        MathUI.GetComponent<Canvas>().worldCamera = playerCam;
        MathUI.transform.position = new Vector3(base.transform.position.x, 5.5f, base.transform.position.z);
        MathUI.transform.rotation = new Quaternion(this.player.transform.rotation.x, this.player.transform.rotation.y, this.player.transform.rotation.z, this.player.transform.rotation.w);
    }

    private void SummonGameJR()
    {
		//Summon the Smaller verion of the game
        GameObject MathUI = UnityEngine.Object.Instantiate<GameObject>(this.learningGameJR);
        MathUI.GetComponent<MathGameScript>().gc = this.gc;
        MathUI.GetComponent<MathGameScript>().baldiScript = this.bsc;
        MathUI.GetComponent<MathGameScript>().playerPosition = this.player.position;
        playerCam = mainCamera.GetComponent<Camera>();
        MathUI.GetComponent<Canvas>().worldCamera = playerCam;

		//Parent it to the You Can Think JR
		GameObject UIAnchor = GameObject.Find("MathGameJRAnchor");
		MathUI.transform.SetParent(UIAnchor.transform);
        MathUI.transform.localPosition = new Vector3(0,0,0);
        MathUI.transform.localEulerAngles = new Vector3(0,0,0);
		MathUI.transform.localScale = new Vector3(1,1,1);

        //Hide the Hud
        GameObject Hud = GameObject.Find("Hud");
		Hud.SetActive(false);
    }

    public GameObject mainCamera;

	public Camera playerCam;

	// Token: 0x0400066A RID: 1642
	public float openingDistance;

	// Token: 0x0400066B RID: 1643
	public GameControllerScript gc;

	// Token: 0x0400066C RID: 1644
	public BaldiScript bsc;

	// Token: 0x0400066D RID: 1645
	public float respawnTime;

	// Token: 0x0400066E RID: 1646
	public bool up;

	// Token: 0x0400066F RID: 1647
	public Transform player;

	// Token: 0x04000670 RID: 1648
	public GameObject learningGame;

    public GameObject learningGameJR;

    // Token: 0x04000671 RID: 1649
    public AudioSource audioDevice;

	// Token: 0x04000672 RID: 1650
	//private Player playerInput;
}
