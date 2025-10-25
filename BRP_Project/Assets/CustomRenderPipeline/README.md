# Custom Render Pipeline (自定义渲染管线)

这个文件夹包含了自定义渲染管线（Custom Render Pipeline）的实现，展示如何创建自己的渲染管线以替代Unity的内置渲染管线。

## 主要内容

### Runtime (运行时)
- **CustomRenderPipeline.cs**: 自定义渲染管线的主类
- **CustomRenderPipelineAsset.cs**: 渲染管线资源配置
- **CameraRenderer.cs**: 相机渲染器实现
- **CameraRenderer.Editor.cs**: 编辑器相关的渲染功能

### ShaderLibrary (着色器库)
- 共享的着色器代码和函数库

### Shaders (着色器)
- 自定义渲染管线使用的着色器文件

### Examples (示例)
- 渲染管线的使用示例

## 功能特点

- 完全自定义的渲染流程控制
- 支持动态批处理（Dynamic Batching）
- 支持GPU实例化（GPU Instancing）
- 支持SRP批处理器（SRP Batcher）
- 可自定义的相机渲染逻辑

## 相关资源

- 渲染管线资源: `CustomRP.asset`
- 场景: `Scene/`
- 材质: `Materials/`
- 纹理: `Textures/`
