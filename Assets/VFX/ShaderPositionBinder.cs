using UnityEngine;

public class ShaderPositionBinder : MonoBehaviour
{
    public Transform m_Target;

    private Renderer m_Renderer;
    private Vector4 m_Value;
    private static readonly int Position = Shader.PropertyToID("_Position");
    // private static readonly int Radius = Shader.PropertyToID("_Radius");

    void Start()
    {
        m_Renderer = gameObject.GetComponent<Renderer>();
    }

    void Update()
    {
        var position = m_Target.position;
        m_Value.Set(position.x, position.y, position.z, 1);
        m_Renderer.material.SetVector(Position, m_Value);
        // m_Renderer.material.SetFloat(Radius, m_Target.localScale.x);
    }
}