using UnityEngine;
using System.Collections;

public class PanelClass : MonoBehaviour {

    static PanelClass instanciaPanel;

    public void ActivarPanel()
    {
        this.gameObject.SetActive(true);
    }

    public void DesactivarPanel()
    {
        this.gameObject.SetActive(false);
    }

    /// <summary>
    /// Patrón Singleton que garantinza que solo exista
    /// una única instancia de la clase PanelControllerClass
    /// 
    /// </summary>
    public static PanelClass InstanciaPanel
    {
        get { return instanciaPanel; }
    }

    void Awake()
    {
        if (instanciaPanel == null)
        {
            instanciaPanel = this;
        }
        else
        {
            Destroy(this);//garantiza que solo haya una instancia de esta clase (no se crean más instancias de ella)
        }
    }

    // Use this for initialization
    void Start()
    {
        this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
