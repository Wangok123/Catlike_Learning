# Creating a Mesh (网格创建)

这个文件夹包含了程序化网格生成的教程内容，展示如何使用代码动态创建各种类型的3D网格。

## 主要内容

### 脚本 (Scripts)
- **ProceduralMesh.cs**: 主要的程序化网格组件
- **AdvancedSingleStreamProceduralMesh.cs**: 单流高级网格生成
- **AdvancedMultiStreamProceduralMesh.cs**: 多流高级网格生成

### 网格生成器 (Generators)
- **SquareGrid**: 方形网格生成器
- **SharedSquareGrid**: 共享顶点的方形网格
- **SharedTriangleGrid**: 共享顶点的三角形网格
- **PointyHexagonGrid**: 尖顶六边形网格
- **FlatHexagonGrid**: 平顶六边形网格
- **UVSphere**: UV球体生成器

### 流处理 (Streams)
- **SingleStream**: 单流顶点数据处理
- **MultiStream**: 多流顶点数据处理
- **TriangleUInt16**: 三角形索引处理

## 功能特点

- 支持多种几何形状的程序化生成
- 优化的顶点数据流处理
- 使用Unity Jobs系统提升性能
- 支持顶点、法线、切线的可视化调试

## 相关资源

- Unity场景: `Creating a Mesh.unity`
- 材质: `Materials/`
- 着色器: `Shaders/`
- 纹理: `base-map.png`
