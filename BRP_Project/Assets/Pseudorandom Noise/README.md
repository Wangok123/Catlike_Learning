# Pseudorandom Noise (伪随机噪声)

这个文件夹包含了伪随机噪声生成和可视化的内容，展示如何使用哈希函数和噪声算法创建程序化内容。

## 主要内容

### 脚本 (Scripts)
- **HashVisualization.cs**: 哈希函数的可视化
  - 使用Unity Jobs系统进行并行计算
  - 使用Burst编译器优化性能
  - 通过ComputeBuffer将数据传递给GPU
  - 支持实时调整分辨率

## 功能特点

- 高性能的哈希计算
- GPU加速的实例化渲染
- 可视化噪声模式
- 使用Unity的原生数组（NativeArray）优化内存
- Burst编译器优化的Job系统

## 应用场景

- 程序化内容生成
- 纹理生成
- 地形生成的基础
- 随机分布的可视化

## 相关资源

- 材质: `Materials/`
- 着色器和计算着色器
