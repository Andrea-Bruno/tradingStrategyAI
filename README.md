# Trading Strategy AI

MOTE:
This project was published in 2017 at this address https://sourceforge.net/projects/brute-force-algo-trading/ (please download the test .csv file from this address as it exceeds the maximum size allowed in the github repositories)

# Project Narrative: Democratizing High-Performance AI Trading

It has long been understood that the world’s largest financial institutions—such as **BlackRock**, **Vanguard**, **Citadel**, **Renaissance Technologies**, and **Two Sigma**—dominate the markets not only through capital but through access to cutting-edge technology. These firms invest hundreds of millions into proprietary systems that leverage artificial intelligence, high-frequency trading, and GPU-accelerated computation. The development costs and technical complexity of such systems make them inaccessible to independent traders and small firms.

In 2015, the Swiss company **QuantAlea**, in collaboration with **NVIDIA**, released **Alea GPU**, a powerful framework that enabled developers to run parallel algorithms on GPUs using .NET languages like C#. This marked a turning point: for the first time, GPU computing became accessible to developers outside the traditional C++/CUDA ecosystem. Alea GPU opened the door to building high-performance financial analytics tools capable of processing vast datasets in real time.

Leveraging this technology, I developed a proprietary trading system in C# that harnesses GPU acceleration for algorithmic decision-making. The system integrates:

- Monte Carlo simulations for probabilistic modeling  
- Genetic optimization for strategy selection  
- Real-time data ingestion and parallel processing  
- Predictive models trained on historical market behavior

## The Cost Barrier

Developing AI for financial trading is not a trivial endeavor. In 2015, building a custom AI system required:

- Specialized hardware (e.g., NVIDIA Tesla or Quadro GPUs)
- A team of experts in finance, machine learning, and GPU programming
- Months or years of development and testing
- Infrastructure for data storage, model training, and deployment

Estimates for custom AI development ranged from **$100,000 to over $500,000** for a prototype, with full-scale systems costing several million dollars. These figures exclude ongoing costs for maintenance, compliance, and model retraining.

## The Zero-Sum Reality

Financial trading is a **zero-sum game**: every profit made by one participant corresponds to a loss by another. In this environment, large institutions have no incentive to share their technological edge. Their systems are guarded as trade secrets, protected by NDAs, patents, and internal firewalls. The more sophisticated their algorithms, the greater their ability to exploit inefficiencies and outmaneuver smaller players.

Retail traders—often referred to as “small fish”—are left with empirical methods, basic indicators, and commercial platforms that lack the depth and speed of institutional tools. The asymmetry is deliberate: in a zero-sum system, the success of the few depends on the failure of the many.

## My Mission

My project challenges this paradigm. By combining open-access GPU technology with deep domain expertise, I’ve demonstrated that it’s possible to build advanced trading systems outside the walls of Wall Street. The goal is not to replicate institutional infrastructure, but to **democratize access to high-performance computation** and empower independent traders with tools that were once reserved for billion-dollar firms.

# The Rise of GPU-Driven AI Trading: Strategic Investments and Global Barriers

Computational hardware, in and of itself, holds no intrinsic value unless it is programmed with purpose. The raw power of GPUs remained largely untapped until 2015, when new technologies—such as Alea GPU and Hybridizer—enabled developers to write high-level code that could execute directly on NVIDIA graphics cards. This breakthrough marked a turning point in financial technology, allowing for the creation of highly parallelized, data-intensive trading algorithms.

The moment this capability became available, the world’s largest financial institutions began to mobilize. Firms like BlackRock, Citadel, Renaissance Technologies, and Two Sigma recognized the strategic advantage of GPU-accelerated AI and launched aggressive investment programs. These initiatives included the formation of specialized research divisions, recruitment of top-tier talent in machine learning and quantitative finance, and the deployment of high-performance computing clusters dedicated to algorithmic trading.

