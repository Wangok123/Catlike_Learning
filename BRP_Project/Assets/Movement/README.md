# Movement (移动系统)

这个文件夹包含了角色移动和相机控制系统的实现，展示如何创建流畅的3D角色控制器和轨道相机。

## 主要内容

### 脚本 (Scripts)

#### 角色移动
- **MovingSphere.cs**: 主要的角色移动控制器
  - 支持地面移动和空中移动
  - 跳跃系统（包括多段跳）
  - 斜坡和楼梯检测
  - 速度和加速度控制

#### 相机控制
- **OrbitCamera.cs**: 轨道相机系统
  - 围绕目标旋转
  - 平滑的相机跟随
  - 可配置的距离和角度

#### 自定义重力系统
- **CustomGravity.cs**: 自定义重力管理器
- **CustomGravityRigidbody.cs**: 支持自定义重力的刚体
- **GravitySource.cs**: 重力源组件
- **GravityPlane.cs**: 重力平面组件

## 功能特点

- 基于物理的角色控制器
- 平滑的移动和跳跃
- 地面检测和吸附
- 支持不同的重力方向
- 灵活的相机控制系统

## 相关资源

- Unity场景: `Movement.unity`, `CameraOrbit.unity`
- 材质: `Materials/`
