using UnityEngine;

public class ShaderPosition2Binder : MonoBehaviour
{
    public Transform m_Target1;
    public Transform m_Target2;

    private Vector4 m_Value1;
    private Vector4 m_Value2;
    
    private static readonly int Position1 = Shader.PropertyToID("_Position1");
    private static readonly int Position2 = Shader.PropertyToID("_Position2");
    // private static readonly int Radius = Shader.PropertyToID("_Radius");
    
    private Renderer m_Renderer;

    void Start()
    {
        m_Renderer = gameObject.GetComponent<Renderer>();
    }

    void Update()
    {
        var position1 = m_Target1.position;
        var position2 = m_Target2.position;
        m_Value1.Set(position1.x, position1.y, position1.z, 1);
        m_Value2.Set(position2.x, position2.y, position2.z, 1);
        m_Renderer.material.SetVector(Position1, m_Value1);
        m_Renderer.material.SetVector(Position2, m_Value2);
    }
}