The scale of these investments was unprecedented. Citadel Securities reportedly allocated over $1 billion to infrastructure and AI development between 2015 and 2020. BlackRock expanded its Aladdin platform with hundreds of millions in funding, integrating predictive analytics and real-time risk modeling. Hedge funds like Renaissance Technologies and Two Sigma maintained annual R&D budgets in the hundreds of millions, focused on deep learning, reinforcement learning, and sentiment analysis. These efforts were not merely experimental—they delivered measurable results. AI-driven funds consistently outperformed traditional ones, achieving annual returns up to 3–5% higher, while reducing transaction costs by as much as 30%.

However, such colossal investments are far beyond the reach of non-global trading firms. Building a competitive AI trading system requires not only access to advanced hardware and massive datasets, but also a multidisciplinary team of experts and years of iterative development. The cost of entry for a meaningful AI initiative can easily exceed $10 million, making it inaccessible to retail traders and boutique firms.

This technological divide is not accidental. Financial trading is a zero-sum game—every gain made by one participant is offset by a loss from another. In this context, large institutions have no incentive to share their technological edge. On the contrary, they actively protect their systems through secrecy, intellectual property, and internal firewalls. The more sophisticated their algorithms, the greater their ability to exploit inefficiencies and outmaneuver smaller players.

As a result, these advanced technologies remain hidden from the broader trading community. Retail traders are left with empirical methods and commercial platforms, while institutional players operate with tools that resemble military-grade intelligence systems. The asymmetry is deliberate and strategic: in a zero-sum environment, information is power—and power is profit.

# Brute Force Algo Trading: Rethinking Strategy Through Computational Power

When new GPU technologies emerged around 2015, they represented more than just a hardware evolution—they offered a new frontier for algorithmic exploration. As someone deeply passionate about mathematics and algorithm design, I saw this as an irresistible challenge. I began experimenting, not with the goal of building a trading bot, but with the ambition to create a computational engine capable of discovering optimal trading strategies through brute force analysis.

