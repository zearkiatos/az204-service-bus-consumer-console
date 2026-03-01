# Description
This is a CSharp (C#) 🟪 to integrate service bus queue 🧩 → 🚌📥 → 🧩 and consume the queue. This is in order to study and practice for az204 certification exam 🤓📚🎓

# Made With
[![C#](https://img.shields.io/badge/c%23-8c39ac?style=for-the-badge&logo=data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iVVRGLTgiPz4KPHN2ZyBpZD0iTGF5ZXJfMSIgZGF0YS1uYW1lPSJMYXllciAxIiB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHZlcnNpb249IjEuMSIgdmlld0JveD0iMCAwIDIyMjIgMjUwMCI+CiAgPGRlZnM+CiAgICA8c3R5bGU+CiAgICAgIC5jbHMtMSB7CiAgICAgICAgZmlsbDogIzMzMzsKICAgICAgfQoKICAgICAgLmNscy0xLCAuY2xzLTIsIC5jbHMtMywgLmNscy00IHsKICAgICAgICBzdHJva2Utd2lkdGg6IDBweDsKICAgICAgfQoKICAgICAgLmNscy0yIHsKICAgICAgICBmaWxsOiAjNjY2OwogICAgICB9CgogICAgICAuY2xzLTMgewogICAgICAgIGZpbGw6ICMwMDA7CiAgICAgIH0KCiAgICAgIC5jbHMtNCB7CiAgICAgICAgZmlsbDogI2ZmZjsKICAgICAgfQogICAgPC9zdHlsZT4KICA8L2RlZnM+CiAgPHBhdGggY2xhc3M9ImNscy0yIiBkPSJNMjIxMi4xLDc0MC4xYzAtNDEuNi04LjktNzguNC0yNi45LTExMC0xNy43LTMxLTQ0LjItNTcuMS03OS43LTc3LjYtMjkzLjItMTY5LjEtNTg2LjctMzM3LjYtODc5LjgtNTA2LjktNzktNDUuNi0xNTUuNi00My45LTIzNC4xLDIuMy0xMTYuNyw2OC44LTcwMSw0MDMuNi04NzUuMSw1MDQuNC03MS43LDQxLjUtMTA2LjYsMTA1LTEwNi42LDE4Ny42LS4xLDM0MCwwLDY4MC0uMSwxMDIwLDAsNDAuNyw4LjUsNzYuOCwyNS43LDEwNy45LDE3LjcsMzIsNDQuNSw1OC43LDgwLjksNzkuNywxNzQuMSwxMDAuOSw3NTguNSw0MzUuNiw4NzUuMiw1MDQuNCw3OC41LDQ2LjMsMTU1LjEsNDgsMjM0LjEsMi4zLDI5My4xLTE2OS4yLDU4Ni42LTMzNy44LDg3OS45LTUwNi45LDM2LjMtMjEsNjMuMi00Ny44LDgwLjktNzkuNywxNy4yLTMxLjEsMjUuNy02Ny4yLDI1LjctMTA3LjksMCwwLDAtNjc5LjgtLjEtMTAxOS44Ii8+CiAgPHBhdGggY2xhc3M9ImNscy0zIiBkPSJNMTExNC40LDEyNDYuN0wzNS41LDE4NjcuOWMxNy43LDMyLDQ0LjUsNTguNyw4MC45LDc5LjcsMTc0LjEsMTAwLjksNzU4LjUsNDM1LjYsODc1LjIsNTA0LjQsNzguNSw0Ni4zLDE1NS4xLDQ4LDIzNC4xLDIuMywyOTMuMS0xNjkuMiw1ODYuNi0zMzcuOCw4NzkuOS01MDYuOSwzNi4zLTIxLDYzLjItNDcuOCw4MC45LTc5LjdsLTEwNzIuMS02MjEuMWgwWiIvPgogIDxwYXRoIGNsYXNzPSJjbHMtMSIgZD0iTTIyMTIuMSw3NDAuMWMwLTQxLjYtOC45LTc4LjQtMjYuOS0xMTBsLTEwNzAuOCw2MTYuNiwxMDcyLjEsNjIxLjFjMTcuMi0zMS4xLDI1LjctNjcuMiwyNS43LTEwNy45LDAsMCwwLTY3OS44LS4xLTEwMTkuOCIvPgogIDxnPgogICAgPHBhdGggY2xhc3M9ImNscy00IiBkPSJNMTc0OS42LDEwMTQuNXYxMTYuMWgxMTYuMXYtMTE2LjFoNTguMXYxMTYuMWgxMTYuMXY1OC4xaC0xMTYuMXYxMTYuMWgxMTYuMXY1OC4xaC0xMTYuMXYxMTYuMWgtNTguMXYtMTE2LjFoLTExNi4xdjExNi4xaC01OC4xdi0xMTYuMWgtMTE2LjF2LTU4LjFoMTE2LjF2LTExNi4xaC0xMTYuMXYtNTguMWgxMTYuMXYtMTE2LjFoNTguMVpNMTg2NS43LDExODguNmgtMTE2LjF2MTE2LjFoMTE2LjF2LTExNi4xWiIvPgogICAgPHBhdGggY2xhc3M9ImNscy00IiBkPSJNMTExNi43LDQzMS4zYzMwMi45LDAsNTY3LjMsMTY0LjUsNzA4LjksNDA5bC0xLjQtMi40LTM1Ni4zLDIwNS4yYy03MC4yLTExOC45LTE5OC45LTE5OS4xLTM0Ni41LTIwMC43aC00LjdjLTIyNS4xLDAtNDA3LjYsMTgyLjUtNDA3LjYsNDA3LjZzMTguNSwxNDAuNyw1My44LDIwMi4zYzcwLjMsMTIyLjcsMjAyLjQsMjA1LjQsMzUzLjksMjA1LjRzMjg1LjMtODMuOCwzNTUuMi0yMDcuOGwtMS43LDMsMzU1LjgsMjA2LjFjLTE0MC4xLDI0Mi40LTQwMC45LDQwNi40LTcwMC4yLDQwOS42aC05LjFjLTMwMy44LDAtNTY5LTE2NS40LTcxMC4yLTQxMS4yLTY5LTEyMC0xMDguNC0yNTkuMS0xMDguNC00MDcuNCwwLTQ1Mi4xLDM2Ni41LTgxOC43LDgxOC43LTgxOC43aC0uMloiLz4KICA8L2c+Cjwvc3ZnPg==&logoColor=white&labelColor=000000)]()
[![NetCore & Net Framework](https://img.shields.io/badge/netcore%20&%20NET%20Framework-4f3ac9?style=for-the-badge&logo=dotnet&logoColor=white&labelColor=000000)]()
[![Azure](https://img.shields.io/badge/Azure-2b83cb?style=for-the-badge&logo=data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iVVRGLTgiPz4KPHN2ZyBpZD0iTGF5ZXJfMSIgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB2ZXJzaW9uPSIxLjEiIHZpZXdCb3g9IjAgMCA4MDAgODAwIj4KICA8IS0tIEdlbmVyYXRvcjogQWRvYmUgSWxsdXN0cmF0b3IgMjkuNS4xLCBTVkcgRXhwb3J0IFBsdWctSW4gLiBTVkcgVmVyc2lvbjogMi4xLjAgQnVpbGQgMTQxKSAgLS0+CiAgPGRlZnM+CiAgICA8c3R5bGU+CiAgICAgIC5zdDAgewogICAgICAgIGZpbGw6ICNmZmY7CiAgICAgIH0KICAgIDwvc3R5bGU+CiAgPC9kZWZzPgogIDxwYXRoIGNsYXNzPSJzdDAiIGQ9Ik0zNzAuMSw2NzUuNmMxMDIuOC0xOC4yLDE4Ny43LTMzLjIsMTg4LjYtMzMuNGwxLjgtLjQtOTctMTE1LjRjLTUzLjQtNjMuNS05Ny0xMTUuNy05Ny0xMTYsMC0uNiwxMDAuMi0yNzYuNSwxMDAuOC0yNzcuNS4yLS4zLDY4LjQsMTE3LjQsMTY1LjMsMjg1LjQsOTAuNywxNTcuMywxNjUuNSwyODYuOSwxNjYuMiwyODguMWwxLjMsMi4yaC0zMDguNHMtMzA4LjQsMC0zMDguNCwwbDE4Ni45LTMzaDBaTTAsNjQwLjRjMC0uMiw0NS43LTc5LjUsMTAxLjYtMTc2LjRsMTAxLjYtMTc2LjEsMTE4LjQtOTkuNGM2NS4xLTU0LjcsMTE4LjYtOTkuNCwxMTguOC05OS41LjIsMC0uNiwyLjEtMS45LDQuOC0xLjMsMi43LTU5LjEsMTI2LjgtMTI4LjYsMjc1LjhsLTEyNi4zLDI3MC44aC05MS44QzQxLjMsNjQwLjcsMCw2NDAuNiwwLDY0MC40SDBaIi8+Cjwvc3ZnPg==&logoColor=white&labelColor=000000)]()

# Documentation

## Overview

This console application demonstrates a complete Azure Service Bus Queue implementation in C#. The application acts as both a **producer** (message sender) and **consumer** (message receiver) for demonstrating the full message flow in Azure Service Bus.

## Architecture

The following diagram illustrates the architecture of this application:

```mermaid
graph LR
    A[C# Console Application] -->|1. Send Messages| B[Azure Service Bus Queue]
    B -->|2. Receive Messages| A
    
    style A fill:#8c39ac,stroke:#333,stroke-width:2px,color:#fff
    style B fill:#0078d4,stroke:#333,stroke-width:2px,color:#fff
    
    subgraph "Producer/Consumer Flow"
        A
    end
    
    subgraph "Azure Messaging Service"
        B
    end
```

### Architecture Components

#### **C# Console Application**
- **Role**: Producer and Consumer
- **Producer Functionality**: 
  - Creates a batch of messages
  - Sends messages to the Azure Service Bus Queue
  - Uses `ServiceBusClient` and `ServiceBusSender`
  
- **Consumer Functionality**: 
  - Processes messages from the queue
  - Implements message handlers and error handlers
  - Uses `ServiceBusProcessor` for asynchronous processing
  - Completes messages after successful processing

#### **Azure Service Bus Queue**
- **Purpose**: Message broker for reliable asynchronous communication
- **Features**:
  - Guaranteed message delivery
  - FIFO (First-In-First-Out) message ordering
  - At-least-once delivery semantics
  - Message persistence and durability

## Application Flow

1. **Message Production Phase**:
   - Application creates a `ServiceBusClient` connection
   - Creates a batch of 3 messages
   - Sends the batch to the configured queue
   - Displays confirmation message

2. **Message Consumption Phase**:
   - Application creates a `ServiceBusProcessor`
   - Registers message and error handlers
   - Starts processing messages asynchronously
   - Each message is logged and completed
   - Continues processing until user stops the application

## Configuration

The application uses the `AppConfiguration` class to manage:
- **Connection String**: Azure Service Bus namespace connection string
- **Queue Name**: Target queue name for message operations

## Key Features

- **Batch Message Sending**: Efficient message batching for better throughput
- **Asynchronous Processing**: Non-blocking message handling
- **Error Handling**: Dedicated error handler for processing failures
- **Message Completion**: Explicit message completion after successful processing
- **Interactive Console**: User-controlled start and stop of message processing

## Prerequisites

- .NET 8.0 SDK
- Azure Service Bus namespace
- Azure Service Bus Queue
- Azure.Messaging.ServiceBus NuGet package