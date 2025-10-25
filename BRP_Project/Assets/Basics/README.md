# Basics

这个文件夹包含了Unity基础教程的内容，主要涉及数学函数可视化和GPU计算。

## 主要内容

### Math (数学)
- **Graph.cs**: 实现了数学函数的三维可视化，支持多种数学函数（正弦、余弦等）
- **FunctionLibrary.cs/compute**: 函数库，包含各种数学函数的实现
- **GPUGraph.cs**: 使用GPU加速的图形渲染
- **FrameRateCounter.cs**: 帧率计数器，用于性能监控

### Jobs (作业系统)
- Unity Jobs系统的示例和实践

## 功能特点

- 支持实时切换不同的数学函数
- 使用GPU计算提升性能
- 帧率显示和性能监控
- 点云可视化渲染

## 相关资源

- Unity场景: `Basics.unity`
- 着色器: `Point.shader`, `Point GPU.shader`
- 材质: `BRP_Mat.mat`