This personal journey led to the creation of **Brute Force Algo Trading**, a project I released as open source in 2018 on SourceForge: [https://sourceforge.net/projects/brute-force-algo-trading/](https://sourceforge.net/projects/brute-force-algo-trading/). The project was never intended to execute trades or mimic traditional trading software. Instead, it was designed as a high-performance tool to systematically evaluate and compare trading algorithms using the immense computational power of NVIDIA GPUs.

In conventional trading software development, the process typically begins with an experienced trader who requests that their strategy be automated. Developers then translate that strategy into code, creating a system that reflects the trader’s empirical insights. This model relies heavily on human intuition and past experience, which I came to view as a limitation.

Having previously worked with AI algorithms for chess engines, I understood the fundamental shift that brute force computation brings. No human, regardless of skill, can match the strategic depth of a machine capable of evaluating millions of possibilities in seconds. Today, even the world chess champion stands no chance against a computer using brute force search. The machine’s ability to simulate and analyze vast decision trees far exceeds human capacity, and this is entirely due to its computational speed.

Inspired by this paradigm, I applied the same brute force principles to trading. Using GPU-accelerated computation, my system explores all possible trading strategies across historical price charts—such as BTC/USD pairs—and evaluates their performance mathematically. It does not rely on intuition or empirical rules. Instead, it tests every strategy systematically, measuring profitability, risk, and consistency, and selects the best-performing algorithm based on objective metrics.

This approach marks a clear departure from traditional automated trading. While conventional systems are built around human-derived strategies, my project uses raw computational power to discover strategies that humans might never conceive. By leveraging GPU clusters and parallel processing, the system can analyze thousands of algorithmic variations in a fraction of the time it would take a human team.

In essence, Brute Force Algo Trading is not a trading bot—it is a strategy discovery engine. It transforms the way we think about algorithmic trading by replacing subjective experience with exhaustive analysis. The result is a new kind of intelligence: one that is not taught, but computed.

## Technical Architecture: C# and Hybridizer on NVIDIA GPUs

The architecture of *Brute Force Algo Trading* is built around the idea of using brute force computation to discover optimal trading strategies. Unlike traditional systems that rely on human-designed heuristics, this project leverages the raw power of GPU clusters to evaluate millions of algorithmic combinations. The entire system is implemented in **C#**, and GPU acceleration is achieved through **Hybridizer**, a compiler developed by Altimesh that translates C# code into CUDA binaries for execution on NVIDIA GPUs.

### Core Components

- **Market Data Loader**
  - Imports historical trading data (e.g., BTC/USD) from CSV or API sources.
  - Preprocesses and normalizes data for consistent input across simulations.

- **Strategy Generator**
  - Dynamically creates a vast space of trading strategies using parameter permutations.
  - Strategies include combinations of indicators (e.g., EMA, RSI, MACD), thresholds, and timeframes.

- **Hybridizer-Accelerated Backtesting Engine**
  - Written in C#, compiled to CUDA using Hybridizer Essentials.
  - Executes strategy simulations in parallel across GPU threads.
  - Uses `Parallel.For` and other parallelization patterns to distribute workload efficiently.
  - Supports advanced C# features like generics and virtual functions, enabling flexible strategy modeling.

- **Performance Evaluator**
  - Computes key metrics for each strategy:
    - Net profit
    - Sharpe ratio
    - Drawdown
    - Trade frequency
  - Ranks strategies based on customizable scoring functions.

- **Result Analyzer**
  - Outputs top-performing strategies with detailed statistics.
  - Includes graphical analysis of equity curves and trade distributions.

### Infrastructure Overview

| Layer                  | Technology Used                          | Purpose                                      |
|------------------------|------------------------------------------|----------------------------------------------|
| Language               | C#                                       | High-level logic and strategy modeling       |
| GPU Compiler           | Hybridizer Essentials                    | Converts C# to CUDA for NVIDIA GPUs          |
| Compute Layer          | NVIDIA CUDA-enabled GPUs                 | Parallel brute force simulation              |
| IDE & Debugging        | Visual Studio + Nsight                   | Development and GPU-side debugging           |
| Data Layer             | CSV, REST APIs                           | Market data ingestion                        |
| Deployment             | Local GPU or datacenter cluster          | Scalable execution across multiple GPUs      |

### Performance Highlights

- Achieves near-peak GPU performance thanks to Hybridizer’s optimized CUDA compilation.
- Supports debugging of C# code running on GPU directly within Visual Studio.
- Capable of evaluating **millions of strategies per hour** on multi-GPU setups.

### Why Hybridizer?

Hybridizer allows developers to write high-performance GPU code in C# without needing to learn CUDA in depth. It supports advanced language features and integrates seamlessly with Visual Studio, making it ideal for financial applications where rapid prototyping and performance are both critical. The generated CUDA binaries can be profiled and debugged using NVIDIA Nsight, ensuring full transparency and control over execution.

---

This architecture transforms the way trading strategies are developed. By combining brute force computation with modern GPU acceleration and C# development tools, *Brute Force Algo Trading* offers a scalable, rigorous, and fully automated approach to strategy discovery.

## Precision, Flexibility, and Low-Level Optimization

Brute Force Algo Trading is designed to operate on **any trading pair**, not just BTC/USD. While initial tests were conducted using Bitcoin due to its volatility and rich historical data, the system architecture is fully generic and supports any asset combination—forex, commodities, indices, or cryptocurrencies.

### High-Resolution Historical Data

To ensure accurate performance evaluation, each strategy is tested against **high-resolution historical data** provided in CSV format. This data must include:

- Sub-second time intervals (tick-level or finer granularity).
- Precise price oscillations without smoothing or interpolation.
- Clean, timestamped records suitable for brute force simulation.

The resolution of the input chart is critical. Since the system evaluates thousands of strategies by simulating their behavior over historical price movements, even minor inaccuracies in the data can lead to misleading results. Strategies that rely on micro-trends or high-frequency signals require exact timing and price precision.

### Low-Level Optimization for High-Frequency Analysis

To handle such demanding precision, the software has been **deeply optimized at a low level** using advanced C# constructs and GPU acceleration via Hybridizer. Key optimizations include:

- **Archive compression** using `CompressArchive` to reduce memory footprint and improve access speed.
- **Trend detection** via `Monitorize` objects, which analyze directional movements and sudden shifts over configurable time spans.
- **Randomized parameter generation** using `GetRnd`, enabling efficient exploration of the strategy space.
- **Caching mechanisms** for trend and volatility conditions, reducing redundant computations across simulations.

These optimizations allow the system to simulate thousands of strategies per hour, even when working with sub-second data across large timeframes.

### Core Algorithmic Structure

The core logic resides in the [`Core.cs`](https://github.com/Andrea-Bruno/tradingStrategyAI/blob/master/Bitcoin%20Strategy/Core.cs#L18) file, which includes:

- `TestStrategy`: the main function that iteratively tests strategy configurations using randomized parameters and caching.
- `Stats`: a class that collects performance metrics and computes averages for each parameter, enabling statistical ranking.
- `Monitorize`: a structure used to define market conditions such as trend direction and volatility spikes.
- `Strategy`: the execution logic that simulates trades based on current strategy settings and market conditions.

Each strategy is evaluated by simulating its behavior over the historical dataset, computing its final performance relative to a baseline (e.g., buy-and-hold). The best-performing configurations are stored and ranked, with detailed metrics available for further analysis.

---

This architecture enables Brute Force Algo Trading to operate with unmatched precision and flexibility, making it suitable for discovering optimal strategies across any market and time resolution.

# Applying Brute Force GPU Technology to High-Frequency Trading Software

In the realm of high-frequency trading (HFT), speed is everything. Decisions must be made and executed in microseconds, and the infrastructure behind those decisions must be optimized for latency, throughput, and precision. While traditional HFT platforms rely on low-latency networks and co-location services near exchanges, the true competitive edge lies in the algorithms themselves—and in the computational power used to discover and refine them.

Brute Force Algo Trading was designed with this exact philosophy in mind. Although the project was originally conceived as a strategy discovery engine, its architecture and optimization techniques make it highly applicable to the development of advanced HFT software. The system is built in C# and accelerated using Hybridizer, which compiles .NET code into CUDA for execution on NVIDIA GPUs. This allows developers to write high-level logic while achieving near-native GPU performance.

What sets this project apart is its ability to analyze thousands of trading strategies across high-resolution historical data, including sub-second price movements. For HFT developers, this capability is crucial. Strategies that operate on millisecond-level timeframes require precise modeling and validation against granular market data. Brute Force Algo Trading supports this by ingesting CSV files with tick-level resolution, capturing every oscillation and microtrend that could influence trade execution.

The software’s core algorithms—such as `TestStrategy`, `Monitorize`, and `Stats`—are optimized for parallel execution and statistical evaluation. These components allow the system to simulate trading behavior under various market conditions, compute performance metrics, and rank strategies based on profitability, risk, and consistency. For HFT developers, this means they can use the platform not only to validate existing strategies but to discover new ones that outperform under specific latency constraints.

Moreover, the caching mechanisms and low-level optimizations implemented in the project ensure that even large-scale simulations remain computationally efficient. This is essential for HFT environments, where real-time responsiveness and throughput must be maintained without sacrificing analytical depth.

In essence, Brute Force Algo Trading provides a foundation for building intelligent, adaptive HFT systems. By leveraging GPU acceleration and brute force analysis, developers can move beyond empirical strategy design and toward a data-driven, algorithmically optimized approach. Whether used as a research tool or integrated into a live trading pipeline, the technology offers a scalable and rigorous framework for high-frequency trading innovation.

# Scalable GPU-Driven Strategy Discovery and Real-Time HFT Execution

## Overview

The Brute Force Algo Trading system is designed to perform large-scale strategy discovery using GPU acceleration. By deploying this software across a datacenter equipped with NVIDIA GPUs, developers can simulate and evaluate millions of trading strategies in parallel. The most promising strategies are continuously selected and transferred to a custom-built high-frequency trading (HFT) execution platform.

## Phase 1: Distributed Strategy Search in the GPU Datacenter

Each GPU node runs thousands of strategy simulations using the `TestStrategy` function, which is optimized for parallel execution and caching. The system analyzes tick-level historical data and evaluates performance metrics such as return, drawdown, and consistency.

- Massive parallelization via CUDA and Hybridizer
- Smart caching to reduce redundant computations
- Statistical aggregation using the `Stats` module
- Continuous ranking of strategy parameters via `GetBestValue`

The datacenter acts as a strategy factory, constantly generating new configurations and refining them based on performance.

## Phase 2: Strategy Selection and Validation

As strategies are tested, the best-performing configurations are serialized into `StategySettings` objects and stored in a central repository. These are validated using out-of-sample data to ensure robustness.

- Automatic persistence of top strategies
- Cross-validation to prevent overfitting
- Dynamic ranking based on both historical and live performance

## Phase 3: Real-Time Transfer to the HFT Execution Platform

The selected strategies are sent to a dedicated HFT platform via a secure API. This platform is optimized for ultra-low latency execution and supports dynamic strategy replacement.

- API-based transfer of `StategySettings` objects
- Hot-swapping of strategies without interrupting execution
- Real-time feedback loop from live trading performance
- Continuous refinement based on execution results

## System Architecture

```plaintext
+----------------------+        +------------------------+        +----------------------+
|  GPU Strategy Node   |  --->  |  Central Strategy Hub  |  --->  |  Real-Time HFT Core  |
|  (CUDA + Hybridizer) |        |  (Ranking + Validation)|        |  (Execution Engine)  |
+----------------------+        +------------------------+        +----------------------+

```


# Identifying the Most Effective Binary Options Strategy with GPU-Driven Brute Force Technology

Binary options trading is built on a simple premise: predicting whether the price of an asset will move above or below a certain level within a fixed time frame. Despite its apparent simplicity, the challenge lies in consistently making accurate predictions across volatile market conditions. This is where brute force GPU-driven technology becomes transformative.

The Brute Force Algo Trading system is designed to simulate and evaluate thousands of strategy configurations across historical data with sub-second resolution. For binary options, especially short-term contracts like 60- or 120-second expiries, this level of granularity is essential. The system can ingest tick-level data and test strategies that vary in entry timing, expiry duration, asset selection, and volatility thresholds.

Unlike traditional backtesting, which is often limited by computational constraints, this technology allows for exhaustive exploration. It can simulate every possible combination of parameters across multiple assets and timeframes, identifying which setups consistently produce in-the-money outcomes. For example, in One-Touch options—where the goal is for the price to touch a predefined level—the system can detect micro-patterns in price behavior that precede such movements. These patterns are often invisible to human traders but become statistically significant when analyzed across millions of data points.

As strategies are tested, the system ranks them based on win rate, payout ratio, and drawdown. The most promising configurations are validated on out-of-sample data to ensure robustness. Once validated, they are packaged and sent to a live trading platform capable of executing binary options trades in real time. This platform can dynamically switch strategies based on market conditions, ensuring that only the most effective algorithms are active.

The feedback loop is continuous. Live performance data is sent back to the GPU cluster, where it informs the next round of simulations. This creates a self-improving system that adapts to changing market dynamics and refines its strategy selection over time.

In essence, brute force GPU technology transforms binary options trading from a speculative endeavor into a data-driven discipline. It replaces intuition with statistical rigor, enabling traders to operate with precision and confidence in a market where every second counts.

# A Pioneer in AI-Driven Financial Trading: The 2018 Vision Ahead of Its Time

In the early days of GPU computing for financial applications, few outside the walls of global hedge funds and institutional trading desks understood the transformative potential of artificial intelligence. The year was 2018, and while firms like BlackRock, Citadel, and Renaissance Technologies were quietly assembling elite teams to harness machine learning and deep learning for market prediction, the broader developer community remained largely unaware of what was coming.

It was in this context that I released the first version of *Brute Force Algo Trading* on SourceForge, an open-source project designed to explore trading strategies using brute force computation on GPU hardware. The project was not a conventional trading bot. It was a research engine—built in C# and accelerated with NVIDIA GPU technology—that could simulate and evaluate thousands of trading strategies across high-resolution historical data. At a time when most independent developers were still experimenting with basic indicators and rule-based systems, this project introduced a radically different approach: let the machine discover the strategy, not the human.

The architecture of the system reflected this philosophy. It used brute force to test every possible configuration of trading parameters, leveraging GPU parallelism to process millions of data points in seconds. The goal was not to replicate human intuition, but to surpass it. Inspired by my earlier work with AI in chess engines, I understood that no human trader—no matter how experienced—could match the analytical depth of a machine capable of evaluating every possible path. Just as modern chess engines have rendered human strategy obsolete, I believed that trading algorithms could evolve beyond empirical design.

By publishing the project in 2018, I positioned myself at the frontier of a technological shift that would soon redefine financial markets. That same year, academic papers began to emerge exploring deep reinforcement learning for trading, and institutions were quietly investing billions into AI infrastructure. Yet few independent developers had access to the tools, and even fewer had the vision to apply them to trading in a systematic way.

Today, AI-driven trading is no longer a niche—it is the foundation of modern market operations. But back in 2018, the idea of using brute force GPU computation to discover optimal strategies was considered experimental, even radical. The release of *Brute Force Algo Trading* marked a moment where open-source innovation met institutional-grade technology, and where a single developer could challenge the status quo of financial engineering.

Looking back, the project was more than software. It was a statement: that advanced algorithmic discovery should not be the exclusive domain of billion-dollar firms. It was a call to democratize access to high-performance computing and to reimagine how trading strategies are created, tested, and deployed. And in doing so, it placed me—quietly but unmistakably—among the pioneers of AI in financial trading.

# Parallel Execution of Brute Force Algo Trading on NVIDIA GPUs

The Brute Force Algo Trading system is inherently designed for parallel computation. Its core logic, as defined in the `Core.cs` file, revolves around the repeated simulation of trading strategies across a historical dataset. Each iteration involves randomized parameter generation, strategy evaluation, and performance tracking. This structure makes it an ideal candidate for GPU acceleration, where thousands of strategy simulations can be executed concurrently.

To deploy this system on NVIDIA GPUs, the computational workload must be offloaded from the CPU to the GPU using CUDA. Since the project is written in C#, the most effective way to achieve this is through Hybridizer Essentials, a compiler that translates C# code into CUDA kernels. This allows the developer to retain the high-level structure of the code while executing performance-critical loops on the GPU.

The main loop in `TestStrategy`, which iterates over thousands of strategy configurations, can be parallelized by converting it into a GPU kernel. Each thread on the GPU would be responsible for simulating a unique strategy instance, using its own randomized parameters and accessing shared historical data. The caching mechanisms for trend detection (`CacheTrendUp`, `CacheTrendDown`, etc.) can be preloaded into GPU memory to minimize latency during execution.

Performance metrics such as USD gain, drawdown, and relative performance are computed independently for each thread. Once all threads complete their simulations, the results are aggregated on the host side to identify the best-performing configurations. This aggregation step can also be parallelized using reduction techniques available in CUDA.

To implement this architecture, the following steps are required:

1. Refactor the strategy simulation logic into a GPU-compatible method, ensuring that all data structures are serializable and memory-safe.
2. Use Hybridizer to compile the C# method into a CUDA kernel, mapping each strategy simulation to a GPU thread.
3. Allocate GPU memory for historical data, parameter ranges, and result buffers.
4. Launch the kernel with a grid size corresponding to the number of strategy permutations to be tested.
5. Retrieve and rank the results on the CPU, updating the `Stats` objects and storing the best configurations.

This approach enables the system to scale across multiple GPUs, each handling tens of thousands of strategy evaluations per second. By distributing the workload across a GPU cluster, the system transforms into a high-throughput strategy discovery engine capable of real-time adaptation and continuous optimization.

In summary, the Brute Force Algo Trading codebase is well-suited for parallel execution on NVIDIA GPUs. With minimal refactoring and the use of Hybridizer, the system can achieve massive computational acceleration, making it a powerful tool for financial research, algorithmic development, and high-frequency trading innovation.

## GPU Memory Allocation for Parallel Strategy Simulation

The Brute Force Algo Trading system, as defined in the `Core.cs` module, is structured around the repeated simulation of trading strategies using randomized parameters and historical price data. Each simulation is independent and stateless, making the entire process ideal for parallel execution on GPU hardware.

To scale this computation across thousands of strategy permutations, the system can be extended to allocate memory directly on NVIDIA GPUs using CUDA. By leveraging Hybridizer Essentials, C# code can be compiled into CUDA kernels, allowing developers to retain the high-level structure of the strategy logic while executing it with GPU-level performance.

The following example demonstrates how to allocate GPU memory for historical price data and strategy parameters, launch a parallel kernel to simulate each strategy, and retrieve the results back to the host. This approach enables the system to evaluate thousands of strategies per second, dramatically accelerating the discovery of optimal configurations.

```csharp

using Hybridizer.Runtime.CUDAImports;

public class GpuAllocator
{
    [EntryPoint]
    public static void AllocateAndInitialize(double[] historicalRates, double[] parameters, double[] results)
    {
        int dataLength = historicalRates.Length;
        int paramLength = parameters.Length;

        // Allocate memory on GPU
        double* d_historicalRates = (double*)cudaMalloc(sizeof(double) * dataLength);
        double* d_parameters = (double*)cudaMalloc(sizeof(double) * paramLength);
        double* d_results = (double*)cudaMalloc(sizeof(double) * paramLength);

        // Copy data from host to device
        cudaMemcpy(d_historicalRates, historicalRates, sizeof(double) * dataLength, cudaMemcpyKind.cudaMemcpyHostToDevice);
        cudaMemcpy(d_parameters, parameters, sizeof(double) * paramLength, cudaMemcpyKind.cudaMemcpyHostToDevice);

        // Launch kernel (each thread simulates one strategy)
        LaunchKernel(d_historicalRates, d_parameters, d_results, dataLength, paramLength);

        // Copy results back to host
        cudaMemcpy(results, d_results, sizeof(double) * paramLength, cudaMemcpyKind.cudaMemcpyDeviceToHost);

        // Free GPU memory
        cudaFree(d_historicalRates);
        cudaFree(d_parameters);
        cudaFree(d_results);
    }

    [Kernel]
    public static void LaunchKernel(double* rates, double* parameters, double* results, int dataLength, int paramLength)
    {
        int idx = threadIdx.x + blockIdx.x * blockDim.x;
        if (idx < paramLength)
        {
            double param = parameters[idx];
            double result = SimulateStrategy(rates, dataLength, param);
            results[idx] = result;
        }
    }

    public static double SimulateStrategy(double* rates, int length, double param)
    {
        double usd = 1000.0;
        double btc = 0.0;

        for (int i = 0; i < length - 1; i++)
        {
            // Example logic: buy if rate increases by param threshold
            if (rates[i + 1] - rates[i] > param)
            {
                btc = usd / rates[i];
                usd = 0;
            }
            else if (rates[i + 1] - rates[i] < -param)
            {
                usd = btc * rates[i];
                btc = 0;
            }
        }

        return usd + btc * rates[length - 1];
    }
}

```