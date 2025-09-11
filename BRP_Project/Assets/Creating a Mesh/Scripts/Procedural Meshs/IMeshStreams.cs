using Unity.Mathematics;
using UnityEngine;

namespace ProceduralMeshes
{
    public interface IMeshStreams
    {
        /// <summary>
        /// 初始化网格数据
        /// </summary>
        /// <param name="meshData"></param>
        /// <param name="bounds"></param>
        /// <param name="vertexCount"></param>
        /// <param name="indexCount"></param>
        void Setup(
            Mesh.MeshData meshData, Bounds bounds, int vertexCount, int indexCount
        );

        /// <summary>
        /// 负责将顶点复制到网格的顶点缓冲区
        /// </summary>
        /// <param name="index"></param>
        /// <param name="vertex"></param>
        void SetVertex(int index, Vertex vertex);

        /// <summary>
        /// 我们也必须对索引缓冲区执行此作。由于使用三角形而不是单个索引更方便，因此我们将定义一个 SetTriangle 方法，其中三角形索引和 int3 顶点索引三元组作为参数。
        /// </summary>
        /// <param name="index"></param>
        /// <param name="triangle"></param>
        void SetTriangle(int index, int3 triangle);
    }
}