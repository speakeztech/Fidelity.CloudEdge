module rec Glutinum

open Fable.Core
open Fable.Core.JsInterop
open System

// You need to add Glutinum.Types NuGet package to your project
open Glutinum.Types.TypeScript

type RegExp = Text.RegularExpressions.Regex

type Iterable<'T> = Collections.Generic.IEnumerable<'T>

[<AbstractClass>]
[<Erase>]
type Exports =
    [<Import("addEventListener", "Fidelity.CloudEdge.Worker.Context")>]
    static member addEventListener<'Type when 'Type :> obj> (``type``: 'Type, handler: EventListenerOrEventListenerObject<obj>, ?options: U2<EventTargetAddEventListenerOptions, bool>) : unit = nativeOnly
    [<Import("removeEventListener", "Fidelity.CloudEdge.Worker.Context")>]
    static member removeEventListener<'Type when 'Type :> obj> (``type``: 'Type, handler: EventListenerOrEventListenerObject<obj>, ?options: U2<EventTargetEventListenerOptions, bool>) : unit = nativeOnly
    /// <summary>
    /// The **<c>dispatchEvent()</c>** method of the EventTarget sends an Event to the object, (synchronously) invoking the affected event listeners in the appropriate order.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/EventTarget/dispatchEvent)
    /// </summary>
    [<Import("dispatchEvent", "Fidelity.CloudEdge.Worker.Context")>]
    static member dispatchEvent (event: obj) : bool = nativeOnly
    [<Import("btoa", "Fidelity.CloudEdge.Worker.Context")>]
    static member btoa (data: string) : string = nativeOnly
    [<Import("atob", "Fidelity.CloudEdge.Worker.Context")>]
    static member atob (data: string) : string = nativeOnly
    [<Import("setTimeout", "Fidelity.CloudEdge.Worker.Context")>]
    static member setTimeout (callback: System.Delegate, ?msDelay: float) : float = nativeOnly
    [<Import("setTimeout", "Fidelity.CloudEdge.Worker.Context")>]
    static member setTimeout<'Args when 'Args :> ResizeArray<obj>> (callback: System.Delegate, ?msDelay: float, [<ParamArray>] args: 'Args []) : float = nativeOnly
    [<Import("clearTimeout", "Fidelity.CloudEdge.Worker.Context")>]
    static member clearTimeout (timeoutId: U2<float, obj>) : unit = nativeOnly
    [<Import("setInterval", "Fidelity.CloudEdge.Worker.Context")>]
    static member setInterval (callback: System.Delegate, ?msDelay: float) : float = nativeOnly
    [<Import("setInterval", "Fidelity.CloudEdge.Worker.Context")>]
    static member setInterval<'Args when 'Args :> ResizeArray<obj>> (callback: System.Delegate, ?msDelay: float, [<ParamArray>] args: 'Args []) : float = nativeOnly
    [<Import("clearInterval", "Fidelity.CloudEdge.Worker.Context")>]
    static member clearInterval (timeoutId: U2<float, obj>) : unit = nativeOnly
    [<Import("queueMicrotask", "Fidelity.CloudEdge.Worker.Context")>]
    static member queueMicrotask (task: Action) : unit = nativeOnly
    [<Import("structuredClone", "Fidelity.CloudEdge.Worker.Context")>]
    static member structuredClone<'T> (value: 'T, ?options: StructuredSerializeOptions) : 'T = nativeOnly
    [<Import("reportError", "Fidelity.CloudEdge.Worker.Context")>]
    static member reportError (error: obj) : unit = nativeOnly
    [<Import("fetch", "Fidelity.CloudEdge.Worker.Context")>]
    static member fetch (input: U2<RequestInfo, URL>, ?init: RequestInit<RequestInitCfProperties>) : JS.Promise<Response> = nativeOnly
    [<Import("DOMException", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member DOMException (?message: string, ?name: string) : DOMException = nativeOnly
    [<Import("WorkerGlobalScope", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member WorkerGlobalScope () : WorkerGlobalScope = nativeOnly
    [<Import("DurableObjectNamespace", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member DurableObjectNamespace<'T when 'T :> Rpc.DurableObjectBranded option> () : DurableObjectNamespace<'T> = nativeOnly
    [<Import("WebSocketRequestResponsePair", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member WebSocketRequestResponsePair (request: string, response: string) : WebSocketRequestResponsePair = nativeOnly
    [<Import("Event", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member Event (``type``: string, ?init: EventInit) : Event = nativeOnly
    [<Import("EventTarget", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member EventTarget<'EventMap when 'EventMap :> Exports.EventTarget_1> () : EventTarget<'EventMap> = nativeOnly
    [<Import("AbortController", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member AbortController () : AbortController = nativeOnly
    [<Import("AbortSignal", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member AbortSignal () : AbortSignal = nativeOnly
    [<Import("ExtendableEvent", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member ExtendableEvent () : ExtendableEvent = nativeOnly
    [<Import("CustomEvent", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member CustomEvent<'T> (``type``: string, ?init: CustomEventCustomEventInit) : CustomEvent<'T> = nativeOnly
    [<Import("Blob", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member Blob (?``type``: ResizeArray<U3<U2<ArrayBuffer, ArrayBufferView>, string, Blob>>, ?options: BlobOptions) : Blob = nativeOnly
    [<Import("File", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member File (bits: ResizeArray<U3<U2<ArrayBuffer, ArrayBufferView>, string, Blob>> option, name: string, ?options: FileOptions) : File = nativeOnly
    [<Import("CacheStorage", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member CacheStorage () : CacheStorage = nativeOnly
    [<Import("Cache", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member Cache () : Cache = nativeOnly
    [<Import("Crypto", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member Crypto () : Crypto = nativeOnly
    [<Import("SubtleCrypto", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member SubtleCrypto () : SubtleCrypto = nativeOnly
    [<Import("CryptoKey", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member CryptoKey () : CryptoKey = nativeOnly
    [<Import("DigestStream", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member DigestStream (algorithm: U2<string, SubtleCryptoHashAlgorithm>) : DigestStream = nativeOnly
    [<Import("TextDecoder", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member TextDecoder (?label: string, ?options: TextDecoderConstructorOptions) : TextDecoder = nativeOnly
    [<Import("TextEncoder", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member TextEncoder () : TextEncoder = nativeOnly
    [<Import("ErrorEvent", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member ErrorEvent (``type``: string, ?init: ErrorEventErrorEventInit) : ErrorEvent = nativeOnly
    [<Import("MessageEvent", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member MessageEvent (``type``: string, initializer: MessageEventInit) : MessageEvent = nativeOnly
    [<Import("PromiseRejectionEvent", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member PromiseRejectionEvent () : PromiseRejectionEvent = nativeOnly
    [<Import("FormData", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member FormData () : FormData = nativeOnly
    [<Import("HTMLRewriter", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member HTMLRewriter () : HTMLRewriter = nativeOnly
    [<Import("FetchEvent", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member FetchEvent () : FetchEvent = nativeOnly
    [<Import("Headers", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member Headers (?init: HeadersInit) : Headers = nativeOnly
    [<Import("Body", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member Body () : Body = nativeOnly
    [<Import("R2Bucket", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member R2Bucket () : R2Bucket = nativeOnly
    [<Import("R2Object", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member R2Object () : R2Object = nativeOnly
    [<Import("ScheduledEvent", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member ScheduledEvent () : ScheduledEvent = nativeOnly
    [<Import("ReadableStreamDefaultReader", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member ReadableStreamDefaultReader<'R> (stream: obj) : ReadableStreamDefaultReader<'R> = nativeOnly
    [<Import("ReadableStreamBYOBReader", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member ReadableStreamBYOBReader (stream: obj) : ReadableStreamBYOBReader = nativeOnly
    [<Import("WritableStream", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member WritableStream<'W> (?underlyingSink: UnderlyingSink, ?queuingStrategy: QueuingStrategy) : WritableStream<'W> = nativeOnly
    [<Import("WritableStreamDefaultWriter", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member WritableStreamDefaultWriter<'W> (stream: obj) : WritableStreamDefaultWriter<'W> = nativeOnly
    [<Import("TransformStream", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member TransformStream<'I, 'O> (?transformer: Transformer<'I, 'O>, ?writableStrategy: QueuingStrategy<'I>, ?readableStrategy: QueuingStrategy<'O>) : TransformStream<'I, 'O> = nativeOnly
    [<Import("FixedLengthStream", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member FixedLengthStream (expectedLength: U2<float, obj>, ?queuingStrategy: IdentityTransformStreamQueuingStrategy) : FixedLengthStream = nativeOnly
    [<Import("IdentityTransformStream", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member IdentityTransformStream (?queuingStrategy: IdentityTransformStreamQueuingStrategy) : IdentityTransformStream = nativeOnly
    [<Import("CompressionStream", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member CompressionStream (format: Exports.CompressionStream.format) : CompressionStream = nativeOnly
    [<Import("DecompressionStream", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member DecompressionStream (format: Exports.DecompressionStream.format) : DecompressionStream = nativeOnly
    [<Import("TextEncoderStream", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member TextEncoderStream () : TextEncoderStream = nativeOnly
    [<Import("TextDecoderStream", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member TextDecoderStream (?label: string, ?options: TextDecoderStreamTextDecoderStreamInit) : TextDecoderStream = nativeOnly
    [<Import("ByteLengthQueuingStrategy", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member ByteLengthQueuingStrategy (init: QueuingStrategyInit) : ByteLengthQueuingStrategy = nativeOnly
    [<Import("CountQueuingStrategy", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member CountQueuingStrategy (init: QueuingStrategyInit) : CountQueuingStrategy = nativeOnly
    [<Import("TailEvent", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member TailEvent () : TailEvent = nativeOnly
    [<Import("URL", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member URL (url: U2<string, URL>, ?``base``: U2<string, URL>) : URL = nativeOnly
    [<Import("URLSearchParams", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member URLSearchParams (?init: U4<URLSearchParams, string, Exports.URLSearchParams.init.U4.Case3, ResizeArray<string * string>>) : URLSearchParams = nativeOnly
    [<Import("URLPattern", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member URLPattern (?input: U2<string, URLPatternInit>, ?baseURL: U2<string, URLPatternOptions>, ?patternOptions: URLPatternOptions) : URLPattern = nativeOnly
    [<Import("CloseEvent", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member CloseEvent (``type``: string, ?initializer: CloseEventInit) : CloseEvent = nativeOnly
    [<Import("SqlStorageStatement", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member SqlStorageStatement () : SqlStorageStatement = nativeOnly
    [<Import("SqlStorageCursor", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member SqlStorageCursor<'T when 'T :> Exports.SqlStorageCursor> () : SqlStorageCursor<'T> = nativeOnly
    [<Import("EventSource", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member EventSource (url: string, ?init: EventSourceEventSourceInit) : EventSource = nativeOnly
    [<Import("MessagePort", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member MessagePort () : MessagePort = nativeOnly
    [<Import("Performance", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member Performance () : Performance = nativeOnly
    [<Import("AiSearchInstanceService", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member AiSearchInstanceService () : AiSearchInstanceService = nativeOnly
    [<Import("AiSearchAccountService", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member AiSearchAccountService () : AiSearchAccountService = nativeOnly
    [<Import("BaseAiImageClassification", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member BaseAiImageClassification () : BaseAiImageClassification = nativeOnly
    [<Import("BaseAiImageToText", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member BaseAiImageToText () : BaseAiImageToText = nativeOnly
    [<Import("BaseAiImageTextToText", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member BaseAiImageTextToText () : BaseAiImageTextToText = nativeOnly
    [<Import("BaseAiMultimodalEmbeddings", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member BaseAiMultimodalEmbeddings () : BaseAiMultimodalEmbeddings = nativeOnly
    [<Import("BaseAiObjectDetection", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member BaseAiObjectDetection () : BaseAiObjectDetection = nativeOnly
    [<Import("BaseAiSentenceSimilarity", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member BaseAiSentenceSimilarity () : BaseAiSentenceSimilarity = nativeOnly
    [<Import("BaseAiAutomaticSpeechRecognition", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member BaseAiAutomaticSpeechRecognition () : BaseAiAutomaticSpeechRecognition = nativeOnly
    [<Import("BaseAiSummarization", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member BaseAiSummarization () : BaseAiSummarization = nativeOnly
    [<Import("BaseAiTextClassification", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member BaseAiTextClassification () : BaseAiTextClassification = nativeOnly
    [<Import("BaseAiTextEmbeddings", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member BaseAiTextEmbeddings () : BaseAiTextEmbeddings = nativeOnly
    [<Import("BaseAiTextGeneration", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member BaseAiTextGeneration () : BaseAiTextGeneration = nativeOnly
    [<Import("BaseAiTextToSpeech", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member BaseAiTextToSpeech () : BaseAiTextToSpeech = nativeOnly
    [<Import("BaseAiTextToImage", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member BaseAiTextToImage () : BaseAiTextToImage = nativeOnly
    [<Import("BaseAiTranslation", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member BaseAiTranslation () : BaseAiTranslation = nativeOnly
    [<Import("Base_Ai_Cf_Baai_Bge_Base_En_V1_5", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member Base_Ai_Cf_Baai_Bge_Base_En_V1_5 () : Base_Ai_Cf_Baai_Bge_Base_En_V1_5 = nativeOnly
    [<Import("Base_Ai_Cf_Openai_Whisper", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member Base_Ai_Cf_Openai_Whisper () : Base_Ai_Cf_Openai_Whisper = nativeOnly
    [<Import("Base_Ai_Cf_Meta_M2M100_1_2B", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member Base_Ai_Cf_Meta_M2M100_1_2B () : Base_Ai_Cf_Meta_M2M100_1_2B = nativeOnly
    [<Import("Base_Ai_Cf_Baai_Bge_Small_En_V1_5", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member Base_Ai_Cf_Baai_Bge_Small_En_V1_5 () : Base_Ai_Cf_Baai_Bge_Small_En_V1_5 = nativeOnly
    [<Import("Base_Ai_Cf_Baai_Bge_Large_En_V1_5", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member Base_Ai_Cf_Baai_Bge_Large_En_V1_5 () : Base_Ai_Cf_Baai_Bge_Large_En_V1_5 = nativeOnly
    [<Import("Base_Ai_Cf_Unum_Uform_Gen2_Qwen_500M", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member Base_Ai_Cf_Unum_Uform_Gen2_Qwen_500M () : Base_Ai_Cf_Unum_Uform_Gen2_Qwen_500M = nativeOnly
    [<Import("Base_Ai_Cf_Openai_Whisper_Tiny_En", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member Base_Ai_Cf_Openai_Whisper_Tiny_En () : Base_Ai_Cf_Openai_Whisper_Tiny_En = nativeOnly
    [<Import("Base_Ai_Cf_Openai_Whisper_Large_V3_Turbo", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member Base_Ai_Cf_Openai_Whisper_Large_V3_Turbo () : Base_Ai_Cf_Openai_Whisper_Large_V3_Turbo = nativeOnly
    [<Import("Base_Ai_Cf_Baai_Bge_M3", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member Base_Ai_Cf_Baai_Bge_M3 () : Base_Ai_Cf_Baai_Bge_M3 = nativeOnly
    [<Import("Base_Ai_Cf_Black_Forest_Labs_Flux_1_Schnell", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member Base_Ai_Cf_Black_Forest_Labs_Flux_1_Schnell () : Base_Ai_Cf_Black_Forest_Labs_Flux_1_Schnell = nativeOnly
    [<Import("Base_Ai_Cf_Meta_Llama_3_2_11B_Vision_Instruct", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member Base_Ai_Cf_Meta_Llama_3_2_11B_Vision_Instruct () : Base_Ai_Cf_Meta_Llama_3_2_11B_Vision_Instruct = nativeOnly
    [<Import("Base_Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member Base_Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast () : Base_Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast = nativeOnly
    [<Import("Base_Ai_Cf_Meta_Llama_Guard_3_8B", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member Base_Ai_Cf_Meta_Llama_Guard_3_8B () : Base_Ai_Cf_Meta_Llama_Guard_3_8B = nativeOnly
    [<Import("Base_Ai_Cf_Baai_Bge_Reranker_Base", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member Base_Ai_Cf_Baai_Bge_Reranker_Base () : Base_Ai_Cf_Baai_Bge_Reranker_Base = nativeOnly
    [<Import("Base_Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member Base_Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct () : Base_Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct = nativeOnly
    [<Import("Base_Ai_Cf_Qwen_Qwq_32B", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member Base_Ai_Cf_Qwen_Qwq_32B () : Base_Ai_Cf_Qwen_Qwq_32B = nativeOnly
    [<Import("Base_Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member Base_Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct () : Base_Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct = nativeOnly
    [<Import("Base_Ai_Cf_Google_Gemma_3_12B_It", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member Base_Ai_Cf_Google_Gemma_3_12B_It () : Base_Ai_Cf_Google_Gemma_3_12B_It = nativeOnly
    [<Import("Base_Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member Base_Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct () : Base_Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct = nativeOnly
    [<Import("Base_Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member Base_Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8 () : Base_Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8 = nativeOnly
    [<Import("Base_Ai_Cf_Deepgram_Nova_3", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member Base_Ai_Cf_Deepgram_Nova_3 () : Base_Ai_Cf_Deepgram_Nova_3 = nativeOnly
    [<Import("Base_Ai_Cf_Qwen_Qwen3_Embedding_0_6B", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member Base_Ai_Cf_Qwen_Qwen3_Embedding_0_6B () : Base_Ai_Cf_Qwen_Qwen3_Embedding_0_6B = nativeOnly
    [<Import("Base_Ai_Cf_Pipecat_Ai_Smart_Turn_V2", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member Base_Ai_Cf_Pipecat_Ai_Smart_Turn_V2 () : Base_Ai_Cf_Pipecat_Ai_Smart_Turn_V2 = nativeOnly
    [<Import("Base_Ai_Cf_Openai_Gpt_Oss_120B", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member Base_Ai_Cf_Openai_Gpt_Oss_120B () : Base_Ai_Cf_Openai_Gpt_Oss_120B = nativeOnly
    [<Import("Base_Ai_Cf_Openai_Gpt_Oss_20B", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member Base_Ai_Cf_Openai_Gpt_Oss_20B () : Base_Ai_Cf_Openai_Gpt_Oss_20B = nativeOnly
    [<Import("Base_Ai_Cf_Leonardo_Phoenix_1_0", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member Base_Ai_Cf_Leonardo_Phoenix_1_0 () : Base_Ai_Cf_Leonardo_Phoenix_1_0 = nativeOnly
    [<Import("Base_Ai_Cf_Leonardo_Lucid_Origin", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member Base_Ai_Cf_Leonardo_Lucid_Origin () : Base_Ai_Cf_Leonardo_Lucid_Origin = nativeOnly
    [<Import("Base_Ai_Cf_Deepgram_Aura_1", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member Base_Ai_Cf_Deepgram_Aura_1 () : Base_Ai_Cf_Deepgram_Aura_1 = nativeOnly
    [<Import("Base_Ai_Cf_Ai4Bharat_Indictrans2_En_Indic_1B", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member Base_Ai_Cf_Ai4Bharat_Indictrans2_En_Indic_1B () : Base_Ai_Cf_Ai4Bharat_Indictrans2_En_Indic_1B = nativeOnly
    [<Import("Base_Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member Base_Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It () : Base_Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It = nativeOnly
    [<Import("Base_Ai_Cf_Pfnet_Plamo_Embedding_1B", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member Base_Ai_Cf_Pfnet_Plamo_Embedding_1B () : Base_Ai_Cf_Pfnet_Plamo_Embedding_1B = nativeOnly
    [<Import("Base_Ai_Cf_Deepgram_Flux", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member Base_Ai_Cf_Deepgram_Flux () : Base_Ai_Cf_Deepgram_Flux = nativeOnly
    [<Import("Base_Ai_Cf_Deepgram_Aura_2_En", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member Base_Ai_Cf_Deepgram_Aura_2_En () : Base_Ai_Cf_Deepgram_Aura_2_En = nativeOnly
    [<Import("Base_Ai_Cf_Deepgram_Aura_2_Es", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member Base_Ai_Cf_Deepgram_Aura_2_Es () : Base_Ai_Cf_Deepgram_Aura_2_Es = nativeOnly
    [<Import("Ai", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member Ai<'AiModelList when 'AiModelList :> AiModelListType> () : Ai<'AiModelList> = nativeOnly
    [<Import("AiGateway", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member AiGateway () : AiGateway = nativeOnly
    [<Import("AutoRAG", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member AutoRAG () : AutoRAG = nativeOnly
    [<Import("D1Database", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member D1Database () : D1Database = nativeOnly
    [<Import("D1DatabaseSession", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member D1DatabaseSession () : D1DatabaseSession = nativeOnly
    [<Import("D1PreparedStatement", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member D1PreparedStatement () : D1PreparedStatement = nativeOnly
    [<Import("EmailEvent", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member EmailEvent () : EmailEvent = nativeOnly
    [<Import("ToMarkdownService", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member ToMarkdownService () : ToMarkdownService = nativeOnly
    [<Import("VectorizeIndex", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member VectorizeIndex () : VectorizeIndex = nativeOnly
    [<Import("Vectorize", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member Vectorize () : Vectorize = nativeOnly
    [<Import("Workflow", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member Workflow<'PARAMS> () : Workflow<'PARAMS> = nativeOnly
    [<Import("WorkflowInstance", "Fidelity.CloudEdge.Worker.Context"); EmitConstructor>]
    static member WorkflowInstance () : WorkflowInstance = nativeOnly
    [<ImportAll("Fidelity.CloudEdge.Worker.Context")>]
    static member inline WebAssembly
        with get () : WebAssembly_.Exports =
            nativeOnly
    [<ImportAll("Fidelity.CloudEdge.Worker.Context")>]
    static member inline cloudflare:node
        with get () : cloudflare:node_.Exports =
            nativeOnly
    [<ImportAll("Fidelity.CloudEdge.Worker.Context")>]
    static member inline assets:*
        with get () : assets:*_.Exports =
            nativeOnly
    [<ImportAll("Fidelity.CloudEdge.Worker.Context")>]
    static member inline cloudflare:pipelines
        with get () : cloudflare:pipelines_.Exports =
            nativeOnly
    [<ImportAll("Fidelity.CloudEdge.Worker.Context")>]
    static member inline Rpc
        with get () : Rpc_.Exports =
            nativeOnly
    [<ImportAll("Fidelity.CloudEdge.Worker.Context")>]
    static member inline CloudflareWorkersModule
        with get () : CloudflareWorkersModule_.Exports =
            nativeOnly
    [<ImportAll("Fidelity.CloudEdge.Worker.Context")>]
    static member inline cloudflare:sockets
        with get () : cloudflare:sockets_.Exports =
            nativeOnly
    [<ImportAll("Fidelity.CloudEdge.Worker.Context")>]
    static member inline cloudflare:workflows
        with get () : cloudflare:workflows_.Exports =
            nativeOnly


/// <summary>
/// The **<c>DOMException</c>** interface represents an abnormal event (called an **exception**) that occurs as a result of calling a method or accessing a property of a web API.
///
/// [MDN Reference](https://developer.mozilla.org/docs/Web/API/DOMException)
/// </summary>
[<AllowNullLiteral>]
[<AbstractClass>]
type DOMException =
    inherit Exception
    /// <summary>
    /// The **<c>message</c>** read-only property of the a message or description associated with the given error name.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/DOMException/message)
    /// </summary>
    abstract member message: string with get
    /// <summary>
    /// The **<c>name</c>** read-only property of the one of the strings associated with an error name.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/DOMException/name)
    /// </summary>
    abstract member name: string with get
    /// <summary>
    /// The **<c>code</c>** read-only property of the DOMException interface returns one of the legacy error code constants, or <c>0</c> if none match.
    /// </summary>
    [<Obsolete("[MDN Reference](https://developer.mozilla.org/docs/Web/API/DOMException/code)")>]
    abstract member code: float with get
    static member inline INDEX_SIZE_ERR
        with get () : float =
            emitJsExpr () $$"""
import { DOMException } from "Fidelity.CloudEdge.Worker.Context";
DOMException.INDEX_SIZE_ERR"""
    static member inline DOMSTRING_SIZE_ERR
        with get () : float =
            emitJsExpr () $$"""
import { DOMException } from "Fidelity.CloudEdge.Worker.Context";
DOMException.DOMSTRING_SIZE_ERR"""
    static member inline HIERARCHY_REQUEST_ERR
        with get () : float =
            emitJsExpr () $$"""
import { DOMException } from "Fidelity.CloudEdge.Worker.Context";
DOMException.HIERARCHY_REQUEST_ERR"""
    static member inline WRONG_DOCUMENT_ERR
        with get () : float =
            emitJsExpr () $$"""
import { DOMException } from "Fidelity.CloudEdge.Worker.Context";
DOMException.WRONG_DOCUMENT_ERR"""
    static member inline INVALID_CHARACTER_ERR
        with get () : float =
            emitJsExpr () $$"""
import { DOMException } from "Fidelity.CloudEdge.Worker.Context";
DOMException.INVALID_CHARACTER_ERR"""
    static member inline NO_DATA_ALLOWED_ERR
        with get () : float =
            emitJsExpr () $$"""
import { DOMException } from "Fidelity.CloudEdge.Worker.Context";
DOMException.NO_DATA_ALLOWED_ERR"""
    static member inline NO_MODIFICATION_ALLOWED_ERR
        with get () : float =
            emitJsExpr () $$"""
import { DOMException } from "Fidelity.CloudEdge.Worker.Context";
DOMException.NO_MODIFICATION_ALLOWED_ERR"""
    static member inline NOT_FOUND_ERR
        with get () : float =
            emitJsExpr () $$"""
import { DOMException } from "Fidelity.CloudEdge.Worker.Context";
DOMException.NOT_FOUND_ERR"""
    static member inline NOT_SUPPORTED_ERR
        with get () : float =
            emitJsExpr () $$"""
import { DOMException } from "Fidelity.CloudEdge.Worker.Context";
DOMException.NOT_SUPPORTED_ERR"""
    static member inline INUSE_ATTRIBUTE_ERR
        with get () : float =
            emitJsExpr () $$"""
import { DOMException } from "Fidelity.CloudEdge.Worker.Context";
DOMException.INUSE_ATTRIBUTE_ERR"""
    static member inline INVALID_STATE_ERR
        with get () : float =
            emitJsExpr () $$"""
import { DOMException } from "Fidelity.CloudEdge.Worker.Context";
DOMException.INVALID_STATE_ERR"""
    static member inline SYNTAX_ERR
        with get () : float =
            emitJsExpr () $$"""
import { DOMException } from "Fidelity.CloudEdge.Worker.Context";
DOMException.SYNTAX_ERR"""
    static member inline INVALID_MODIFICATION_ERR
        with get () : float =
            emitJsExpr () $$"""
import { DOMException } from "Fidelity.CloudEdge.Worker.Context";
DOMException.INVALID_MODIFICATION_ERR"""
    static member inline NAMESPACE_ERR
        with get () : float =
            emitJsExpr () $$"""
import { DOMException } from "Fidelity.CloudEdge.Worker.Context";
DOMException.NAMESPACE_ERR"""
    static member inline INVALID_ACCESS_ERR
        with get () : float =
            emitJsExpr () $$"""
import { DOMException } from "Fidelity.CloudEdge.Worker.Context";
DOMException.INVALID_ACCESS_ERR"""
    static member inline VALIDATION_ERR
        with get () : float =
            emitJsExpr () $$"""
import { DOMException } from "Fidelity.CloudEdge.Worker.Context";
DOMException.VALIDATION_ERR"""
    static member inline TYPE_MISMATCH_ERR
        with get () : float =
            emitJsExpr () $$"""
import { DOMException } from "Fidelity.CloudEdge.Worker.Context";
DOMException.TYPE_MISMATCH_ERR"""
    static member inline SECURITY_ERR
        with get () : float =
            emitJsExpr () $$"""
import { DOMException } from "Fidelity.CloudEdge.Worker.Context";
DOMException.SECURITY_ERR"""
    static member inline NETWORK_ERR
        with get () : float =
            emitJsExpr () $$"""
import { DOMException } from "Fidelity.CloudEdge.Worker.Context";
DOMException.NETWORK_ERR"""
    static member inline ABORT_ERR
        with get () : float =
            emitJsExpr () $$"""
import { DOMException } from "Fidelity.CloudEdge.Worker.Context";
DOMException.ABORT_ERR"""
    static member inline URL_MISMATCH_ERR
        with get () : float =
            emitJsExpr () $$"""
import { DOMException } from "Fidelity.CloudEdge.Worker.Context";
DOMException.URL_MISMATCH_ERR"""
    static member inline QUOTA_EXCEEDED_ERR
        with get () : float =
            emitJsExpr () $$"""
import { DOMException } from "Fidelity.CloudEdge.Worker.Context";
DOMException.QUOTA_EXCEEDED_ERR"""
    static member inline TIMEOUT_ERR
        with get () : float =
            emitJsExpr () $$"""
import { DOMException } from "Fidelity.CloudEdge.Worker.Context";
DOMException.TIMEOUT_ERR"""
    static member inline INVALID_NODE_TYPE_ERR
        with get () : float =
            emitJsExpr () $$"""
import { DOMException } from "Fidelity.CloudEdge.Worker.Context";
DOMException.INVALID_NODE_TYPE_ERR"""
    static member inline DATA_CLONE_ERR
        with get () : float =
            emitJsExpr () $$"""
import { DOMException } from "Fidelity.CloudEdge.Worker.Context";
DOMException.DATA_CLONE_ERR"""
    abstract member stack: obj with get, set

[<AllowNullLiteral>]
[<Interface>]
type WorkerGlobalScopeEventMap =
    abstract member fetch: FetchEvent with get, set
    abstract member scheduled: ScheduledEvent with get, set
    abstract member queue: QueueEvent with get, set
    abstract member unhandledrejection: PromiseRejectionEvent with get, set
    abstract member rejectionhandled: PromiseRejectionEvent with get, set

[<AllowNullLiteral>]
[<Interface>]
type WorkerGlobalScope =
    inherit EventTarget<WorkerGlobalScopeEventMap>
    abstract member EventTarget: WorkerGlobalScope.EventTarget with get, set

[<AllowNullLiteral>]
[<Interface>]
type Console =
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/console/assert)
    /// <c>console.assert()</c> writes a message if <c>value</c> is [falsy](https://developer.mozilla.org/en-US/docs/Glossary/Falsy) or omitted. It only
    /// writes a message and does not otherwise affect execution. The output always
    /// starts with <c>"Assertion failed"</c>. If provided, <c>message</c> is formatted using
    /// [<c>util.format()</c>](https://nodejs.org/docs/latest-v22.x/api/util.html#utilformatformat-args).
    ///
    /// If <c>value</c> is [truthy](https://developer.mozilla.org/en-US/docs/Glossary/Truthy), nothing happens.
    ///
    /// <code lang="js">
    /// console.assert(true, 'does nothing');
    ///
    /// console.assert(false, 'Whoops %s work', 'didn\'t');
    /// // Assertion failed: Whoops didn't work
    ///
    /// console.assert();
    /// // Assertion failed
    /// </code>
    /// </summary>
    abstract member ``assert``: ?condition: bool * [<ParamArray>] data: obj [] -> unit
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/console/clear)
    /// The **<c>console.clear()</c>** static method clears the console if possible.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/console/clear_static)
    /// When <c>stdout</c> is a TTY, calling <c>console.clear()</c> will attempt to clear the
    /// TTY. When <c>stdout</c> is not a TTY, this method does nothing.
    ///
    /// The specific operation of <c>console.clear()</c> can vary across operating systems
    /// and terminal types. For most Linux operating systems, <c>console.clear()</c> operates similarly to the <c>clear</c> shell command. On Windows, <c>console.clear()</c> will clear only the output in the
    /// current terminal viewport for the Node.js
    /// binary.
    /// </summary>
    abstract member clear: unit -> unit
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/console/count)
    /// The **<c>console.count()</c>** static method logs the number of times that this particular call to <c>count()</c> has been called.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/console/count_static)
    /// Maintains an internal counter specific to <c>label</c> and outputs to <c>stdout</c> the
    /// number of times <c>console.count()</c> has been called with the given <c>label</c>.
    ///
    /// <code lang="js">
    /// > console.count()
    /// default: 1
    /// undefined
    /// > console.count('default')
    /// default: 2
    /// undefined
    /// > console.count('abc')
    /// abc: 1
    /// undefined
    /// > console.count('xyz')
    /// xyz: 1
    /// undefined
    /// > console.count('abc')
    /// abc: 2
    /// undefined
    /// > console.count()
    /// default: 3
    /// undefined
    /// >
    /// </code>
    /// </summary>
    abstract member count: ?label: string -> unit
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/console/countReset)
    /// The **<c>console.countReset()</c>** static method resets counter used with console/count_static.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/console/countReset_static)
    /// Resets the internal counter specific to <c>label</c>.
    ///
    /// <code lang="js">
    /// > console.count('abc');
    /// abc: 1
    /// undefined
    /// > console.countReset('abc');
    /// undefined
    /// > console.count('abc');
    /// abc: 1
    /// undefined
    /// >
    /// </code>
    /// </summary>
    abstract member countReset: ?label: string -> unit
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/console/debug)
    /// The **<c>console.debug()</c>** static method outputs a message to the console at the 'debug' log level.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/console/debug_static)
    /// The <c>console.debug()</c> function is an alias for <see href="log">log</see>.
    /// </summary>
    abstract member debug: [<ParamArray>] data: obj [] -> unit
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/console/dir)
    /// The **<c>console.dir()</c>** static method displays a list of the properties of the specified JavaScript object.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/console/dir_static)
    /// Uses [<c>util.inspect()</c>](https://nodejs.org/docs/latest-v22.x/api/util.html#utilinspectobject-options) on <c>obj</c> and prints the resulting string to <c>stdout</c>.
    /// This function bypasses any custom <c>inspect()</c> function defined on <c>obj</c>.
    /// </summary>
    abstract member dir: ?item: obj * ?options: obj -> unit
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/console/dirxml)
    /// The **<c>console.dirxml()</c>** static method displays an interactive tree of the descendant elements of the specified XML/HTML element.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/console/dirxml_static)
    /// This method calls <c>console.log()</c> passing it the arguments received.
    /// This method does not produce any XML formatting.
    /// </summary>
    abstract member dirxml: [<ParamArray>] data: obj [] -> unit
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/console/error)
    /// The **<c>console.error()</c>** static method outputs a message to the console at the 'error' log level.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/console/error_static)
    /// Prints to <c>stderr</c> with newline. Multiple arguments can be passed, with the
    /// first used as the primary message and all additional used as substitution
    /// values similar to [<c>printf(3)</c>](http://man7.org/linux/man-pages/man3/printf.3.html)
    /// (the arguments are all passed to [<c>util.format()</c>](https://nodejs.org/docs/latest-v22.x/api/util.html#utilformatformat-args)).
    ///
    /// <code lang="js">
    /// const code = 5;
    /// console.error('error #%d', code);
    /// // Prints: error #5, to stderr
    /// console.error('error', code);
    /// // Prints: error 5, to stderr
    /// </code>
    ///
    /// If formatting elements (e.g. <c>%d</c>) are not found in the first string then
    /// [<c>util.inspect()</c>](https://nodejs.org/docs/latest-v22.x/api/util.html#utilinspectobject-options) is called on each argument and the
    /// resulting string values are concatenated. See [<c>util.format()</c>](https://nodejs.org/docs/latest-v22.x/api/util.html#utilformatformat-args)
    /// for more information.
    /// </summary>
    abstract member error: [<ParamArray>] data: obj [] -> unit
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/console/group)
    /// The **<c>console.group()</c>** static method creates a new inline group in the Web console log, causing any subsequent console messages to be indented by an additional level, until console/groupEnd_static is called.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/console/group_static)
    /// Increases indentation of subsequent lines by spaces for <c>groupIndentation</c> length.
    ///
    /// If one or more <c>label</c>s are provided, those are printed first without the
    /// additional indentation.
    /// </summary>
    abstract member group: [<ParamArray>] data: obj [] -> unit
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/console/groupCollapsed)
    /// The **<c>console.groupCollapsed()</c>** static method creates a new inline group in the console.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/console/groupCollapsed_static)
    /// An alias for <see href="group">group</see>.
    /// </summary>
    abstract member groupCollapsed: [<ParamArray>] data: obj [] -> unit
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/console/groupEnd)
    /// The **<c>console.groupEnd()</c>** static method exits the current inline group in the console.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/console/groupEnd_static)
    /// Decreases indentation of subsequent lines by spaces for <c>groupIndentation</c> length.
    /// </summary>
    abstract member groupEnd: unit -> unit
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/console/info)
    /// The **<c>console.info()</c>** static method outputs a message to the console at the 'info' log level.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/console/info_static)
    /// The <c>console.info()</c> function is an alias for <see href="log">log</see>.
    /// </summary>
    abstract member info: [<ParamArray>] data: obj [] -> unit
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/console/log)
    /// The **<c>console.log()</c>** static method outputs a message to the console.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/console/log_static)
    /// Prints to <c>stdout</c> with newline. Multiple arguments can be passed, with the
    /// first used as the primary message and all additional used as substitution
    /// values similar to [<c>printf(3)</c>](http://man7.org/linux/man-pages/man3/printf.3.html)
    /// (the arguments are all passed to [<c>util.format()</c>](https://nodejs.org/docs/latest-v22.x/api/util.html#utilformatformat-args)).
    ///
    /// <code lang="js">
    /// const count = 5;
    /// console.log('count: %d', count);
    /// // Prints: count: 5, to stdout
    /// console.log('count:', count);
    /// // Prints: count: 5, to stdout
    /// </code>
    ///
    /// See [<c>util.format()</c>](https://nodejs.org/docs/latest-v22.x/api/util.html#utilformatformat-args) for more information.
    /// </summary>
    abstract member log: [<ParamArray>] data: obj [] -> unit
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/console/table)
    /// The **<c>console.table()</c>** static method displays tabular data as a table.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/console/table_static)
    /// Try to construct a table with the columns of the properties of <c>tabularData</c> (or use <c>properties</c>) and rows of <c>tabularData</c> and log it. Falls back to just
    /// logging the argument if it can't be parsed as tabular.
    ///
    /// <code lang="js">
    /// // These can't be parsed as tabular data
    /// console.table(Symbol());
    /// // Symbol()
    ///
    /// console.table(undefined);
    /// // undefined
    ///
    /// console.table([{ a: 1, b: 'Y' }, { a: 'Z', b: 2 }]);
    /// // ┌─────────┬─────┬─────┐
    /// // │ (index) │  a  │  b  │
    /// // ├─────────┼─────┼─────┤
    /// // │    0    │  1  │ 'Y' │
    /// // │    1    │ 'Z' │  2  │
    /// // └─────────┴─────┴─────┘
    ///
    /// console.table([{ a: 1, b: 'Y' }, { a: 'Z', b: 2 }], ['a']);
    /// // ┌─────────┬─────┐
    /// // │ (index) │  a  │
    /// // ├─────────┼─────┤
    /// // │    0    │  1  │
    /// // │    1    │ 'Z' │
    /// // └─────────┴─────┘
    /// </code>
    /// </summary>
    abstract member table: ?tabularData: obj * ?properties: ResizeArray<string> -> unit
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/console/time)
    /// The **<c>console.time()</c>** static method starts a timer you can use to track how long an operation takes.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/console/time_static)
    /// Starts a timer that can be used to compute the duration of an operation. Timers
    /// are identified by a unique <c>label</c>. Use the same <c>label</c> when calling <see href="timeEnd">timeEnd</see> to stop the timer and output the elapsed time in
    /// suitable time units to <c>stdout</c>. For example, if the elapsed
    /// time is 3869ms, <c>console.timeEnd()</c> displays "3.869s".
    /// </summary>
    abstract member time: ?label: string -> unit
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/console/timeEnd)
    /// The **<c>console.timeEnd()</c>** static method stops a timer that was previously started by calling console/time_static.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/console/timeEnd_static)
    /// Stops a timer that was previously started by calling <see href="time">time</see> and
    /// prints the result to <c>stdout</c>:
    ///
    /// <code lang="js">
    /// console.time('bunch-of-stuff');
    /// // Do a bunch of stuff.
    /// console.timeEnd('bunch-of-stuff');
    /// // Prints: bunch-of-stuff: 225.438ms
    /// </code>
    /// </summary>
    abstract member timeEnd: ?label: string -> unit
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/console/timeLog)
    /// The **<c>console.timeLog()</c>** static method logs the current value of a timer that was previously started by calling console/time_static.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/console/timeLog_static)
    /// For a timer that was previously started by calling <see href="time">time</see>, prints
    /// the elapsed time and other <c>data</c> arguments to <c>stdout</c>:
    ///
    /// <code lang="js">
    /// console.time('process');
    /// const value = expensiveProcess1(); // Returns 42
    /// console.timeLog('process', value);
    /// // Prints "process: 365.227ms 42".
    /// doExpensiveProcess2(value);
    /// console.timeEnd('process');
    /// </code>
    /// </summary>
    abstract member timeLog: ?label: string * [<ParamArray>] data: obj [] -> unit
    /// <summary>
    /// This method does not display anything unless used in the inspector. The <c>console.timeStamp()</c>
    /// method adds an event with the label <c>'label'</c> to the Timeline panel of the inspector.
    /// </summary>
    abstract member timeStamp: ?label: string -> unit
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/console/trace)
    /// The **<c>console.trace()</c>** static method outputs a stack trace to the console.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/console/trace_static)
    /// Prints to <c>stderr</c> the string <c>'Trace: '</c>, followed by the [<c>util.format()</c>](https://nodejs.org/docs/latest-v22.x/api/util.html#utilformatformat-args)
    /// formatted message and stack trace to the current position in the code.
    ///
    /// <code lang="js">
    /// console.trace('Show me');
    /// // Prints: (stack trace will vary based on where trace is called)
    /// //  Trace: Show me
    /// //    at repl:2:9
    /// //    at REPLServer.defaultEval (repl.js:248:27)
    /// //    at bound (domain.js:287:14)
    /// //    at REPLServer.runBound [as eval] (domain.js:300:12)
    /// //    at REPLServer.<anonymous> (repl.js:412:12)
    /// //    at emitOne (events.js:82:20)
    /// //    at REPLServer.emit (events.js:169:7)
    /// //    at REPLServer.Interface._onLine (readline.js:210:10)
    /// //    at REPLServer.Interface._line (readline.js:549:8)
    /// //    at REPLServer.Interface._ttyWrite (readline.js:826:14)
    /// </code>
    /// </summary>
    abstract member trace: [<ParamArray>] data: obj [] -> unit
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/console/warn)
    /// The **<c>console.warn()</c>** static method outputs a warning message to the console at the 'warning' log level.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/console/warn_static)
    /// The <c>console.warn()</c> function is an alias for <see href="error">error</see>.
    /// </summary>
    abstract member warn: [<ParamArray>] data: obj [] -> unit


type BufferSource =
    U2<ArrayBufferView, ArrayBuffer>

type TypedArray =
    U11<JS.Int8Array, JS.Uint8Array, JS.Uint8ClampedArray, JS.Int16Array, JS.Uint16Array, JS.Int32Array, JS.Uint32Array, JS.Float32Array, JS.Float64Array, BigInt64Array, BigUint64Array>

module WebAssembly_ =

    [<AbstractClass>]
    [<Erase>]
    type Exports =
        [<Emit("$0.instantiate($1...)")>]
        abstract member instantiate: ``module``: Module * ?imports: Imports -> JS.Promise<Instance>
        [<Emit("$0.validate($1...)")>]
        abstract member validate: bytes: BufferSource -> bool
        [<Emit("new $0.CompileError($1...)")>]
        abstract member CompileError: ?message: string -> CompileError
        [<Emit("new $0.RuntimeError($1...)")>]
        abstract member RuntimeError: ?message: string -> RuntimeError
        [<Emit("new $0.Global($1...)")>]
        abstract member Global: descriptor: GlobalDescriptor * ?value: obj -> Global
        [<Emit("new $0.Instance($1...)")>]
        abstract member Instance: ``module``: Module * ?imports: Imports -> Instance
        [<Emit("new $0.Memory($1...)")>]
        abstract member Memory: descriptor: MemoryDescriptor -> Memory
        [<Emit("new $0.Module($1...)")>]
        abstract member Module: unit -> Module
        [<Emit("new $0.Table($1...)")>]
        abstract member Table: descriptor: TableDescriptor * ?value: obj -> Table
        [<EmitIndexer>]
        abstract member Item: key: string -> ExportValue with get, set

    [<AllowNullLiteral>]
    [<AbstractClass>]
    type CompileError =
        inherit Exception

    [<AllowNullLiteral>]
    [<AbstractClass>]
    type RuntimeError =
        inherit Exception

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type ValueType =
        | anyfunc
        | externref
        | f32
        | f64
        | i32
        | i64
        | v128

    [<AllowNullLiteral>]
    [<Interface>]
    type GlobalDescriptor =
        abstract member value: ValueType with get, set
        abstract member ``mutable``: bool option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type Global =
        abstract member value: obj with get, set
        abstract member valueOf: unit -> obj

    type ImportValue =
        U2<ExportValue, float>

    [<AllowNullLiteral>]
    [<Interface>]
    type ModuleImports =
        [<EmitIndexer>]
        abstract member Item: key: string -> ImportValue with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type Imports =
        [<EmitIndexer>]
        abstract member Item: key: string -> ModuleImports with get, set

    type ExportValue =
        U4<Action, Global, Memory, Table>

    [<AllowNullLiteral>]
    [<Interface>]
    type Instance =
        abstract member exports: Exports with get

    [<AllowNullLiteral>]
    [<Interface>]
    type MemoryDescriptor =
        abstract member initial: float with get, set
        abstract member maximum: float option with get, set
        abstract member shared: bool option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type Memory =
        abstract member buffer: ArrayBuffer with get
        abstract member grow: delta: float -> float

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type ImportExportKind =
        | ``function``
        | ``global``
        | memory
        | table

    [<AllowNullLiteral>]
    [<Interface>]
    type ModuleExportDescriptor =
        abstract member kind: ImportExportKind with get, set
        abstract member name: string with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type ModuleImportDescriptor =
        abstract member kind: ImportExportKind with get, set
        abstract member ``module``: string with get, set
        abstract member name: string with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type Module =
        static member inline customSections (``module``: Module, sectionName: string): ResizeArray<ArrayBuffer> =
            emitJsExpr (``module``, sectionName) $$"""
import { Module } from "Fidelity.CloudEdge.Worker.Context";
Module.customSections($0, $1)"""
        static member inline exports (``module``: Module): ResizeArray<ModuleExportDescriptor> =
            emitJsExpr (``module``) $$"""
import { Module } from "Fidelity.CloudEdge.Worker.Context";
Module.exports($0)"""
        static member inline imports (``module``: Module): ResizeArray<ModuleImportDescriptor> =
            emitJsExpr (``module``) $$"""
import { Module } from "Fidelity.CloudEdge.Worker.Context";
Module.imports($0)"""

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type TableKind =
        | anyfunc
        | externref

    [<AllowNullLiteral>]
    [<Interface>]
    type TableDescriptor =
        abstract member element: TableKind with get, set
        abstract member initial: float with get, set
        abstract member maximum: float option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type Table =
        abstract member length: float with get
        abstract member get: index: float -> obj
        abstract member grow: delta: float * ?value: obj -> float
        abstract member set: index: float * ?value: obj -> unit

[<AllowNullLiteral>]
[<Interface>]
type ServiceWorkerGlobalScope =
    inherit WorkerGlobalScope
    abstract member DOMException: ServiceWorkerGlobalScope.DOMException with get, set
    abstract member WorkerGlobalScope: WorkerGlobalScope with get, set
    abstract member btoa: data: string -> string
    abstract member atob: data: string -> string
    abstract member setTimeout: callback: System.Delegate * ?msDelay: float -> float
    abstract member setTimeout: callback: System.Delegate * ?msDelay: float * [<ParamArray>] args: 'Args [] -> float
    abstract member clearTimeout: timeoutId: U2<float, obj> -> unit
    abstract member setInterval: callback: System.Delegate * ?msDelay: float -> float
    abstract member setInterval: callback: System.Delegate * ?msDelay: float * [<ParamArray>] args: 'Args [] -> float
    abstract member clearInterval: timeoutId: U2<float, obj> -> unit
    abstract member queueMicrotask: task: Action -> unit
    abstract member structuredClone: value: 'T * ?options: StructuredSerializeOptions -> 'T
    abstract member reportError: error: obj -> unit
    abstract member fetch: input: U2<RequestInfo, URL> * ?init: RequestInit<RequestInitCfProperties> -> JS.Promise<Response>
    abstract member self: ServiceWorkerGlobalScope with get, set
    abstract member crypto: Crypto with get, set
    abstract member caches: CacheStorage with get, set
    abstract member scheduler: Scheduler with get, set
    abstract member performance: Performance with get, set
    abstract member Cloudflare: Cloudflare with get, set
    abstract member origin: string with get
    abstract member Event: ServiceWorkerGlobalScope.Event with get, set
    abstract member ExtendableEvent: ExtendableEvent with get, set
    abstract member CustomEvent: ServiceWorkerGlobalScope.CustomEvent with get, set
    abstract member PromiseRejectionEvent: ServiceWorkerGlobalScope.PromiseRejectionEvent with get, set
    abstract member FetchEvent: FetchEvent with get, set
    abstract member TailEvent: TailEvent with get, set
    abstract member TraceEvent: TailEvent with get, set
    abstract member ScheduledEvent: ScheduledEvent with get, set
    abstract member MessageEvent: ServiceWorkerGlobalScope.MessageEvent with get, set
    abstract member CloseEvent: ServiceWorkerGlobalScope.CloseEvent with get, set
    abstract member ReadableStreamDefaultReader: ServiceWorkerGlobalScope.ReadableStreamDefaultReader with get, set
    abstract member ReadableStreamBYOBReader: ServiceWorkerGlobalScope.ReadableStreamBYOBReader with get, set
    abstract member ReadableStream: ServiceWorkerGlobalScope.ReadableStream with get, set
    abstract member WritableStream: ServiceWorkerGlobalScope.WritableStream with get, set
    abstract member WritableStreamDefaultWriter: ServiceWorkerGlobalScope.WritableStreamDefaultWriter with get, set
    abstract member TransformStream: ServiceWorkerGlobalScope.TransformStream with get, set
    abstract member ByteLengthQueuingStrategy: ServiceWorkerGlobalScope.ByteLengthQueuingStrategy with get, set
    abstract member CountQueuingStrategy: ServiceWorkerGlobalScope.CountQueuingStrategy with get, set
    abstract member ErrorEvent: ServiceWorkerGlobalScope.ErrorEvent with get, set
    abstract member EventSource: ServiceWorkerGlobalScope.EventSource with get, set
    abstract member CompressionStream: ServiceWorkerGlobalScope.CompressionStream with get, set
    abstract member DecompressionStream: ServiceWorkerGlobalScope.DecompressionStream with get, set
    abstract member TextEncoderStream: ServiceWorkerGlobalScope.TextEncoderStream with get, set
    abstract member TextDecoderStream: ServiceWorkerGlobalScope.TextDecoderStream with get, set
    abstract member Headers: ServiceWorkerGlobalScope.Headers with get, set
    abstract member Body: Body with get, set
    abstract member Request: ServiceWorkerGlobalScope.Request with get, set
    abstract member Response: ServiceWorkerGlobalScope.Response with get, set
    abstract member WebSocket: ServiceWorkerGlobalScope.WebSocket with get, set
    abstract member WebSocketPair: ServiceWorkerGlobalScope.WebSocketPair with get, set
    abstract member WebSocketRequestResponsePair: WebSocketRequestResponsePair with get, set
    abstract member AbortController: ServiceWorkerGlobalScope.AbortController with get, set
    abstract member AbortSignal: ServiceWorkerGlobalScope.AbortSignal with get, set
    abstract member TextDecoder: ServiceWorkerGlobalScope.TextDecoder with get, set
    abstract member TextEncoder: ServiceWorkerGlobalScope.TextEncoder with get, set
    abstract member URL: ServiceWorkerGlobalScope.URL with get, set
    abstract member URLSearchParams: ServiceWorkerGlobalScope.URLSearchParams with get, set
    abstract member URLPattern: URLPattern with get, set
    abstract member Blob: ServiceWorkerGlobalScope.Blob with get, set
    abstract member File: ServiceWorkerGlobalScope.File with get, set
    abstract member FormData: ServiceWorkerGlobalScope.FormData with get, set
    abstract member Crypto: ServiceWorkerGlobalScope.Crypto with get, set
    abstract member SubtleCrypto: ServiceWorkerGlobalScope.SubtleCrypto with get, set
    abstract member CryptoKey: ServiceWorkerGlobalScope.CryptoKey with get, set
    abstract member CacheStorage: ServiceWorkerGlobalScope.CacheStorage with get, set
    abstract member Cache: ServiceWorkerGlobalScope.Cache with get, set
    abstract member FixedLengthStream: FixedLengthStream with get, set
    abstract member IdentityTransformStream: IdentityTransformStream with get, set
    abstract member HTMLRewriter: HTMLRewriter with get, set








[<AllowNullLiteral>]
[<Interface>]
type TestController =
    interface end

[<AllowNullLiteral>]
[<Interface>]
type ExecutionContext<'Props> =
    abstract member waitUntil: promise: JS.Promise<obj> -> unit
    abstract member passThroughOnException: unit -> unit
    abstract member props: 'Props with get

[<AllowNullLiteral>]
[<Interface>]
type ExportedHandlerFetchHandler<'Env, 'CfHostMetadata> =
    [<Emit("$0($1...)")>]
    abstract member Invoke: request: Request<'CfHostMetadata, IncomingRequestCfProperties<'CfHostMetadata>> * env: 'Env * ctx: ExecutionContext -> U2<Response, JS.Promise<Response>>

[<AllowNullLiteral>]
[<Interface>]
type ExportedHandlerTailHandler<'Env> =
    [<Emit("$0($1...)")>]
    abstract member Invoke: events: ResizeArray<TraceItem> * env: 'Env * ctx: ExecutionContext -> U2<unit, JS.Promise<unit>>

[<AllowNullLiteral>]
[<Interface>]
type ExportedHandlerTraceHandler<'Env> =
    [<Emit("$0($1...)")>]
    abstract member Invoke: traces: ResizeArray<TraceItem> * env: 'Env * ctx: ExecutionContext -> U2<unit, JS.Promise<unit>>

[<AllowNullLiteral>]
[<Interface>]
type ExportedHandlerTailStreamHandler<'Env> =
    [<Emit("$0($1...)")>]
    abstract member Invoke: event: TailStream.TailEvent<TailStream.Onset> * env: 'Env * ctx: ExecutionContext -> U2<TailStream.TailEventHandlerType, JS.Promise<TailStream.TailEventHandlerType>>

[<AllowNullLiteral>]
[<Interface>]
type ExportedHandlerScheduledHandler<'Env> =
    [<Emit("$0($1...)")>]
    abstract member Invoke: controller: ScheduledController * env: 'Env * ctx: ExecutionContext -> U2<unit, JS.Promise<unit>>

[<AllowNullLiteral>]
[<Interface>]
type ExportedHandlerQueueHandler<'Env, 'Message> =
    [<Emit("$0($1...)")>]
    abstract member Invoke: batch: MessageBatch<'Message> * env: 'Env * ctx: ExecutionContext -> U2<unit, JS.Promise<unit>>

[<AllowNullLiteral>]
[<Interface>]
type ExportedHandlerTestHandler<'Env> =
    [<Emit("$0($1...)")>]
    abstract member Invoke: controller: TestController * env: 'Env * ctx: ExecutionContext -> U2<unit, JS.Promise<unit>>

[<AllowNullLiteral>]
[<Interface>]
type ExportedHandler<'Env, 'QueueHandlerMessage, 'CfHostMetadata> =
    abstract member fetch: ExportedHandlerFetchHandler<'Env, 'CfHostMetadata> option with get, set
    abstract member tail: ExportedHandlerTailHandler<'Env> option with get, set
    abstract member trace: ExportedHandlerTraceHandler<'Env> option with get, set
    abstract member tailStream: ExportedHandlerTailStreamHandler<'Env> option with get, set
    abstract member scheduled: ExportedHandlerScheduledHandler<'Env> option with get, set
    abstract member test: ExportedHandlerTestHandler<'Env> option with get, set
    abstract member email: EmailExportedHandler<'Env> option with get, set
    abstract member queue: ExportedHandlerQueueHandler<'Env, 'QueueHandlerMessage> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type StructuredSerializeOptions =
    abstract member transfer: ResizeArray<obj> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type AlarmInvocationInfo =
    abstract member isRetry: bool with get
    abstract member retryCount: float with get

[<AllowNullLiteral>]
[<Interface>]
type Cloudflare =
    abstract member compatibilityFlags: Cloudflare.compatibilityFlags with get

[<AllowNullLiteral>]
[<Interface>]
type DurableObject =
    abstract member fetch: request: Request -> U2<Response, JS.Promise<Response>>
    abstract member alarm: ?alarmInfo: AlarmInvocationInfo -> U2<unit, JS.Promise<unit>>
    abstract member webSocketMessage: ws: WebSocket * message: U2<string, ArrayBuffer> -> U2<unit, JS.Promise<unit>>
    abstract member webSocketClose: ws: WebSocket * code: float * reason: string * wasClean: bool -> U2<unit, JS.Promise<unit>>
    abstract member webSocketError: ws: WebSocket * error: obj -> U2<unit, JS.Promise<unit>>

[<AllowNullLiteral>]
[<Interface>]
type DurableObjectStub<'T when 'T :> Rpc.DurableObjectBranded option> =
    abstract member [__DURABLE_OBJECT_BRAND]: obj with get, set
    abstract member fetch: input: U2<RequestInfo, URL> * ?init: RequestInit -> JS.Promise<Response>
    abstract member connect: address: U2<SocketAddress, string> * ?options: SocketOptions -> Socket
    abstract member id: DurableObjectId with get
    abstract member name: string option with get

[<AllowNullLiteral>]
[<Interface>]
type DurableObjectId =
    abstract member toString: unit -> string
    abstract member equals: other: DurableObjectId -> bool
    abstract member name: string option with get

[<AllowNullLiteral>]
[<Interface>]
type DurableObjectNamespace<'T when 'T :> Rpc.DurableObjectBranded option> =
    abstract member newUniqueId: ?options: DurableObjectNamespaceNewUniqueIdOptions -> DurableObjectId
    abstract member idFromName: name: string -> DurableObjectId
    abstract member idFromString: id: string -> DurableObjectId
    abstract member get: id: DurableObjectId * ?options: DurableObjectNamespaceGetDurableObjectOptions -> DurableObjectStub<'T>
    abstract member getByName: name: string * ?options: DurableObjectNamespaceGetDurableObjectOptions -> DurableObjectStub<'T>
    abstract member jurisdiction: jurisdiction: DurableObjectJurisdiction -> DurableObjectNamespace<'T>

type DurableObjectNamespace =
    DurableObjectNamespace<obj>

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type DurableObjectJurisdiction =
    | eu
    | fedramp
    | ``fedramp-high``

[<AllowNullLiteral>]
[<Interface>]
type DurableObjectNamespaceNewUniqueIdOptions =
    abstract member jurisdiction: DurableObjectJurisdiction option with get, set

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type DurableObjectLocationHint =
    | wnam
    | enam
    | sam
    | weur
    | eeur
    | apac
    | oc
    | afr
    | me

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type DurableObjectRoutingMode =
    | ``primary-only``

[<AllowNullLiteral>]
[<Interface>]
type DurableObjectNamespaceGetDurableObjectOptions =
    abstract member locationHint: DurableObjectLocationHint option with get, set
    abstract member routingMode: DurableObjectRoutingMode option with get, set

[<AllowNullLiteral>]
[<Interface>]
type DurableObjectClass<'_T when '_T :> Rpc.DurableObjectBranded option> =
    interface end

[<AllowNullLiteral>]
[<Interface>]
type DurableObjectState<'Props> =
    abstract member waitUntil: promise: JS.Promise<obj> -> unit
    abstract member props: 'Props with get
    abstract member id: DurableObjectId with get
    abstract member storage: DurableObjectStorage with get
    abstract member container: Container option with get, set
    abstract member blockConcurrencyWhile: callback: (unit -> JS.Promise<'T>) -> JS.Promise<'T>
    abstract member acceptWebSocket: ws: WebSocket * ?tags: ResizeArray<string> -> unit
    abstract member getWebSockets: ?tag: string -> ResizeArray<WebSocket>
    abstract member setWebSocketAutoResponse: ?maybeReqResp: WebSocketRequestResponsePair -> unit
    abstract member getWebSocketAutoResponse: unit -> U2<WebSocketRequestResponsePair, obj>
    abstract member getWebSocketAutoResponseTimestamp: ws: WebSocket -> U2<JS.Date, obj>
    abstract member setHibernatableWebSocketEventTimeout: ?timeoutMs: float -> unit
    abstract member getHibernatableWebSocketEventTimeout: unit -> U2<float, obj>
    abstract member getTags: ws: WebSocket -> ResizeArray<string>
    abstract member abort: ?reason: string -> unit

[<AllowNullLiteral>]
[<Interface>]
type DurableObjectTransaction =
    abstract member get: key: string * ?options: DurableObjectGetOptions -> JS.Promise<'T option>
    abstract member get: keys: ResizeArray<string> * ?options: DurableObjectGetOptions -> JS.Promise<Map<string, 'T>>
    abstract member list: ?options: DurableObjectListOptions -> JS.Promise<Map<string, 'T>>
    abstract member put: key: string * value: 'T * ?options: DurableObjectPutOptions -> JS.Promise<unit>
    abstract member put: entries: DurableObjectTransaction.put.entries * ?options: DurableObjectPutOptions -> JS.Promise<unit>
    abstract member delete: key: string * ?options: DurableObjectPutOptions -> JS.Promise<bool>
    abstract member delete: keys: ResizeArray<string> * ?options: DurableObjectPutOptions -> JS.Promise<float>
    abstract member rollback: unit -> unit
    abstract member getAlarm: ?options: DurableObjectGetAlarmOptions -> JS.Promise<U2<float, obj>>
    abstract member setAlarm: scheduledTime: U2<float, JS.Date> * ?options: DurableObjectSetAlarmOptions -> JS.Promise<unit>
    abstract member deleteAlarm: ?options: DurableObjectSetAlarmOptions -> JS.Promise<unit>

[<AllowNullLiteral>]
[<Interface>]
type DurableObjectStorage =
    abstract member get: key: string * ?options: DurableObjectGetOptions -> JS.Promise<'T option>
    abstract member get: keys: ResizeArray<string> * ?options: DurableObjectGetOptions -> JS.Promise<Map<string, 'T>>
    abstract member list: ?options: DurableObjectListOptions -> JS.Promise<Map<string, 'T>>
    abstract member put: key: string * value: 'T * ?options: DurableObjectPutOptions -> JS.Promise<unit>
    abstract member put: entries: DurableObjectStorage.put.entries * ?options: DurableObjectPutOptions -> JS.Promise<unit>
    abstract member delete: key: string * ?options: DurableObjectPutOptions -> JS.Promise<bool>
    abstract member delete: keys: ResizeArray<string> * ?options: DurableObjectPutOptions -> JS.Promise<float>
    abstract member deleteAll: ?options: DurableObjectPutOptions -> JS.Promise<unit>
    abstract member transaction: closure: (DurableObjectTransaction -> JS.Promise<'T>) -> JS.Promise<'T>
    abstract member getAlarm: ?options: DurableObjectGetAlarmOptions -> JS.Promise<U2<float, obj>>
    abstract member setAlarm: scheduledTime: U2<float, JS.Date> * ?options: DurableObjectSetAlarmOptions -> JS.Promise<unit>
    abstract member deleteAlarm: ?options: DurableObjectSetAlarmOptions -> JS.Promise<unit>
    abstract member sync: unit -> JS.Promise<unit>
    abstract member sql: SqlStorage with get, set
    abstract member kv: SyncKvStorage with get, set
    abstract member transactionSync: closure: (unit -> 'T) -> 'T
    abstract member getCurrentBookmark: unit -> JS.Promise<string>
    abstract member getBookmarkForTime: timestamp: U2<float, JS.Date> -> JS.Promise<string>
    abstract member onNextSessionRestoreBookmark: bookmark: string -> JS.Promise<string>

[<AllowNullLiteral>]
[<Interface>]
type DurableObjectListOptions =
    abstract member start: string option with get, set
    abstract member startAfter: string option with get, set
    abstract member ``end``: string option with get, set
    abstract member prefix: string option with get, set
    abstract member reverse: bool option with get, set
    abstract member limit: float option with get, set
    abstract member allowConcurrency: bool option with get, set
    abstract member noCache: bool option with get, set

[<AllowNullLiteral>]
[<Interface>]
type DurableObjectGetOptions =
    abstract member allowConcurrency: bool option with get, set
    abstract member noCache: bool option with get, set

[<AllowNullLiteral>]
[<Interface>]
type DurableObjectGetAlarmOptions =
    abstract member allowConcurrency: bool option with get, set

[<AllowNullLiteral>]
[<Interface>]
type DurableObjectPutOptions =
    abstract member allowConcurrency: bool option with get, set
    abstract member allowUnconfirmed: bool option with get, set
    abstract member noCache: bool option with get, set

[<AllowNullLiteral>]
[<Interface>]
type DurableObjectSetAlarmOptions =
    abstract member allowConcurrency: bool option with get, set
    abstract member allowUnconfirmed: bool option with get, set

[<AllowNullLiteral>]
[<Interface>]
type WebSocketRequestResponsePair =
    abstract member request: string with get
    abstract member response: string with get

[<AllowNullLiteral>]
[<Interface>]
type AnalyticsEngineDataset =
    abstract member writeDataPoint: ?event: AnalyticsEngineDataPoint -> unit

[<AllowNullLiteral>]
[<Interface>]
type AnalyticsEngineDataPoint =
    abstract member indexes: ResizeArray<U2<U2<ArrayBuffer, string>, obj>> option with get, set
    abstract member doubles: ResizeArray<float> option with get, set
    abstract member blobs: ResizeArray<U2<U2<ArrayBuffer, string>, obj>> option with get, set

/// <summary>
/// The **<c>Event</c>** interface represents an event which takes place on an <c>EventTarget</c>.
///
/// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Event)
/// </summary>
[<AllowNullLiteral>]
[<Interface>]
type Event =
    /// <summary>
    /// The **<c>type</c>** read-only property of the Event interface returns a string containing the event's type.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Event/type)
    /// </summary>
    abstract member ``type``: string with get
    /// <summary>
    /// The **<c>eventPhase</c>** read-only property of the being evaluated.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Event/eventPhase)
    /// </summary>
    abstract member eventPhase: float with get
    /// <summary>
    /// The read-only **<c>composed</c>** property of the or not the event will propagate across the shadow DOM boundary into the standard DOM.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Event/composed)
    /// </summary>
    abstract member composed: bool with get
    /// <summary>
    /// The **<c>bubbles</c>** read-only property of the Event interface indicates whether the event bubbles up through the DOM tree or not.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Event/bubbles)
    /// </summary>
    abstract member bubbles: bool with get
    /// <summary>
    /// The **<c>cancelable</c>** read-only property of the Event interface indicates whether the event can be canceled, and therefore prevented as if the event never happened.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Event/cancelable)
    /// </summary>
    abstract member cancelable: bool with get
    /// <summary>
    /// The **<c>defaultPrevented</c>** read-only property of the Event interface returns a boolean value indicating whether or not the call to Event.preventDefault() canceled the event.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Event/defaultPrevented)
    /// </summary>
    abstract member defaultPrevented: bool with get
    /// <summary>
    /// The Event property **<c>returnValue</c>** indicates whether the default action for this event has been prevented or not.
    /// </summary>
    [<Obsolete("[MDN Reference](https://developer.mozilla.org/docs/Web/API/Event/returnValue)")>]
    abstract member returnValue: bool with get
    /// <summary>
    /// The **<c>currentTarget</c>** read-only property of the Event interface identifies the element to which the event handler has been attached.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Event/currentTarget)
    /// </summary>
    abstract member currentTarget: EventTarget option with get
    /// <summary>
    /// The read-only **<c>target</c>** property of the dispatched.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Event/target)
    /// </summary>
    abstract member target: EventTarget option with get
    /// <summary>
    /// The deprecated **<c>Event.srcElement</c>** is an alias for the Event.target property.
    /// </summary>
    [<Obsolete("[MDN Reference](https://developer.mozilla.org/docs/Web/API/Event/srcElement)")>]
    abstract member srcElement: U2<EventTarget, obj> with get
    /// <summary>
    /// The **<c>timeStamp</c>** read-only property of the Event interface returns the time (in milliseconds) at which the event was created.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Event/timeStamp)
    /// </summary>
    abstract member timeStamp: float with get
    /// <summary>
    /// The **<c>isTrusted</c>** read-only property of the when the event was generated by the user agent (including via user actions and programmatic methods such as HTMLElement.focus()), and <c>false</c> when the event was dispatched via The only exception is the <c>click</c> event, which initializes the <c>isTrusted</c> property to <c>false</c> in user agents.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Event/isTrusted)
    /// </summary>
    abstract member isTrusted: bool with get
    /// <summary>
    /// The **<c>cancelBubble</c>** property of the Event interface is deprecated.
    /// </summary>
    [<Obsolete("[MDN Reference](https://developer.mozilla.org/docs/Web/API/Event/cancelBubble)")>]
    abstract member cancelBubble: bool with get, set
    /// <summary>
    /// The **<c>stopImmediatePropagation()</c>** method of the If several listeners are attached to the same element for the same event type, they are called in the order in which they were added.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Event/stopImmediatePropagation)
    /// </summary>
    abstract member stopImmediatePropagation: unit -> unit
    /// <summary>
    /// The **<c>preventDefault()</c>** method of the Event interface tells the user agent that if the event does not get explicitly handled, its default action should not be taken as it normally would be.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Event/preventDefault)
    /// </summary>
    abstract member preventDefault: unit -> unit
    /// <summary>
    /// The **<c>stopPropagation()</c>** method of the Event interface prevents further propagation of the current event in the capturing and bubbling phases.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Event/stopPropagation)
    /// </summary>
    abstract member stopPropagation: unit -> unit
    /// <summary>
    /// The **<c>composedPath()</c>** method of the Event interface returns the event's path which is an array of the objects on which listeners will be invoked.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Event/composedPath)
    /// </summary>
    abstract member composedPath: unit -> ResizeArray<EventTarget>
    static member inline NONE
        with get () : float =
            emitJsExpr () $$"""
import { Event } from "Fidelity.CloudEdge.Worker.Context";
Event.NONE"""
    static member inline CAPTURING_PHASE
        with get () : float =
            emitJsExpr () $$"""
import { Event } from "Fidelity.CloudEdge.Worker.Context";
Event.CAPTURING_PHASE"""
    static member inline AT_TARGET
        with get () : float =
            emitJsExpr () $$"""
import { Event } from "Fidelity.CloudEdge.Worker.Context";
Event.AT_TARGET"""
    static member inline BUBBLING_PHASE
        with get () : float =
            emitJsExpr () $$"""
import { Event } from "Fidelity.CloudEdge.Worker.Context";
Event.BUBBLING_PHASE"""

[<AllowNullLiteral>]
[<Interface>]
type EventInit =
    abstract member bubbles: bool option with get, set
    abstract member cancelable: bool option with get, set
    abstract member composed: bool option with get, set

[<AllowNullLiteral>]
[<Interface>]
type EventListener<'EventType when 'EventType :> Event> =
    [<Emit("$0($1...)")>]
    abstract member Invoke: event: 'EventType -> unit

[<AllowNullLiteral>]
[<Interface>]
type EventListenerObject<'EventType when 'EventType :> Event> =
    abstract member handleEvent: event: 'EventType -> unit

type EventListenerOrEventListenerObject<'EventType when 'EventType :> Event> =
    U2<EventListener<'EventType>, EventListenerObject<'EventType>>

/// <summary>
/// The **<c>EventTarget</c>** interface is implemented by objects that can receive events and may have listeners for them.
///
/// [MDN Reference](https://developer.mozilla.org/docs/Web/API/EventTarget)
/// </summary>
[<AllowNullLiteral>]
[<Interface>]
type EventTarget<'EventMap when 'EventMap :> EventTarget_1> =
    /// <summary>
    /// The **<c>addEventListener()</c>** method of the EventTarget interface sets up a function that will be called whenever the specified event is delivered to the target.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/EventTarget/addEventListener)
    /// </summary>
    abstract member addEventListener: ``type``: 'Type * handler: EventListenerOrEventListenerObject<obj> * ?options: U2<EventTargetAddEventListenerOptions, bool> -> unit
    /// <summary>
    /// The **<c>removeEventListener()</c>** method of the EventTarget interface removes an event listener previously registered with EventTarget.addEventListener() from the target.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/EventTarget/removeEventListener)
    /// </summary>
    abstract member removeEventListener: ``type``: 'Type * handler: EventListenerOrEventListenerObject<obj> * ?options: U2<EventTargetEventListenerOptions, bool> -> unit
    /// <summary>
    /// The **<c>dispatchEvent()</c>** method of the EventTarget sends an Event to the object, (synchronously) invoking the affected event listeners in the appropriate order.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/EventTarget/dispatchEvent)
    /// </summary>
    abstract member dispatchEvent: event: obj -> bool
    [<EmitIndexer>]
    abstract member Item: key: string -> Event with get, set

type EventTarget =
    EventTarget<EventTarget>

[<AllowNullLiteral>]
[<Interface>]
type EventTargetEventListenerOptions =
    abstract member capture: bool option with get, set

[<AllowNullLiteral>]
[<Interface>]
type EventTargetAddEventListenerOptions =
    abstract member capture: bool option with get, set
    abstract member passive: bool option with get, set
    abstract member once: bool option with get, set
    abstract member signal: AbortSignal option with get, set

[<AllowNullLiteral>]
[<Interface>]
type EventTargetHandlerObject =
    abstract member handleEvent: (Event -> obj option) with get, set

/// <summary>
/// The **<c>AbortController</c>** interface represents a controller object that allows you to abort one or more Web requests as and when desired.
///
/// [MDN Reference](https://developer.mozilla.org/docs/Web/API/AbortController)
/// </summary>
[<AllowNullLiteral>]
[<Interface>]
type AbortController =
    /// <summary>
    /// The **<c>signal</c>** read-only property of the AbortController interface returns an AbortSignal object instance, which can be used to communicate with/abort an asynchronous operation as desired.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/AbortController/signal)
    /// </summary>
    abstract member signal: AbortSignal with get
    /// <summary>
    /// The **<c>abort()</c>** method of the AbortController interface aborts an asynchronous operation before it has completed.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/AbortController/abort)
    /// </summary>
    abstract member abort: ?reason: obj -> unit

/// <summary>
/// The **<c>AbortSignal</c>** interface represents a signal object that allows you to communicate with an asynchronous operation (such as a fetch request) and abort it if required via an AbortController object.
///
/// [MDN Reference](https://developer.mozilla.org/docs/Web/API/AbortSignal)
/// </summary>
[<AllowNullLiteral>]
[<Interface>]
type AbortSignal =
    inherit EventTarget
    /// <summary>
    /// The **<c>AbortSignal.abort()</c>** static method returns an AbortSignal that is already set as aborted (and which does not trigger an AbortSignal/abort_event event).
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/AbortSignal/abort_static)
    /// </summary>
    static member inline abort (?reason: obj): AbortSignal =
        emitJsExpr (reason) $$"""
import { AbortSignal } from "Fidelity.CloudEdge.Worker.Context";
AbortSignal.abort($0)"""
    /// <summary>
    /// The **<c>AbortSignal.timeout()</c>** static method returns an AbortSignal that will automatically abort after a specified time.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/AbortSignal/timeout_static)
    /// </summary>
    static member inline timeout (delay: float): AbortSignal =
        emitJsExpr (delay) $$"""
import { AbortSignal } from "Fidelity.CloudEdge.Worker.Context";
AbortSignal.timeout($0)"""
    /// <summary>
    /// The **<c>AbortSignal.any()</c>** static method takes an iterable of abort signals and returns an AbortSignal.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/AbortSignal/any_static)
    /// </summary>
    static member inline any (signals: ResizeArray<AbortSignal>): AbortSignal =
        emitJsExpr (signals) $$"""
import { AbortSignal } from "Fidelity.CloudEdge.Worker.Context";
AbortSignal.any($0)"""
    /// <summary>
    /// The **<c>aborted</c>** read-only property returns a value that indicates whether the asynchronous operations the signal is communicating with are aborted (<c>true</c>) or not (<c>false</c>).
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/AbortSignal/aborted)
    /// </summary>
    abstract member aborted: bool with get
    /// <summary>
    /// The **<c>reason</c>** read-only property returns a JavaScript value that indicates the abort reason.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/AbortSignal/reason)
    /// </summary>
    abstract member reason: obj with get
    abstract member onabort: U2<obj, obj> with get, set
    /// <summary>
    /// The **<c>throwIfAborted()</c>** method throws the signal's abort AbortSignal.reason if the signal has been aborted; otherwise it does nothing.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/AbortSignal/throwIfAborted)
    /// </summary>
    abstract member throwIfAborted: unit -> unit

[<AllowNullLiteral>]
[<Interface>]
type Scheduler =
    abstract member wait: delay: float * ?maybeOptions: SchedulerWaitOptions -> JS.Promise<unit>

[<AllowNullLiteral>]
[<Interface>]
type SchedulerWaitOptions =
    abstract member signal: AbortSignal option with get, set

/// <summary>
/// The **<c>ExtendableEvent</c>** interface extends the lifetime of the <c>install</c> and <c>activate</c> events dispatched on the global scope as part of the service worker lifecycle.
///
/// [MDN Reference](https://developer.mozilla.org/docs/Web/API/ExtendableEvent)
/// </summary>
[<AllowNullLiteral>]
[<Interface>]
type ExtendableEvent =
    inherit Event
    /// <summary>
    /// The **<c>ExtendableEvent.waitUntil()</c>** method tells the event dispatcher that work is ongoing.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/ExtendableEvent/waitUntil)
    /// </summary>
    abstract member waitUntil: promise: JS.Promise<obj> -> unit

/// <summary>
/// The **<c>CustomEvent</c>** interface represents events initialized by an application for any purpose.
///
/// [MDN Reference](https://developer.mozilla.org/docs/Web/API/CustomEvent)
/// </summary>
[<AllowNullLiteral>]
[<Interface>]
type CustomEvent<'T> =
    inherit Event
    /// <summary>
    /// The read-only **<c>detail</c>** property of the CustomEvent interface returns any data passed when initializing the event.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/CustomEvent/detail)
    /// </summary>
    abstract member detail: 'T with get

type CustomEvent =
    CustomEvent<obj>

[<AllowNullLiteral>]
[<Interface>]
type CustomEventCustomEventInit =
    abstract member bubbles: bool option with get, set
    abstract member cancelable: bool option with get, set
    abstract member composed: bool option with get, set
    abstract member detail: obj option with get, set

/// <summary>
/// The **<c>Blob</c>** interface represents a blob, which is a file-like object of immutable, raw data; they can be read as text or binary data, or converted into a ReadableStream so its methods can be used for processing the data.
///
/// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Blob)
/// </summary>
[<AllowNullLiteral>]
[<Interface>]
type Blob =
    /// <summary>
    /// The **<c>size</c>** read-only property of the Blob interface returns the size of the Blob or File in bytes.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Blob/size)
    /// </summary>
    abstract member size: float with get
    /// <summary>
    /// The **<c>type</c>** read-only property of the Blob interface returns the MIME type of the file.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Blob/type)
    /// </summary>
    abstract member ``type``: string with get
    /// <summary>
    /// The **<c>slice()</c>** method of the Blob interface creates and returns a new <c>Blob</c> object which contains data from a subset of the blob on which it's called.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Blob/slice)
    /// </summary>
    abstract member slice: ?start: float * ?``end``: float * ?``type``: string -> Blob
    /// <summary>
    /// The **<c>arrayBuffer()</c>** method of the Blob interface returns a Promise that resolves with the contents of the blob as binary data contained in an ArrayBuffer.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Blob/arrayBuffer)
    /// </summary>
    abstract member arrayBuffer: unit -> JS.Promise<ArrayBuffer>
    /// <summary>
    /// The **<c>bytes()</c>** method of the Blob interface returns a Promise that resolves with a Uint8Array containing the contents of the blob as an array of bytes.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Blob/bytes)
    /// </summary>
    abstract member bytes: unit -> JS.Promise<JS.Uint8Array>
    /// <summary>
    /// The **<c>text()</c>** method of the string containing the contents of the blob, interpreted as UTF-8.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Blob/text)
    /// </summary>
    abstract member text: unit -> JS.Promise<string>
    /// <summary>
    /// The **<c>stream()</c>** method of the Blob interface returns a ReadableStream which upon reading returns the data contained within the <c>Blob</c>.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Blob/stream)
    /// </summary>
    abstract member stream: unit -> ReadableStream

[<AllowNullLiteral>]
[<Interface>]
type BlobOptions =
    abstract member ``type``: string option with get, set

/// <summary>
/// The **<c>File</c>** interface provides information about files and allows JavaScript in a web page to access their content.
///
/// [MDN Reference](https://developer.mozilla.org/docs/Web/API/File)
/// </summary>
[<AllowNullLiteral>]
[<Interface>]
type File =
    inherit Blob
    /// <summary>
    /// The **<c>name</c>** read-only property of the File interface returns the name of the file represented by a File object.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/File/name)
    /// </summary>
    abstract member name: string with get
    /// <summary>
    /// The **<c>lastModified</c>** read-only property of the File interface provides the last modified date of the file as the number of milliseconds since the Unix epoch (January 1, 1970 at midnight).
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/File/lastModified)
    /// </summary>
    abstract member lastModified: float with get

[<AllowNullLiteral>]
[<Interface>]
type FileOptions =
    abstract member ``type``: string option with get, set
    abstract member lastModified: float option with get, set

/// <summary>
/// The Cache API allows fine grained control of reading and writing from the Cloudflare global network cache.
///
/// [Cloudflare Docs Reference](https://developers.cloudflare.com/workers/runtime-apis/cache/)
/// </summary>
[<AllowNullLiteral>]
[<Interface>]
type CacheStorage =
    /// <summary>
    /// The **<c>open()</c>** method of the the Cache object matching the <c>cacheName</c>.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/CacheStorage/open)
    /// </summary>
    abstract member ``open``: cacheName: string -> JS.Promise<Cache>
    abstract member ``default``: Cache with get

/// <summary>
/// The Cache API allows fine grained control of reading and writing from the Cloudflare global network cache.
///
/// [Cloudflare Docs Reference](https://developers.cloudflare.com/workers/runtime-apis/cache/)
/// </summary>
[<AllowNullLiteral>]
[<Interface>]
type Cache =
    abstract member delete: request: U2<RequestInfo, URL> * ?options: CacheQueryOptions -> JS.Promise<bool>
    abstract member ``match``: request: U2<RequestInfo, URL> * ?options: CacheQueryOptions -> JS.Promise<Response option>
    abstract member put: request: U2<RequestInfo, URL> * response: Response -> JS.Promise<unit>

[<AllowNullLiteral>]
[<Interface>]
type CacheQueryOptions =
    abstract member ignoreMethod: bool option with get, set

/// <summary>
/// The Web Crypto API provides a set of low-level functions for common cryptographic tasks.
/// The Workers runtime implements the full surface of this API, but with some differences in
/// the [supported algorithms](https://developers.cloudflare.com/workers/runtime-apis/web-crypto/#supported-algorithms)
/// compared to those implemented in most browsers.
///
/// [Cloudflare Docs Reference](https://developers.cloudflare.com/workers/runtime-apis/web-crypto/)
/// </summary>
[<AllowNullLiteral>]
[<Interface>]
type Crypto =
    /// <summary>
    /// The **<c>Crypto.subtle</c>** read-only property returns a cryptographic operations.
    /// Available only in secure contexts.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Crypto/subtle)
    /// </summary>
    abstract member subtle: SubtleCrypto with get
    /// <summary>
    /// The **<c>Crypto.getRandomValues()</c>** method lets you get cryptographically strong random values.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Crypto/getRandomValues)
    /// </summary>
    abstract member getRandomValues: buffer: 'T -> 'T
    /// <summary>
    /// The **<c>randomUUID()</c>** method of the Crypto interface is used to generate a v4 UUID using a cryptographically secure random number generator.
    /// Available only in secure contexts.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Crypto/randomUUID)
    /// </summary>
    abstract member randomUUID: unit -> string
    abstract member DigestStream: DigestStream with get, set

/// <summary>
/// The **<c>SubtleCrypto</c>** interface of the Web Crypto API provides a number of low-level cryptographic functions.
/// Available only in secure contexts.
///
/// [MDN Reference](https://developer.mozilla.org/docs/Web/API/SubtleCrypto)
/// </summary>
[<AllowNullLiteral>]
[<Interface>]
type SubtleCrypto =
    /// <summary>
    /// The **<c>encrypt()</c>** method of the SubtleCrypto interface encrypts data.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/SubtleCrypto/encrypt)
    /// </summary>
    abstract member encrypt: algorithm: U2<string, SubtleCryptoEncryptAlgorithm> * key: CryptoKey * plainText: U2<ArrayBuffer, ArrayBufferView> -> JS.Promise<ArrayBuffer>
    /// <summary>
    /// The **<c>decrypt()</c>** method of the SubtleCrypto interface decrypts some encrypted data.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/SubtleCrypto/decrypt)
    /// </summary>
    abstract member decrypt: algorithm: U2<string, SubtleCryptoEncryptAlgorithm> * key: CryptoKey * cipherText: U2<ArrayBuffer, ArrayBufferView> -> JS.Promise<ArrayBuffer>
    /// <summary>
    /// The **<c>sign()</c>** method of the SubtleCrypto interface generates a digital signature.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/SubtleCrypto/sign)
    /// </summary>
    abstract member sign: algorithm: U2<string, SubtleCryptoSignAlgorithm> * key: CryptoKey * data: U2<ArrayBuffer, ArrayBufferView> -> JS.Promise<ArrayBuffer>
    /// <summary>
    /// The **<c>verify()</c>** method of the SubtleCrypto interface verifies a digital signature.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/SubtleCrypto/verify)
    /// </summary>
    abstract member verify: algorithm: U2<string, SubtleCryptoSignAlgorithm> * key: CryptoKey * signature: U2<ArrayBuffer, ArrayBufferView> * data: U2<ArrayBuffer, ArrayBufferView> -> JS.Promise<bool>
    /// <summary>
    /// The **<c>digest()</c>** method of the SubtleCrypto interface generates a _digest_ of the given data, using the specified hash function.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/SubtleCrypto/digest)
    /// </summary>
    abstract member digest: algorithm: U2<string, SubtleCryptoHashAlgorithm> * data: U2<ArrayBuffer, ArrayBufferView> -> JS.Promise<ArrayBuffer>
    /// <summary>
    /// The **<c>generateKey()</c>** method of the SubtleCrypto interface is used to generate a new key (for symmetric algorithms) or key pair (for public-key algorithms).
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/SubtleCrypto/generateKey)
    /// </summary>
    abstract member generateKey: algorithm: U2<string, SubtleCryptoGenerateKeyAlgorithm> * extractable: bool * keyUsages: ResizeArray<string> -> JS.Promise<U2<CryptoKey, CryptoKeyPair>>
    /// <summary>
    /// The **<c>deriveKey()</c>** method of the SubtleCrypto interface can be used to derive a secret key from a master key.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/SubtleCrypto/deriveKey)
    /// </summary>
    abstract member deriveKey: algorithm: U2<string, SubtleCryptoDeriveKeyAlgorithm> * baseKey: CryptoKey * derivedKeyAlgorithm: U2<string, SubtleCryptoImportKeyAlgorithm> * extractable: bool * keyUsages: ResizeArray<string> -> JS.Promise<CryptoKey>
    /// <summary>
    /// The **<c>deriveBits()</c>** method of the key.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/SubtleCrypto/deriveBits)
    /// </summary>
    abstract member deriveBits: algorithm: U2<string, SubtleCryptoDeriveKeyAlgorithm> * baseKey: CryptoKey * ?length: U2<float, obj> -> JS.Promise<ArrayBuffer>
    /// <summary>
    /// The **<c>importKey()</c>** method of the SubtleCrypto interface imports a key: that is, it takes as input a key in an external, portable format and gives you a CryptoKey object that you can use in the Web Crypto API.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/SubtleCrypto/importKey)
    /// </summary>
    abstract member importKey: format: string * keyData: U2<U2<ArrayBuffer, ArrayBufferView>, JsonWebKey> * algorithm: U2<string, SubtleCryptoImportKeyAlgorithm> * extractable: bool * keyUsages: ResizeArray<string> -> JS.Promise<CryptoKey>
    /// <summary>
    /// The **<c>exportKey()</c>** method of the SubtleCrypto interface exports a key: that is, it takes as input a CryptoKey object and gives you the key in an external, portable format.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/SubtleCrypto/exportKey)
    /// </summary>
    abstract member exportKey: format: string * key: CryptoKey -> JS.Promise<U2<ArrayBuffer, JsonWebKey>>
    /// <summary>
    /// The **<c>wrapKey()</c>** method of the SubtleCrypto interface 'wraps' a key.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/SubtleCrypto/wrapKey)
    /// </summary>
    abstract member wrapKey: format: string * key: CryptoKey * wrappingKey: CryptoKey * wrapAlgorithm: U2<string, SubtleCryptoEncryptAlgorithm> -> JS.Promise<ArrayBuffer>
    /// <summary>
    /// The **<c>unwrapKey()</c>** method of the SubtleCrypto interface 'unwraps' a key.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/SubtleCrypto/unwrapKey)
    /// </summary>
    abstract member unwrapKey: format: string * wrappedKey: U2<ArrayBuffer, ArrayBufferView> * unwrappingKey: CryptoKey * unwrapAlgorithm: U2<string, SubtleCryptoEncryptAlgorithm> * unwrappedKeyAlgorithm: U2<string, SubtleCryptoImportKeyAlgorithm> * extractable: bool * keyUsages: ResizeArray<string> -> JS.Promise<CryptoKey>
    abstract member timingSafeEqual: a: U2<ArrayBuffer, ArrayBufferView> * b: U2<ArrayBuffer, ArrayBufferView> -> bool

/// <summary>
/// The **<c>CryptoKey</c>** interface of the Web Crypto API represents a cryptographic key obtained from one of the SubtleCrypto methods SubtleCrypto.generateKey, SubtleCrypto.deriveKey, SubtleCrypto.importKey, or SubtleCrypto.unwrapKey.
/// Available only in secure contexts.
///
/// [MDN Reference](https://developer.mozilla.org/docs/Web/API/CryptoKey)
/// </summary>
[<AllowNullLiteral>]
[<Interface>]
type CryptoKey =
    /// <summary>
    /// The read-only **<c>type</c>** property of the CryptoKey interface indicates which kind of key is represented by the object.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/CryptoKey/type)
    /// </summary>
    abstract member ``type``: string with get
    /// <summary>
    /// The read-only **<c>extractable</c>** property of the CryptoKey interface indicates whether or not the key may be extracted using <c>SubtleCrypto.exportKey()</c> or <c>SubtleCrypto.wrapKey()</c>.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/CryptoKey/extractable)
    /// </summary>
    abstract member extractable: bool with get
    /// <summary>
    /// The read-only **<c>algorithm</c>** property of the CryptoKey interface returns an object describing the algorithm for which this key can be used, and any associated extra parameters.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/CryptoKey/algorithm)
    /// </summary>
    abstract member algorithm: U6<CryptoKeyKeyAlgorithm, CryptoKeyAesKeyAlgorithm, CryptoKeyHmacKeyAlgorithm, CryptoKeyRsaKeyAlgorithm, CryptoKeyEllipticKeyAlgorithm, CryptoKeyArbitraryKeyAlgorithm> with get
    /// <summary>
    /// The read-only **<c>usages</c>** property of the CryptoKey interface indicates what can be done with the key.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/CryptoKey/usages)
    /// </summary>
    abstract member usages: ResizeArray<string> with get

[<AllowNullLiteral>]
[<Interface>]
type CryptoKeyPair =
    abstract member publicKey: CryptoKey with get, set
    abstract member privateKey: CryptoKey with get, set

[<AllowNullLiteral>]
[<Interface>]
type JsonWebKey =
    abstract member kty: string with get, set
    abstract member ``use``: string option with get, set
    abstract member key_ops: ResizeArray<string> option with get, set
    abstract member alg: string option with get, set
    abstract member ext: bool option with get, set
    abstract member crv: string option with get, set
    abstract member x: string option with get, set
    abstract member y: string option with get, set
    abstract member d: string option with get, set
    abstract member n: string option with get, set
    abstract member e: string option with get, set
    abstract member p: string option with get, set
    abstract member q: string option with get, set
    abstract member dp: string option with get, set
    abstract member dq: string option with get, set
    abstract member qi: string option with get, set
    abstract member oth: ResizeArray<RsaOtherPrimesInfo> option with get, set
    abstract member k: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type RsaOtherPrimesInfo =
    abstract member r: string option with get, set
    abstract member d: string option with get, set
    abstract member t: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type SubtleCryptoDeriveKeyAlgorithm =
    abstract member name: string with get, set
    abstract member salt: U2<ArrayBuffer, ArrayBufferView> option with get, set
    abstract member iterations: float option with get, set
    abstract member hash: U2<string, SubtleCryptoHashAlgorithm> option with get, set
    abstract member ``$public``: CryptoKey option with get, set
    abstract member info: U2<ArrayBuffer, ArrayBufferView> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type SubtleCryptoEncryptAlgorithm =
    abstract member name: string with get, set
    abstract member iv: U2<ArrayBuffer, ArrayBufferView> option with get, set
    abstract member additionalData: U2<ArrayBuffer, ArrayBufferView> option with get, set
    abstract member tagLength: float option with get, set
    abstract member counter: U2<ArrayBuffer, ArrayBufferView> option with get, set
    abstract member length: float option with get, set
    abstract member label: U2<ArrayBuffer, ArrayBufferView> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type SubtleCryptoGenerateKeyAlgorithm =
    abstract member name: string with get, set
    abstract member hash: U2<string, SubtleCryptoHashAlgorithm> option with get, set
    abstract member modulusLength: float option with get, set
    abstract member publicExponent: U2<ArrayBuffer, ArrayBufferView> option with get, set
    abstract member length: float option with get, set
    abstract member namedCurve: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type SubtleCryptoHashAlgorithm =
    abstract member name: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type SubtleCryptoImportKeyAlgorithm =
    abstract member name: string with get, set
    abstract member hash: U2<string, SubtleCryptoHashAlgorithm> option with get, set
    abstract member length: float option with get, set
    abstract member namedCurve: string option with get, set
    abstract member compressed: bool option with get, set

[<AllowNullLiteral>]
[<Interface>]
type SubtleCryptoSignAlgorithm =
    abstract member name: string with get, set
    abstract member hash: U2<string, SubtleCryptoHashAlgorithm> option with get, set
    abstract member dataLength: float option with get, set
    abstract member saltLength: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type CryptoKeyKeyAlgorithm =
    abstract member name: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type CryptoKeyAesKeyAlgorithm =
    abstract member name: string with get, set
    abstract member length: float with get, set

[<AllowNullLiteral>]
[<Interface>]
type CryptoKeyHmacKeyAlgorithm =
    abstract member name: string with get, set
    abstract member hash: CryptoKeyKeyAlgorithm with get, set
    abstract member length: float with get, set

[<AllowNullLiteral>]
[<Interface>]
type CryptoKeyRsaKeyAlgorithm =
    abstract member name: string with get, set
    abstract member modulusLength: float with get, set
    abstract member publicExponent: U2<ArrayBuffer, ArrayBufferView> with get, set
    abstract member hash: CryptoKeyKeyAlgorithm option with get, set

[<AllowNullLiteral>]
[<Interface>]
type CryptoKeyEllipticKeyAlgorithm =
    abstract member name: string with get, set
    abstract member namedCurve: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type CryptoKeyArbitraryKeyAlgorithm =
    abstract member name: string with get, set
    abstract member hash: CryptoKeyKeyAlgorithm option with get, set
    abstract member namedCurve: string option with get, set
    abstract member length: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type DigestStream =
    inherit WritableStream<U2<ArrayBuffer, ArrayBufferView>>
    abstract member digest: JS.Promise<ArrayBuffer> with get
    abstract member bytesWritten: U2<float, obj> with get

/// <summary>
/// The **<c>TextDecoder</c>** interface represents a decoder for a specific text encoding, such as <c>UTF-8</c>, <c>ISO-8859-2</c>, <c>KOI8-R</c>, <c>GBK</c>, etc.
///
/// [MDN Reference](https://developer.mozilla.org/docs/Web/API/TextDecoder)
/// </summary>
[<AllowNullLiteral>]
[<Interface>]
type TextDecoder =
    /// <summary>
    /// The **<c>TextDecoder.decode()</c>** method returns a string containing text decoded from the buffer passed as a parameter.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/TextDecoder/decode)
    /// </summary>
    abstract member decode: ?input: U2<ArrayBuffer, ArrayBufferView> * ?options: TextDecoderDecodeOptions -> string
    abstract member encoding: string with get
    abstract member fatal: bool with get
    abstract member ignoreBOM: bool with get

/// <summary>
/// The **<c>TextEncoder</c>** interface takes a stream of code points as input and emits a stream of UTF-8 bytes.
///
/// [MDN Reference](https://developer.mozilla.org/docs/Web/API/TextEncoder)
/// </summary>
[<AllowNullLiteral>]
[<Interface>]
type TextEncoder =
    /// <summary>
    /// The **<c>TextEncoder.encode()</c>** method takes a string as input, and returns a Global_Objects/Uint8Array containing the text given in parameters encoded with the specific method for that TextEncoder object.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/TextEncoder/encode)
    /// </summary>
    abstract member encode: ?input: string -> JS.Uint8Array
    /// <summary>
    /// The **<c>TextEncoder.encodeInto()</c>** method takes a string to encode and a destination Uint8Array to put resulting UTF-8 encoded text into, and returns a dictionary object indicating the progress of the encoding.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/TextEncoder/encodeInto)
    /// </summary>
    abstract member encodeInto: input: string * buffer: JS.Uint8Array -> TextEncoderEncodeIntoResult
    abstract member encoding: string with get

[<AllowNullLiteral>]
[<Interface>]
type TextDecoderConstructorOptions =
    abstract member fatal: bool with get, set
    abstract member ignoreBOM: bool with get, set

[<AllowNullLiteral>]
[<Interface>]
type TextDecoderDecodeOptions =
    abstract member stream: bool with get, set

[<AllowNullLiteral>]
[<Interface>]
type TextEncoderEncodeIntoResult =
    abstract member read: float with get, set
    abstract member written: float with get, set

/// <summary>
/// The **<c>ErrorEvent</c>** interface represents events providing information related to errors in scripts or in files.
///
/// [MDN Reference](https://developer.mozilla.org/docs/Web/API/ErrorEvent)
/// </summary>
[<AllowNullLiteral>]
[<Interface>]
type ErrorEvent =
    inherit Event
    /// <summary>
    /// The **<c>filename</c>** read-only property of the ErrorEvent interface returns a string containing the name of the script file in which the error occurred.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/ErrorEvent/filename)
    /// </summary>
    abstract member filename: string with get
    /// <summary>
    /// The **<c>message</c>** read-only property of the ErrorEvent interface returns a string containing a human-readable error message describing the problem.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/ErrorEvent/message)
    /// </summary>
    abstract member message: string with get
    /// <summary>
    /// The **<c>lineno</c>** read-only property of the ErrorEvent interface returns an integer containing the line number of the script file on which the error occurred.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/ErrorEvent/lineno)
    /// </summary>
    abstract member lineno: float with get
    /// <summary>
    /// The **<c>colno</c>** read-only property of the ErrorEvent interface returns an integer containing the column number of the script file on which the error occurred.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/ErrorEvent/colno)
    /// </summary>
    abstract member colno: float with get
    /// <summary>
    /// The **<c>error</c>** read-only property of the ErrorEvent interface returns a JavaScript value, such as an Error or DOMException, representing the error associated with this event.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/ErrorEvent/error)
    /// </summary>
    abstract member error: obj with get

[<AllowNullLiteral>]
[<Interface>]
type ErrorEventErrorEventInit =
    abstract member message: string option with get, set
    abstract member filename: string option with get, set
    abstract member lineno: float option with get, set
    abstract member colno: float option with get, set
    abstract member error: obj option with get, set

/// <summary>
/// The **<c>MessageEvent</c>** interface represents a message received by a target object.
///
/// [MDN Reference](https://developer.mozilla.org/docs/Web/API/MessageEvent)
/// </summary>
[<AllowNullLiteral>]
[<Interface>]
type MessageEvent =
    inherit Event
    /// <summary>
    /// The **<c>data</c>** read-only property of the The data sent by the message emitter; this can be any data type, depending on what originated this event.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/MessageEvent/data)
    /// </summary>
    abstract member data: obj with get
    /// <summary>
    /// The **<c>origin</c>** read-only property of the origin of the message emitter.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/MessageEvent/origin)
    /// </summary>
    abstract member origin: U2<string, obj> with get
    /// <summary>
    /// The **<c>lastEventId</c>** read-only property of the unique ID for the event.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/MessageEvent/lastEventId)
    /// </summary>
    abstract member lastEventId: string with get
    /// <summary>
    /// The **<c>source</c>** read-only property of the a WindowProxy, MessagePort, or a <c>MessageEventSource</c> (which can be a WindowProxy, message emitter.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/MessageEvent/source)
    /// </summary>
    abstract member source: U2<MessagePort, obj> with get
    /// <summary>
    /// The **<c>ports</c>** read-only property of the containing all MessagePort objects sent with the message, in order.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/MessageEvent/ports)
    /// </summary>
    abstract member ports: ResizeArray<MessagePort> with get

[<AllowNullLiteral>]
[<Interface>]
type MessageEventInit =
    abstract member data: U2<ArrayBuffer, string> with get, set

/// <summary>
/// The **<c>PromiseRejectionEvent</c>** interface represents events which are sent to the global script context when JavaScript Promises are rejected.
///
/// [MDN Reference](https://developer.mozilla.org/docs/Web/API/PromiseRejectionEvent)
/// </summary>
[<AllowNullLiteral>]
[<Interface>]
type PromiseRejectionEvent =
    inherit Event
    /// <summary>
    /// The PromiseRejectionEvent interface's **<c>promise</c>** read-only property indicates the JavaScript rejected.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/PromiseRejectionEvent/promise)
    /// </summary>
    abstract member promise: JS.Promise<obj> with get
    /// <summary>
    /// The PromiseRejectionEvent **<c>reason</c>** read-only property is any JavaScript value or Object which provides the reason passed into Promise.reject().
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/PromiseRejectionEvent/reason)
    /// </summary>
    abstract member reason: obj with get

/// <summary>
/// The **<c>FormData</c>** interface provides a way to construct a set of key/value pairs representing form fields and their values, which can be sent using the Window/fetch, XMLHttpRequest.send() or navigator.sendBeacon() methods.
///
/// [MDN Reference](https://developer.mozilla.org/docs/Web/API/FormData)
/// </summary>
[<AllowNullLiteral>]
[<Interface>]
type FormData =
    /// <summary>
    /// The **<c>append()</c>** method of the FormData interface appends a new value onto an existing key inside a <c>FormData</c> object, or adds the key if it does not already exist.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/FormData/append)
    /// </summary>
    abstract member append: name: string * value: U2<string, Blob> -> unit
    /// <summary>
    /// The **<c>append()</c>** method of the FormData interface appends a new value onto an existing key inside a <c>FormData</c> object, or adds the key if it does not already exist.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/FormData/append)
    /// </summary>
    abstract member append: name: string * value: string -> unit
    /// <summary>
    /// The **<c>append()</c>** method of the FormData interface appends a new value onto an existing key inside a <c>FormData</c> object, or adds the key if it does not already exist.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/FormData/append)
    /// </summary>
    abstract member append: name: string * value: Blob * ?filename: string -> unit
    /// <summary>
    /// The **<c>delete()</c>** method of the FormData interface deletes a key and its value(s) from a <c>FormData</c> object.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/FormData/delete)
    /// </summary>
    abstract member delete: name: string -> unit
    /// <summary>
    /// The **<c>get()</c>** method of the FormData interface returns the first value associated with a given key from within a <c>FormData</c> object.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/FormData/get)
    /// </summary>
    abstract member get: name: string -> U2<string, obj>
    /// <summary>
    /// The **<c>getAll()</c>** method of the FormData interface returns all the values associated with a given key from within a <c>FormData</c> object.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/FormData/getAll)
    /// </summary>
    abstract member getAll: name: string -> ResizeArray<string>
    /// <summary>
    /// The **<c>has()</c>** method of the FormData interface returns whether a <c>FormData</c> object contains a certain key.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/FormData/has)
    /// </summary>
    abstract member has: name: string -> bool
    /// <summary>
    /// The **<c>set()</c>** method of the FormData interface sets a new value for an existing key inside a <c>FormData</c> object, or adds the key/value if it does not already exist.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/FormData/set)
    /// </summary>
    abstract member set: name: string * value: U2<string, Blob> -> unit
    /// <summary>
    /// The **<c>set()</c>** method of the FormData interface sets a new value for an existing key inside a <c>FormData</c> object, or adds the key/value if it does not already exist.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/FormData/set)
    /// </summary>
    abstract member set: name: string * value: string -> unit
    /// <summary>
    /// The **<c>set()</c>** method of the FormData interface sets a new value for an existing key inside a <c>FormData</c> object, or adds the key/value if it does not already exist.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/FormData/set)
    /// </summary>
    abstract member set: name: string * value: Blob * ?filename: string -> unit
    abstract member entries: unit -> IterableIterator<string * string>
    abstract member keys: unit -> IterableIterator<string>
    abstract member values: unit -> IterableIterator<U2<File, string>>
    abstract member forEach: callback: FormData.forEach.callback * ?thisArg: 'This -> unit

[<AllowNullLiteral>]
[<Interface>]
type ContentOptions =
    abstract member html: bool option with get, set

[<AllowNullLiteral>]
[<Interface>]
type HTMLRewriter =
    abstract member on: selector: string * handlers: HTMLRewriterElementContentHandlers -> HTMLRewriter
    abstract member onDocument: handlers: HTMLRewriterDocumentContentHandlers -> HTMLRewriter
    abstract member transform: response: Response -> Response

[<AllowNullLiteral>]
[<Interface>]
type HTMLRewriterElementContentHandlers =
    abstract member element: element: Element -> U2<unit, JS.Promise<unit>>
    abstract member comments: comment: Comment -> U2<unit, JS.Promise<unit>>
    abstract member text: element: Text -> U2<unit, JS.Promise<unit>>

[<AllowNullLiteral>]
[<Interface>]
type HTMLRewriterDocumentContentHandlers =
    abstract member doctype: doctype: Doctype -> U2<unit, JS.Promise<unit>>
    abstract member comments: comment: Comment -> U2<unit, JS.Promise<unit>>
    abstract member text: text: Text -> U2<unit, JS.Promise<unit>>
    abstract member ``end``: ``end``: DocumentEnd -> U2<unit, JS.Promise<unit>>

[<AllowNullLiteral>]
[<Interface>]
type Doctype =
    abstract member name: U2<string, obj> with get
    abstract member publicId: U2<string, obj> with get
    abstract member systemId: U2<string, obj> with get

[<AllowNullLiteral>]
[<Interface>]
type Element =
    /// <summary>
    /// Returns the HTML-uppercased qualified name.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Element/tagName)
    /// </summary>
    abstract member tagName: string with get, set
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Element/attributes)
    /// </summary>
    abstract member attributes: IterableIterator<ResizeArray<string>> with get
    abstract member removed: bool with get
    /// <summary>
    /// Returns the namespace.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Element/namespaceURI)
    /// </summary>
    abstract member namespaceURI: string with get
    /// <summary>
    /// Returns element's first attribute whose qualified name is qualifiedName, and null if there is no such attribute otherwise.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Element/getAttribute)
    /// </summary>
    abstract member getAttribute: name: string -> U2<string, obj>
    /// <summary>
    /// Returns true if element has an attribute whose qualified name is qualifiedName, and false otherwise.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Element/hasAttribute)
    /// </summary>
    abstract member hasAttribute: name: string -> bool
    /// <summary>
    /// Sets the value of element's first attribute whose qualified name is qualifiedName to value.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Element/setAttribute)
    /// </summary>
    abstract member setAttribute: name: string * value: string -> Element
    /// <summary>
    /// Removes element's first attribute whose qualified name is qualifiedName.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Element/removeAttribute)
    /// </summary>
    abstract member removeAttribute: name: string -> Element
    abstract member before: content: U3<string, ReadableStream, Response> * ?options: ContentOptions -> Element
    abstract member after: content: U3<string, ReadableStream, Response> * ?options: ContentOptions -> Element
    abstract member prepend: content: U3<string, ReadableStream, Response> * ?options: ContentOptions -> Element
    abstract member append: content: U3<string, ReadableStream, Response> * ?options: ContentOptions -> Element
    abstract member replace: content: U3<string, ReadableStream, Response> * ?options: ContentOptions -> Element
    abstract member remove: unit -> Element
    abstract member removeAndKeepContent: unit -> Element
    abstract member setInnerContent: content: U3<string, ReadableStream, Response> * ?options: ContentOptions -> Element
    abstract member onEndTag: handler: (EndTag -> U2<unit, JS.Promise<unit>>) -> unit

[<AllowNullLiteral>]
[<Interface>]
type EndTag =
    abstract member name: string with get, set
    abstract member before: content: U3<string, ReadableStream, Response> * ?options: ContentOptions -> EndTag
    abstract member after: content: U3<string, ReadableStream, Response> * ?options: ContentOptions -> EndTag
    abstract member remove: unit -> EndTag

[<AllowNullLiteral>]
[<Interface>]
type Comment =
    abstract member text: string with get, set
    abstract member removed: bool with get
    abstract member before: content: string * ?options: ContentOptions -> Comment
    abstract member after: content: string * ?options: ContentOptions -> Comment
    abstract member replace: content: string * ?options: ContentOptions -> Comment
    abstract member remove: unit -> Comment

[<AllowNullLiteral>]
[<Interface>]
type Text =
    abstract member text: string with get
    abstract member lastInTextNode: bool with get
    abstract member removed: bool with get
    abstract member before: content: U3<string, ReadableStream, Response> * ?options: ContentOptions -> Text
    abstract member after: content: U3<string, ReadableStream, Response> * ?options: ContentOptions -> Text
    abstract member replace: content: U3<string, ReadableStream, Response> * ?options: ContentOptions -> Text
    abstract member remove: unit -> Text

[<AllowNullLiteral>]
[<Interface>]
type DocumentEnd =
    abstract member append: content: string * ?options: ContentOptions -> DocumentEnd

/// <summary>
/// This is the event type for <c>fetch</c> events dispatched on the ServiceWorkerGlobalScope.
///
/// [MDN Reference](https://developer.mozilla.org/docs/Web/API/FetchEvent)
/// </summary>
[<AllowNullLiteral>]
[<Interface>]
type FetchEvent =
    inherit ExtendableEvent
    /// <summary>
    /// The **<c>request</c>** read-only property of the the event handler.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/FetchEvent/request)
    /// </summary>
    abstract member request: Request with get
    /// <summary>
    /// The **<c>respondWith()</c>** method of allows you to provide a promise for a Response yourself.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/FetchEvent/respondWith)
    /// </summary>
    abstract member respondWith: promise: U2<Response, JS.Promise<Response>> -> unit
    abstract member passThroughOnException: unit -> unit

type HeadersInit =
    U3<Headers, Iterable<Iterable<string>>, HeadersInit.U3.Case3>

/// <summary>
/// The **<c>Headers</c>** interface of the Fetch API allows you to perform various actions on HTTP request and response headers.
///
/// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Headers)
/// </summary>
[<AllowNullLiteral>]
[<Interface>]
type Headers =
    /// <summary>
    /// The **<c>get()</c>** method of the Headers interface returns a byte string of all the values of a header within a <c>Headers</c> object with a given name.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Headers/get)
    /// </summary>
    abstract member get: name: string -> U2<string, obj>
    abstract member getAll: name: string -> ResizeArray<string>
    /// <summary>
    /// The **<c>has()</c>** method of the Headers interface returns a boolean stating whether a <c>Headers</c> object contains a certain header.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Headers/has)
    /// </summary>
    abstract member has: name: string -> bool
    /// <summary>
    /// The **<c>set()</c>** method of the Headers interface sets a new value for an existing header inside a <c>Headers</c> object, or adds the header if it does not already exist.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Headers/set)
    /// </summary>
    abstract member set: name: string * value: string -> unit
    /// <summary>
    /// The **<c>append()</c>** method of the Headers interface appends a new value onto an existing header inside a <c>Headers</c> object, or adds the header if it does not already exist.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Headers/append)
    /// </summary>
    abstract member append: name: string * value: string -> unit
    /// <summary>
    /// The **<c>delete()</c>** method of the Headers interface deletes a header from the current <c>Headers</c> object.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Headers/delete)
    /// </summary>
    abstract member delete: name: string -> unit
    abstract member forEach: callback: Headers.forEach.callback * ?thisArg: 'This -> unit
    abstract member entries: unit -> IterableIterator<string * string>
    abstract member keys: unit -> IterableIterator<string>
    abstract member values: unit -> IterableIterator<string>

type BodyInit =
    U7<ReadableStream<JS.Uint8Array>, string, ArrayBuffer, ArrayBufferView, Blob, URLSearchParams, FormData>

[<AllowNullLiteral>]
[<Interface>]
type Body =
    abstract member body: U2<ReadableStream, obj> with get
    abstract member bodyUsed: bool with get
    abstract member arrayBuffer: unit -> JS.Promise<ArrayBuffer>
    abstract member bytes: unit -> JS.Promise<JS.Uint8Array>
    abstract member text: unit -> JS.Promise<string>
    abstract member json: unit -> JS.Promise<'T>
    abstract member formData: unit -> JS.Promise<FormData>
    abstract member blob: unit -> JS.Promise<Blob>


[<AllowNullLiteral>]
[<Interface>]
type Response =
    inherit Body
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Response/clone)
    /// The **<c>clone()</c>** method of the Response interface creates a clone of a response object, identical in every way, but stored in a different variable.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Response/clone)
    /// </summary>
    abstract member clone: unit -> Response
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Response/status)
    /// The **<c>status</c>** read-only property of the Response interface contains the HTTP status codes of the response.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Response/status)
    /// </summary>
    abstract member status: float with get
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Response/statusText)
    /// The **<c>statusText</c>** read-only property of the Response interface contains the status message corresponding to the HTTP status code in Response.status.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Response/statusText)
    /// </summary>
    abstract member statusText: string with get
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Response/headers)
    /// The **<c>headers</c>** read-only property of the with the response.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Response/headers)
    /// </summary>
    abstract member headers: Headers with get
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Response/ok)
    /// The **<c>ok</c>** read-only property of the Response interface contains a Boolean stating whether the response was successful (status in the range 200-299) or not.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Response/ok)
    /// </summary>
    abstract member ok: bool with get
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Response/redirected)
    /// The **<c>redirected</c>** read-only property of the Response interface indicates whether or not the response is the result of a request you made which was redirected.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Response/redirected)
    /// </summary>
    abstract member redirected: bool with get
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Response/url)
    /// The **<c>url</c>** read-only property of the Response interface contains the URL of the response.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Response/url)
    /// </summary>
    abstract member url: string with get
    abstract member webSocket: U2<WebSocket, obj> with get
    abstract member cf: obj option with get
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Response/type)
    /// The **<c>type</c>** read-only property of the Response interface contains the type of the response.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Response/type)
    /// </summary>
    abstract member ``type``: Response.``type`` with get, set

[<AllowNullLiteral>]
[<Interface>]
type ResponseInit =
    abstract member status: float option with get, set
    abstract member statusText: string option with get, set
    abstract member headers: HeadersInit option with get, set
    abstract member cf: obj option with get, set
    abstract member webSocket: U2<WebSocket, obj> option with get, set
    abstract member encodeBody: ResponseInit.encodeBody option with get, set

type RequestInfo<'CfHostMetadata, 'Cf> =
    U2<Request<'CfHostMetadata, 'Cf>, string>


[<AllowNullLiteral>]
[<Interface>]
type Request<'CfHostMetadata, 'Cf> =
    inherit Body
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Request/clone)
    /// The **<c>clone()</c>** method of the Request interface creates a copy of the current <c>Request</c> object.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Request/clone)
    /// </summary>
    abstract member clone: unit -> Request<'CfHostMetadata, 'Cf>
    /// <summary>
    /// Returns request's HTTP method, which is "GET" by default.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Request/method)
    /// The **<c>method</c>** read-only property of the <c>POST</c>, etc.) A String indicating the method of the request.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Request/method)
    /// </summary>
    abstract member ``method``: string with get
    /// <summary>
    /// Returns the URL of request as a string.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Request/url)
    /// The **<c>url</c>** read-only property of the Request interface contains the URL of the request.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Request/url)
    /// </summary>
    abstract member url: string with get
    /// <summary>
    /// Returns a Headers object consisting of the headers associated with request. Note that headers added in the network layer by the user agent will not be accounted for in this object, e.g., the "Host" header.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Request/headers)
    /// The **<c>headers</c>** read-only property of the with the request.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Request/headers)
    /// </summary>
    abstract member headers: Headers with get
    /// <summary>
    /// Returns the redirect mode associated with request, which is a string indicating how redirects for the request will be handled during fetching. A request will follow redirects by default.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Request/redirect)
    /// The **<c>redirect</c>** read-only property of the Request interface contains the mode for how redirects are handled.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Request/redirect)
    /// </summary>
    abstract member redirect: string with get
    abstract member fetcher: U2<Fetcher, obj> with get
    /// <summary>
    /// Returns the signal associated with request, which is an AbortSignal object indicating whether or not request has been aborted, and its abort event handler.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Request/signal)
    /// The read-only **<c>signal</c>** property of the Request interface returns the AbortSignal associated with the request.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Request/signal)
    /// </summary>
    abstract member signal: AbortSignal with get
    abstract member cf: 'Cf option with get
    /// <summary>
    /// Returns request's subresource integrity metadata, which is a cryptographic hash of the resource being fetched. Its value consists of multiple hashes separated by whitespace. [SRI]
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Request/integrity)
    /// The **<c>integrity</c>** read-only property of the Request interface contains the subresource integrity value of the request.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Request/integrity)
    /// </summary>
    abstract member integrity: string with get
    /// <summary>
    /// Returns a boolean indicating whether or not request can outlive the global in which it was created.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Request/keepalive)
    /// The **<c>keepalive</c>** read-only property of the Request interface contains the request's <c>keepalive</c> setting (<c>true</c> or <c>false</c>), which indicates whether the browser will keep the associated request alive if the page that initiated it is unloaded before the request is complete.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Request/keepalive)
    /// </summary>
    abstract member keepalive: bool with get

[<AllowNullLiteral>]
[<Interface>]
type RequestInit<'Cf> =
    abstract member ``method``: string option with get, set
    abstract member headers: HeadersInit option with get, set
    abstract member body: U2<BodyInit, obj> option with get, set
    abstract member redirect: string option with get, set
    abstract member fetcher: U2<Fetcher, obj> option with get, set
    abstract member cf: 'Cf option with get, set
    abstract member integrity: string option with get, set
    abstract member signal: U2<AbortSignal, obj> option with get, set
    abstract member encodeResponseBody: RequestInit.encodeResponseBody option with get, set

type Service =
    'T

[<AllowNullLiteral>]
[<Interface>]
type Fetcher<'T when 'T :> Rpc.EntrypointBranded option> =
    abstract member fetch: input: U2<RequestInfo, URL> * ?init: RequestInit -> JS.Promise<Response>
    abstract member connect: address: U2<SocketAddress, string> * ?options: SocketOptions -> Socket

[<AllowNullLiteral>]
[<Interface>]
type FetcherPutOptions =
    abstract member expiration: float option with get, set
    abstract member expirationTtl: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type KVNamespaceListKey<'Metadata> =
    abstract member name: string with get, set
    abstract member expiration: float option with get, set
    abstract member metadata: 'Metadata option with get, set

[<AllowNullLiteral>]
[<Interface>]
type KVNamespaceListResult =
    abstract member list_complete: bool with get, set
    abstract member keys: ResizeArray<KVNamespaceListKey<'Metadata, 'Key>> with get, set
    abstract member cursor: string with get, set
    abstract member cacheStatus: U2<string, obj> with get, set
    abstract member list_complete: bool with get, set
    abstract member keys: ResizeArray<KVNamespaceListKey<'Metadata, 'Key>> with get, set
    abstract member cacheStatus: U2<string, obj> with get, set

[<AllowNullLiteral>]
[<Interface>]
type KVNamespace =
    abstract member get: key: string * ?options: KVNamespace.get.options -> JS.Promise<U2<string, obj>>
    abstract member get: key: string * ``type``: string -> JS.Promise<U2<string, obj>>
    abstract member get: key: string * ``type``: string -> JS.Promise<U2<'ExpectedValue, obj>>
    abstract member get: key: string * ``type``: string -> JS.Promise<U2<ArrayBuffer, obj>>
    abstract member get: key: string * ``type``: string -> JS.Promise<U2<ReadableStream, obj>>
    abstract member get: key: string * ?options: KVNamespaceGetOptions<string> -> JS.Promise<U2<string, obj>>
    abstract member get: key: string * ?options: KVNamespaceGetOptions<string> -> JS.Promise<U2<'ExpectedValue, obj>>
    abstract member get: key: string * ?options: KVNamespaceGetOptions<string> -> JS.Promise<U2<ArrayBuffer, obj>>
    abstract member get: key: string * ?options: KVNamespaceGetOptions<string> -> JS.Promise<U2<ReadableStream, obj>>
    abstract member get: key: ResizeArray<string> * ``type``: string -> JS.Promise<Map<string, U2<string, obj>>>
    abstract member get: key: ResizeArray<string> * ``type``: string -> JS.Promise<Map<string, U2<'ExpectedValue, obj>>>
    abstract member get: key: ResizeArray<string> * ?options: KVNamespace.get.options -> JS.Promise<Map<string, U2<string, obj>>>
    abstract member get: key: ResizeArray<string> * ?options: KVNamespaceGetOptions<string> -> JS.Promise<Map<string, U2<string, obj>>>
    abstract member get: key: ResizeArray<string> * ?options: KVNamespaceGetOptions<string> -> JS.Promise<Map<string, U2<'ExpectedValue, obj>>>
    abstract member list: ?options: KVNamespaceListOptions -> JS.Promise<KVNamespaceListResult<'Metadata, string>>
    abstract member put: key: string * value: U4<string, ArrayBuffer, ArrayBufferView, ReadableStream> * ?options: KVNamespacePutOptions -> JS.Promise<unit>
    abstract member getWithMetadata: key: string * ?options: KVNamespace.getWithMetadata.options -> JS.Promise<KVNamespaceGetWithMetadataResult<string, 'Metadata>>
    abstract member getWithMetadata: key: string * ``type``: string -> JS.Promise<KVNamespaceGetWithMetadataResult<string, 'Metadata>>
    abstract member getWithMetadata: key: string * ``type``: string -> JS.Promise<KVNamespaceGetWithMetadataResult<'ExpectedValue, 'Metadata>>
    abstract member getWithMetadata: key: string * ``type``: string -> JS.Promise<KVNamespaceGetWithMetadataResult<ArrayBuffer, 'Metadata>>
    abstract member getWithMetadata: key: string * ``type``: string -> JS.Promise<KVNamespaceGetWithMetadataResult<ReadableStream, 'Metadata>>
    abstract member getWithMetadata: key: string * options: KVNamespaceGetOptions<string> -> JS.Promise<KVNamespaceGetWithMetadataResult<string, 'Metadata>>
    abstract member getWithMetadata: key: string * options: KVNamespaceGetOptions<string> -> JS.Promise<KVNamespaceGetWithMetadataResult<'ExpectedValue, 'Metadata>>
    abstract member getWithMetadata: key: string * options: KVNamespaceGetOptions<string> -> JS.Promise<KVNamespaceGetWithMetadataResult<ArrayBuffer, 'Metadata>>
    abstract member getWithMetadata: key: string * options: KVNamespaceGetOptions<string> -> JS.Promise<KVNamespaceGetWithMetadataResult<ReadableStream, 'Metadata>>
    abstract member getWithMetadata: key: ResizeArray<string> * ``type``: string -> JS.Promise<Map<string, KVNamespaceGetWithMetadataResult<string, 'Metadata>>>
    abstract member getWithMetadata: key: ResizeArray<string> * ``type``: string -> JS.Promise<Map<string, KVNamespaceGetWithMetadataResult<'ExpectedValue, 'Metadata>>>
    abstract member getWithMetadata: key: ResizeArray<string> * ?options: KVNamespace.getWithMetadata.options -> JS.Promise<Map<string, KVNamespaceGetWithMetadataResult<string, 'Metadata>>>
    abstract member getWithMetadata: key: ResizeArray<string> * ?options: KVNamespaceGetOptions<string> -> JS.Promise<Map<string, KVNamespaceGetWithMetadataResult<string, 'Metadata>>>
    abstract member getWithMetadata: key: ResizeArray<string> * ?options: KVNamespaceGetOptions<string> -> JS.Promise<Map<string, KVNamespaceGetWithMetadataResult<'ExpectedValue, 'Metadata>>>
    abstract member delete: key: string -> JS.Promise<unit>

[<AllowNullLiteral>]
[<Interface>]
type KVNamespaceListOptions =
    abstract member limit: float option with get, set
    abstract member prefix: U2<string, obj> option with get, set
    abstract member cursor: U2<string, obj> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type KVNamespaceGetOptions<'Type> =
    abstract member ``type``: 'Type with get, set
    abstract member cacheTtl: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type KVNamespacePutOptions =
    abstract member expiration: float option with get, set
    abstract member expirationTtl: float option with get, set
    abstract member metadata: U2<obj, obj> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type KVNamespaceGetWithMetadataResult<'Value, 'Metadata> =
    abstract member value: U2<'Value, obj> with get, set
    abstract member metadata: U2<'Metadata, obj> with get, set
    abstract member cacheStatus: U2<string, obj> with get, set

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type QueueContentType =
    | text
    | bytes
    | json
    | v8

[<AllowNullLiteral>]
[<Interface>]
type Queue<'Body> =
    abstract member send: message: 'Body * ?options: QueueSendOptions -> JS.Promise<unit>
    abstract member sendBatch: messages: Iterable<MessageSendRequest<'Body>> * ?options: QueueSendBatchOptions -> JS.Promise<unit>

[<AllowNullLiteral>]
[<Interface>]
type QueueSendOptions =
    abstract member contentType: QueueContentType option with get, set
    abstract member delaySeconds: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type QueueSendBatchOptions =
    abstract member delaySeconds: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type MessageSendRequest<'Body> =
    abstract member body: 'Body with get, set
    abstract member contentType: QueueContentType option with get, set
    abstract member delaySeconds: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type QueueRetryOptions =
    abstract member delaySeconds: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Message<'Body> =
    abstract member id: string with get
    abstract member timestamp: JS.Date with get
    abstract member body: 'Body with get
    abstract member attempts: float with get
    abstract member retry: ?options: QueueRetryOptions -> unit
    abstract member ack: unit -> unit

[<AllowNullLiteral>]
[<Interface>]
type QueueEvent<'Body> =
    inherit ExtendableEvent
    abstract member messages: ReadonlyArray<Message<'Body>> with get
    abstract member queue: string with get
    abstract member retryAll: ?options: QueueRetryOptions -> unit
    abstract member ackAll: unit -> unit

[<AllowNullLiteral>]
[<Interface>]
type MessageBatch<'Body> =
    abstract member messages: ReadonlyArray<Message<'Body>> with get
    abstract member queue: string with get
    abstract member retryAll: ?options: QueueRetryOptions -> unit
    abstract member ackAll: unit -> unit

[<AllowNullLiteral>]
[<Interface>]
type R2Error =
    inherit Exception
    abstract member name: string with get
    abstract member code: float with get
    abstract member message: string with get
    abstract member action: string with get
    abstract member stack: obj with get

[<AllowNullLiteral>]
[<Interface>]
type R2ListOptions =
    abstract member limit: float option with get, set
    abstract member prefix: string option with get, set
    abstract member cursor: string option with get, set
    abstract member delimiter: string option with get, set
    abstract member startAfter: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type R2Bucket =
    abstract member head: key: string -> JS.Promise<U2<R2Object, obj>>
    abstract member get: key: string * options: obj -> JS.Promise<U3<R2ObjectBody, R2Object, obj>>
    abstract member get: key: string * ?options: R2GetOptions -> JS.Promise<U2<R2ObjectBody, obj>>
    abstract member put: key: string * value: U6<ReadableStream, ArrayBuffer, ArrayBufferView, string, obj, Blob> * ?options: obj -> JS.Promise<U2<R2Object, obj>>
    abstract member put: key: string * value: U6<ReadableStream, ArrayBuffer, ArrayBufferView, string, obj, Blob> * ?options: R2PutOptions -> JS.Promise<R2Object>
    abstract member createMultipartUpload: key: string * ?options: R2MultipartOptions -> JS.Promise<R2MultipartUpload>
    abstract member resumeMultipartUpload: key: string * uploadId: string -> R2MultipartUpload
    abstract member delete: keys: U2<string, ResizeArray<string>> -> JS.Promise<unit>
    abstract member list: ?options: R2ListOptions -> JS.Promise<R2Objects>

[<AllowNullLiteral>]
[<Interface>]
type R2MultipartUpload =
    abstract member key: string with get
    abstract member uploadId: string with get
    abstract member uploadPart: partNumber: float * value: U4<ReadableStream, U2<ArrayBuffer, ArrayBufferView>, string, Blob> * ?options: R2UploadPartOptions -> JS.Promise<R2UploadedPart>
    abstract member abort: unit -> JS.Promise<unit>
    abstract member complete: uploadedParts: ResizeArray<R2UploadedPart> -> JS.Promise<R2Object>

[<AllowNullLiteral>]
[<Interface>]
type R2UploadedPart =
    abstract member partNumber: float with get, set
    abstract member etag: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type R2Object =
    abstract member key: string with get
    abstract member version: string with get
    abstract member size: float with get
    abstract member etag: string with get
    abstract member httpEtag: string with get
    abstract member checksums: R2Checksums with get
    abstract member uploaded: JS.Date with get
    abstract member httpMetadata: R2HTTPMetadata option with get
    abstract member customMetadata: R2Object.customMetadata option with get
    abstract member range: R2Range option with get
    abstract member storageClass: string with get
    abstract member ssecKeyMd5: string option with get
    abstract member writeHttpMetadata: headers: Headers -> unit

[<AllowNullLiteral>]
[<Interface>]
type R2ObjectBody =
    inherit R2Object
    abstract member body: ReadableStream with get
    abstract member bodyUsed: bool with get
    abstract member arrayBuffer: unit -> JS.Promise<ArrayBuffer>
    abstract member bytes: unit -> JS.Promise<JS.Uint8Array>
    abstract member text: unit -> JS.Promise<string>
    abstract member json: unit -> JS.Promise<'T>
    abstract member blob: unit -> JS.Promise<Blob>

[<AllowNullLiteral>]
[<Interface>]
type R2Range =
    abstract member offset: float with get, set
    abstract member length: float option with get, set
    abstract member offset: float option with get, set
    abstract member length: float with get, set
    abstract member suffix: float with get, set

[<AllowNullLiteral>]
[<Interface>]
type R2Conditional =
    abstract member etagMatches: string option with get, set
    abstract member etagDoesNotMatch: string option with get, set
    abstract member uploadedBefore: JS.Date option with get, set
    abstract member uploadedAfter: JS.Date option with get, set
    abstract member secondsGranularity: bool option with get, set

[<AllowNullLiteral>]
[<Interface>]
type R2GetOptions =
    abstract member onlyIf: U2<R2Conditional, Headers> option with get, set
    abstract member range: U2<R2Range, Headers> option with get, set
    abstract member ssecKey: U2<ArrayBuffer, string> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type R2PutOptions =
    abstract member onlyIf: U2<R2Conditional, Headers> option with get, set
    abstract member httpMetadata: U2<R2HTTPMetadata, Headers> option with get, set
    abstract member customMetadata: R2PutOptions.customMetadata option with get, set
    abstract member md5: U2<U2<ArrayBuffer, ArrayBufferView>, string> option with get, set
    abstract member sha1: U2<U2<ArrayBuffer, ArrayBufferView>, string> option with get, set
    abstract member sha256: U2<U2<ArrayBuffer, ArrayBufferView>, string> option with get, set
    abstract member sha384: U2<U2<ArrayBuffer, ArrayBufferView>, string> option with get, set
    abstract member sha512: U2<U2<ArrayBuffer, ArrayBufferView>, string> option with get, set
    abstract member storageClass: string option with get, set
    abstract member ssecKey: U2<ArrayBuffer, string> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type R2MultipartOptions =
    abstract member httpMetadata: U2<R2HTTPMetadata, Headers> option with get, set
    abstract member customMetadata: R2MultipartOptions.customMetadata option with get, set
    abstract member storageClass: string option with get, set
    abstract member ssecKey: U2<ArrayBuffer, string> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type R2Checksums =
    abstract member md5: ArrayBuffer option with get
    abstract member sha1: ArrayBuffer option with get
    abstract member sha256: ArrayBuffer option with get
    abstract member sha384: ArrayBuffer option with get
    abstract member sha512: ArrayBuffer option with get
    abstract member toJSON: unit -> R2StringChecksums

[<AllowNullLiteral>]
[<Interface>]
type R2StringChecksums =
    abstract member md5: string option with get, set
    abstract member sha1: string option with get, set
    abstract member sha256: string option with get, set
    abstract member sha384: string option with get, set
    abstract member sha512: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type R2HTTPMetadata =
    abstract member contentType: string option with get, set
    abstract member contentLanguage: string option with get, set
    abstract member contentDisposition: string option with get, set
    abstract member contentEncoding: string option with get, set
    abstract member cacheControl: string option with get, set
    abstract member cacheExpiry: JS.Date option with get, set

[<AllowNullLiteral>]
[<Interface>]
type R2Objects =
    abstract member objects: ResizeArray<R2Object> with get, set
    abstract member delimitedPrefixes: ResizeArray<string> with get, set
    abstract member truncated: bool with get, set
    abstract member cursor: string with get, set
    abstract member truncated: bool with get, set

[<AllowNullLiteral>]
[<Interface>]
type R2UploadPartOptions =
    abstract member ssecKey: U2<ArrayBuffer, string> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type ScheduledEvent =
    inherit ExtendableEvent
    abstract member scheduledTime: float with get
    abstract member cron: string with get
    abstract member noRetry: unit -> unit

[<AllowNullLiteral>]
[<Interface>]
type ScheduledController =
    abstract member scheduledTime: float with get
    abstract member cron: string with get
    abstract member noRetry: unit -> unit

[<AllowNullLiteral>]
[<Interface>]
type QueuingStrategy<'T> =
    abstract member highWaterMark: U2<float, obj> option with get, set
    abstract member size: ('T -> U2<float, obj>) option with get, set

[<AllowNullLiteral>]
[<Interface>]
type UnderlyingSink<'W> =
    abstract member ``type``: string option with get, set
    abstract member start: (WritableStreamDefaultController -> U2<unit, JS.Promise<unit>>) option with get, set
    abstract member write: UnderlyingSink.write<'W> option with get, set
    abstract member abort: (obj -> U2<unit, JS.Promise<unit>>) option with get, set
    abstract member close: (unit -> U2<unit, JS.Promise<unit>>) option with get, set

[<AllowNullLiteral>]
[<Interface>]
type UnderlyingByteSource =
    abstract member ``type``: string with get, set
    abstract member autoAllocateChunkSize: float option with get, set
    abstract member start: (ReadableByteStreamController -> U2<unit, JS.Promise<unit>>) option with get, set
    abstract member pull: (ReadableByteStreamController -> U2<unit, JS.Promise<unit>>) option with get, set
    abstract member cancel: (obj -> U2<unit, JS.Promise<unit>>) option with get, set

[<AllowNullLiteral>]
[<Interface>]
type UnderlyingSource<'R> =
    abstract member ``type``: string option with get, set
    abstract member start: (ReadableStreamDefaultController<'R> -> U2<unit, JS.Promise<unit>>) option with get, set
    abstract member pull: (ReadableStreamDefaultController<'R> -> U2<unit, JS.Promise<unit>>) option with get, set
    abstract member cancel: (obj -> U2<unit, JS.Promise<unit>>) option with get, set
    abstract member expectedLength: U2<float, obj> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Transformer<'I, 'O> =
    abstract member readableType: string option with get, set
    abstract member writableType: string option with get, set
    abstract member start: (TransformStreamDefaultController<'O> -> U2<unit, JS.Promise<unit>>) option with get, set
    abstract member transform: Transformer.transform<'I> option with get, set
    abstract member flush: (TransformStreamDefaultController<'O> -> U2<unit, JS.Promise<unit>>) option with get, set
    abstract member cancel: (obj -> U2<unit, JS.Promise<unit>>) option with get, set
    abstract member expectedLength: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type StreamPipeOptions =
    abstract member preventAbort: bool option with get, set
    abstract member preventCancel: bool option with get, set
    /// <summary>
    /// Pipes this readable stream to a given writable stream destination. The way in which the piping process behaves under various error conditions can be customized with a number of passed options. It returns a promise that fulfills when the piping process completes successfully, or rejects if any errors were encountered.
    ///
    /// Piping a stream will lock it for the duration of the pipe, preventing any other consumer from acquiring a reader.
    ///
    /// Errors and closures of the source and destination streams propagate as follows:
    ///
    /// An error in this source readable stream will abort destination, unless preventAbort is truthy. The returned promise will be rejected with the source's error, or with any error that occurs during aborting the destination.
    ///
    /// An error in destination will cancel this source readable stream, unless preventCancel is truthy. The returned promise will be rejected with the destination's error, or with any error that occurs during canceling the source.
    ///
    /// When this source readable stream closes, destination will be closed, unless preventClose is truthy. The returned promise will be fulfilled once this process completes, unless an error is encountered while closing the destination, in which case it will be rejected with that error.
    ///
    /// If destination starts out closed or closing, this source readable stream will be canceled, unless preventCancel is true. The returned promise will be rejected with an error indicating piping to a closed stream failed, or with any error that occurs during canceling the source.
    ///
    /// The signal option can be set to an AbortSignal to allow aborting an ongoing pipe operation via the corresponding AbortController. In this case, this source readable stream will be canceled, and destination aborted, unless the respective options preventCancel or preventAbort are set.
    /// </summary>
    abstract member preventClose: bool option with get, set
    abstract member signal: AbortSignal option with get, set

[<AllowNullLiteral>]
[<Interface>]
type ReadableStreamReadResult =
    abstract member ``done``: bool with get, set
    abstract member value: 'R with get, set
    abstract member ``done``: bool with get, set
    abstract member value: obj option with get, set

[<AllowNullLiteral>]
[<Interface>]
type ReadableStream<'R> =
    /// <summary>
    /// The **<c>locked</c>** read-only property of the ReadableStream interface returns whether or not the readable stream is locked to a reader.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/ReadableStream/locked)
    /// </summary>
    abstract member locked: bool with get
    /// <summary>
    /// The **<c>cancel()</c>** method of the ReadableStream interface returns a Promise that resolves when the stream is canceled.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/ReadableStream/cancel)
    /// </summary>
    abstract member cancel: ?reason: obj -> JS.Promise<unit>
    /// <summary>
    /// The **<c>getReader()</c>** method of the ReadableStream interface creates a reader and locks the stream to it.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/ReadableStream/getReader)
    /// </summary>
    abstract member getReader: unit -> obj
    [<Emit("$0($1...)")>]
    abstract member Invoke: unit -> unit
    /// <summary>
    /// The **<c>getReader()</c>** method of the ReadableStream interface creates a reader and locks the stream to it.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/ReadableStream/getReader)
    /// </summary>
    abstract member getReader: options: ReadableStreamGetReaderOptions -> obj
    /// <summary>
    /// The **<c>pipeThrough()</c>** method of the ReadableStream interface provides a chainable way of piping the current stream through a transform stream or any other writable/readable pair.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/ReadableStream/pipeThrough)
    /// </summary>
    abstract member pipeThrough: transform: obj * _EMPTY_: unit * T: unit * R: unit -> unit


























/// <summary>
/// The **<c>ReadableStreamDefaultReader</c>** interface of the Streams API represents a default reader that can be used to read stream data supplied from a network (such as a fetch request).
///
/// [MDN Reference](https://developer.mozilla.org/docs/Web/API/ReadableStreamDefaultReader)
/// </summary>
[<AllowNullLiteral>]
[<Interface>]
type ReadableStreamDefaultReader<'R> =
    abstract member closed: JS.Promise<unit> with get
    abstract member cancel: ?reason: obj -> JS.Promise<unit>
    /// <summary>
    /// The **<c>read()</c>** method of the ReadableStreamDefaultReader interface returns a Promise providing access to the next chunk in the stream's internal queue.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/ReadableStreamDefaultReader/read)
    /// </summary>
    abstract member read: unit -> JS.Promise<ReadableStreamReadResult<'R>>
    /// <summary>
    /// The **<c>releaseLock()</c>** method of the ReadableStreamDefaultReader interface releases the reader's lock on the stream.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/ReadableStreamDefaultReader/releaseLock)
    /// </summary>
    abstract member releaseLock: unit -> unit

type ReadableStreamDefaultReader =
    ReadableStreamDefaultReader<obj>

/// <summary>
/// The <c>ReadableStreamBYOBReader</c> interface of the Streams API defines a reader for a ReadableStream that supports zero-copy reading from an underlying byte source.
///
/// [MDN Reference](https://developer.mozilla.org/docs/Web/API/ReadableStreamBYOBReader)
/// </summary>
[<AllowNullLiteral>]
[<Interface>]
type ReadableStreamBYOBReader =
    abstract member closed: JS.Promise<unit> with get
    abstract member cancel: ?reason: obj -> JS.Promise<unit>
    /// <summary>
    /// The **<c>read()</c>** method of the ReadableStreamBYOBReader interface is used to read data into a view on a user-supplied buffer from an associated readable byte stream.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/ReadableStreamBYOBReader/read)
    /// </summary>
    abstract member read: view: 'T -> JS.Promise<ReadableStreamReadResult<'T>>
    /// <summary>
    /// The **<c>releaseLock()</c>** method of the ReadableStreamBYOBReader interface releases the reader's lock on the stream.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/ReadableStreamBYOBReader/releaseLock)
    /// </summary>
    abstract member releaseLock: unit -> unit
    abstract member readAtLeast: minElements: float * view: 'T -> JS.Promise<ReadableStreamReadResult<'T>>

[<AllowNullLiteral>]
[<Interface>]
type ReadableStreamBYOBReaderReadableStreamBYOBReaderReadOptions =
    abstract member min: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type ReadableStreamGetReaderOptions =
    /// <summary>
    /// Creates a ReadableStreamBYOBReader and locks the stream to the new reader.
    ///
    /// This call behaves the same way as the no-argument variant, except that it only works on readable byte streams, i.e. streams which were constructed specifically with the ability to handle "bring your own buffer" reading. The returned BYOB reader provides the ability to directly read individual chunks from the stream via its read() method, into developer-supplied buffers, allowing more precise control over allocation.
    /// </summary>
    abstract member mode: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type ReadableStreamBYOBRequest =
    /// <summary>
    /// The **<c>view</c>** getter property of the ReadableStreamBYOBRequest interface returns the current view.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/ReadableStreamBYOBRequest/view)
    /// </summary>
    abstract member view: U2<JS.Uint8Array, obj> with get
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/ReadableStreamBYOBRequest/respond)
    /// The **<c>respond()</c>** method of the ReadableStreamBYOBRequest interface is used to signal to the associated readable byte stream that the specified number of bytes were written into the ReadableStreamBYOBRequest.view.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/ReadableStreamBYOBRequest/respond)
    /// </summary>
    abstract member respond: bytesWritten: float -> unit
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/ReadableStreamBYOBRequest/respondWithNewView)
    /// The **<c>respondWithNewView()</c>** method of the ReadableStreamBYOBRequest interface specifies a new view that the consumer of the associated readable byte stream should write to instead of ReadableStreamBYOBRequest.view.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/ReadableStreamBYOBRequest/respondWithNewView)
    /// </summary>
    abstract member respondWithNewView: view: U2<ArrayBuffer, ArrayBufferView> -> unit
    abstract member atLeast: U2<float, obj> with get

[<AllowNullLiteral>]
[<Interface>]
type ReadableStreamDefaultController<'R> =
    /// <summary>
    /// The **<c>desiredSize</c>** read-only property of the required to fill the stream's internal queue.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/ReadableStreamDefaultController/desiredSize)
    /// </summary>
    abstract member desiredSize: U2<float, obj> with get
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/ReadableStreamDefaultController/close)
    /// The **<c>close()</c>** method of the ReadableStreamDefaultController interface closes the associated stream.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/ReadableStreamDefaultController/close)
    /// </summary>
    abstract member close: unit -> unit
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/ReadableStreamDefaultController/enqueue)
    /// The **<c>enqueue()</c>** method of the <code lang="js-nolint"> enqueue(chunk) </code> - <c>chunk</c> - : The chunk to enqueue.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/ReadableStreamDefaultController/enqueue)
    /// </summary>
    abstract member enqueue: ?chunk: 'R -> unit
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/ReadableStreamDefaultController/error)
    /// The **<c>error()</c>** method of the with the associated stream to error.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/ReadableStreamDefaultController/error)
    /// </summary>
    abstract member error: reason: obj -> unit

[<AllowNullLiteral>]
[<Interface>]
type ReadableByteStreamController =
    /// <summary>
    /// The **<c>byobRequest</c>** read-only property of the ReadableByteStreamController interface returns the current BYOB request, or <c>null</c> if there are no pending requests.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/ReadableByteStreamController/byobRequest)
    /// </summary>
    abstract member byobRequest: U2<ReadableStreamBYOBRequest, obj> with get
    /// <summary>
    /// The **<c>desiredSize</c>** read-only property of the ReadableByteStreamController interface returns the number of bytes required to fill the stream's internal queue to its 'desired size'.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/ReadableByteStreamController/desiredSize)
    /// </summary>
    abstract member desiredSize: U2<float, obj> with get
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/ReadableByteStreamController/close)
    /// The **<c>close()</c>** method of the ReadableByteStreamController interface closes the associated stream.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/ReadableByteStreamController/close)
    /// </summary>
    abstract member close: unit -> unit
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/ReadableByteStreamController/enqueue)
    /// The **<c>enqueue()</c>** method of the ReadableByteStreamController interface enqueues a given chunk on the associated readable byte stream (the chunk is copied into the stream's internal queues).
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/ReadableByteStreamController/enqueue)
    /// </summary>
    abstract member enqueue: chunk: U2<ArrayBuffer, ArrayBufferView> -> unit
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/ReadableByteStreamController/error)
    /// The **<c>error()</c>** method of the ReadableByteStreamController interface causes any future interactions with the associated stream to error with the specified reason.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/ReadableByteStreamController/error)
    /// </summary>
    abstract member error: reason: obj -> unit

[<AllowNullLiteral>]
[<Interface>]
type WritableStreamDefaultController =
    /// <summary>
    /// The read-only **<c>signal</c>** property of the WritableStreamDefaultController interface returns the AbortSignal associated with the controller.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/WritableStreamDefaultController/signal)
    /// </summary>
    abstract member signal: AbortSignal with get
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/WritableStreamDefaultController/error)
    /// The **<c>error()</c>** method of the with the associated stream to error.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/WritableStreamDefaultController/error)
    /// </summary>
    abstract member error: ?reason: obj -> unit

[<AllowNullLiteral>]
[<Interface>]
type TransformStreamDefaultController<'O> =
    /// <summary>
    /// The **<c>desiredSize</c>** read-only property of the TransformStreamDefaultController interface returns the desired size to fill the queue of the associated ReadableStream.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/TransformStreamDefaultController/desiredSize)
    /// </summary>
    abstract member desiredSize: U2<float, obj> with get
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/TransformStreamDefaultController/enqueue)
    /// The **<c>enqueue()</c>** method of the TransformStreamDefaultController interface enqueues the given chunk in the readable side of the stream.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/TransformStreamDefaultController/enqueue)
    /// </summary>
    abstract member enqueue: ?chunk: 'O -> unit
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/TransformStreamDefaultController/error)
    /// The **<c>error()</c>** method of the TransformStreamDefaultController interface errors both sides of the stream.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/TransformStreamDefaultController/error)
    /// </summary>
    abstract member error: reason: obj -> unit
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/TransformStreamDefaultController/terminate)
    /// The **<c>terminate()</c>** method of the TransformStreamDefaultController interface closes the readable side and errors the writable side of the stream.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/TransformStreamDefaultController/terminate)
    /// </summary>
    abstract member terminate: unit -> unit

[<AllowNullLiteral>]
[<Interface>]
type ReadableWritablePair<'R, 'W> =
    abstract member readable: obj with get, set
    [<Emit("$0($1...)")>]
    abstract member Invoke: unit -> unit
    /// <summary>
    /// Provides a convenient, chainable way of piping this readable stream through a transform stream (or any other { writable, readable } pair). It simply pipes the stream into the writable side of the supplied pair, and returns the readable side for further use.
    ///
    /// Piping a stream will lock it for the duration of the pipe, preventing any other consumer from acquiring a reader.
    /// </summary>
    abstract member writable: obj with get, set
    [<Emit("$0($1...)")>]
    abstract member Invoke: unit -> unit

/// <summary>
/// The **<c>WritableStream</c>** interface of the Streams API provides a standard abstraction for writing streaming data to a destination, known as a sink.
///
/// [MDN Reference](https://developer.mozilla.org/docs/Web/API/WritableStream)
/// </summary>
[<AllowNullLiteral>]
[<Interface>]
type WritableStream<'W> =
    /// <summary>
    /// The **<c>locked</c>** read-only property of the WritableStream interface returns a boolean indicating whether the <c>WritableStream</c> is locked to a writer.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/WritableStream/locked)
    /// </summary>
    abstract member locked: bool with get
    /// <summary>
    /// The **<c>abort()</c>** method of the WritableStream interface aborts the stream, signaling that the producer can no longer successfully write to the stream and it is to be immediately moved to an error state, with any queued writes discarded.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/WritableStream/abort)
    /// </summary>
    abstract member abort: ?reason: obj -> JS.Promise<unit>
    /// <summary>
    /// The **<c>close()</c>** method of the WritableStream interface closes the associated stream.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/WritableStream/close)
    /// </summary>
    abstract member close: unit -> JS.Promise<unit>
    /// <summary>
    /// The **<c>getWriter()</c>** method of the WritableStream interface returns a new instance of any /* cycle: WritableStreamDefaultWriter
    /// </summary>
    abstract member ``and``: unit with get, set
    abstract member locks: unit with get, set
    abstract member the: unit with get, set
    abstract member stream: unit with get, set
    abstract member ``to``: unit with get, set
    abstract member that: unit with get, set
    abstract member instance: unit with get, set
    abstract member _EMPTY_: unit -> unit
    abstract member [MDN: unit -> unit
    abstract member Reference: unit with get, set

type WritableStream =
    WritableStream<obj>





/// <summary>
/// The **<c>WritableStreamDefaultWriter</c>** interface of the Streams API is the object returned by WritableStream.getWriter() and once created locks the writer to the <c>WritableStream</c> ensuring that no other streams can write to the underlying sink.
///
/// [MDN Reference](https://developer.mozilla.org/docs/Web/API/WritableStreamDefaultWriter)
/// </summary>
[<AllowNullLiteral>]
[<Interface>]
type WritableStreamDefaultWriter<'W> =
    /// <summary>
    /// The **<c>closed</c>** read-only property of the the stream errors or the writer's lock is released.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/WritableStreamDefaultWriter/closed)
    /// </summary>
    abstract member closed: JS.Promise<unit> with get
    /// <summary>
    /// The **<c>ready</c>** read-only property of the that resolves when the desired size of the stream's internal queue transitions from non-positive to positive, signaling that it is no longer applying backpressure.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/WritableStreamDefaultWriter/ready)
    /// </summary>
    abstract member ready: JS.Promise<unit> with get
    /// <summary>
    /// The **<c>desiredSize</c>** read-only property of the to fill the stream's internal queue.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/WritableStreamDefaultWriter/desiredSize)
    /// </summary>
    abstract member desiredSize: U2<float, obj> with get
    /// <summary>
    /// The **<c>abort()</c>** method of the the producer can no longer successfully write to the stream and it is to be immediately moved to an error state, with any queued writes discarded.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/WritableStreamDefaultWriter/abort)
    /// </summary>
    abstract member abort: ?reason: obj -> JS.Promise<unit>
    /// <summary>
    /// The **<c>close()</c>** method of the stream.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/WritableStreamDefaultWriter/close)
    /// </summary>
    abstract member close: unit -> JS.Promise<unit>
    /// <summary>
    /// The **<c>write()</c>** method of the operation.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/WritableStreamDefaultWriter/write)
    /// </summary>
    abstract member write: ?chunk: 'W -> JS.Promise<unit>
    /// <summary>
    /// The **<c>releaseLock()</c>** method of the corresponding stream.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/WritableStreamDefaultWriter/releaseLock)
    /// </summary>
    abstract member releaseLock: unit -> unit

type WritableStreamDefaultWriter =
    WritableStreamDefaultWriter<obj>

/// <summary>
/// The **<c>TransformStream</c>** interface of the Streams API represents a concrete implementation of the pipe chain _transform stream_ concept.
///
/// [MDN Reference](https://developer.mozilla.org/docs/Web/API/TransformStream)
/// </summary>
[<AllowNullLiteral>]
[<Interface>]
type TransformStream<'I, 'O> =
    /// <summary>
    /// The **<c>readable</c>** read-only property of the TransformStream interface returns the ReadableStream instance controlled by this <c>TransformStream</c>.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/TransformStream/readable)
    /// </summary>
    abstract member readable: ReadableStream<'O> with get
    /// <summary>
    /// The **<c>writable</c>** read-only property of the TransformStream interface returns the WritableStream instance controlled by this <c>TransformStream</c>.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/TransformStream/writable)
    /// </summary>
    abstract member writable: WritableStream<'I> with get

type TransformStream<'I> =
    TransformStream<'I, obj>

type TransformStream =
    TransformStream<obj, obj>

[<AllowNullLiteral>]
[<Interface>]
type FixedLengthStream =
    inherit IdentityTransformStream

[<AllowNullLiteral>]
[<Interface>]
type IdentityTransformStream =
    inherit TransformStream<U2<ArrayBuffer, ArrayBufferView>, JS.Uint8Array>

[<AllowNullLiteral>]
[<Interface>]
type IdentityTransformStreamQueuingStrategy =
    abstract member highWaterMark: U2<float, obj> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type ReadableStreamValuesOptions =
    abstract member preventCancel: bool option with get, set

/// <summary>
/// The **<c>CompressionStream</c>** interface of the Compression Streams API is an API for compressing a stream of data.
///
/// [MDN Reference](https://developer.mozilla.org/docs/Web/API/CompressionStream)
/// </summary>
[<AllowNullLiteral>]
[<Interface>]
type CompressionStream =
    inherit TransformStream<U2<ArrayBuffer, ArrayBufferView>, JS.Uint8Array>

/// <summary>
/// The **<c>DecompressionStream</c>** interface of the Compression Streams API is an API for decompressing a stream of data.
///
/// [MDN Reference](https://developer.mozilla.org/docs/Web/API/DecompressionStream)
/// </summary>
[<AllowNullLiteral>]
[<Interface>]
type DecompressionStream =
    inherit TransformStream<U2<ArrayBuffer, ArrayBufferView>, JS.Uint8Array>

/// <summary>
/// The **<c>TextEncoderStream</c>** interface of the Encoding API converts a stream of strings into bytes in the UTF-8 encoding.
///
/// [MDN Reference](https://developer.mozilla.org/docs/Web/API/TextEncoderStream)
/// </summary>
[<AllowNullLiteral>]
[<Interface>]
type TextEncoderStream =
    inherit TransformStream<string, JS.Uint8Array>
    abstract member encoding: string with get

/// <summary>
/// The **<c>TextDecoderStream</c>** interface of the Encoding API converts a stream of text in a binary encoding, such as UTF-8 etc., to a stream of strings.
///
/// [MDN Reference](https://developer.mozilla.org/docs/Web/API/TextDecoderStream)
/// </summary>
[<AllowNullLiteral>]
[<Interface>]
type TextDecoderStream =
    inherit TransformStream<U2<ArrayBuffer, ArrayBufferView>, string>
    abstract member encoding: string with get
    abstract member fatal: bool with get
    abstract member ignoreBOM: bool with get

[<AllowNullLiteral>]
[<Interface>]
type TextDecoderStreamTextDecoderStreamInit =
    abstract member fatal: bool option with get, set
    abstract member ignoreBOM: bool option with get, set

/// <summary>
/// The **<c>ByteLengthQueuingStrategy</c>** interface of the Streams API provides a built-in byte length queuing strategy that can be used when constructing streams.
///
/// [MDN Reference](https://developer.mozilla.org/docs/Web/API/ByteLengthQueuingStrategy)
/// </summary>
[<AllowNullLiteral>]
[<Interface>]
type ByteLengthQueuingStrategy =
    inherit QueuingStrategy<ArrayBufferView>
    /// <summary>
    /// The read-only **<c>ByteLengthQueuingStrategy.highWaterMark</c>** property returns the total number of bytes that can be contained in the internal queue before backpressure is applied.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/ByteLengthQueuingStrategy/highWaterMark)
    /// </summary>
    abstract member highWaterMark: float with get
    abstract member size: (obj option -> float) with get

/// <summary>
/// The **<c>CountQueuingStrategy</c>** interface of the Streams API provides a built-in chunk counting queuing strategy that can be used when constructing streams.
///
/// [MDN Reference](https://developer.mozilla.org/docs/Web/API/CountQueuingStrategy)
/// </summary>
[<AllowNullLiteral>]
[<Interface>]
type CountQueuingStrategy =
    inherit QueuingStrategy
    /// <summary>
    /// The read-only **<c>CountQueuingStrategy.highWaterMark</c>** property returns the total number of chunks that can be contained in the internal queue before backpressure is applied.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/CountQueuingStrategy/highWaterMark)
    /// </summary>
    abstract member highWaterMark: float with get
    abstract member size: (obj option -> float) with get

[<AllowNullLiteral>]
[<Interface>]
type QueuingStrategyInit =
    /// <summary>
    /// Creates a new ByteLengthQueuingStrategy with the provided high water mark.
    ///
    /// Note that the provided high water mark will not be validated ahead of time. Instead, if it is negative, NaN, or not a number, the resulting ByteLengthQueuingStrategy will cause the corresponding stream constructor to throw.
    /// </summary>
    abstract member highWaterMark: float with get, set

[<AllowNullLiteral>]
[<Interface>]
type ScriptVersion =
    abstract member id: string option with get, set
    abstract member tag: string option with get, set
    abstract member message: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type TailEvent =
    inherit ExtendableEvent
    abstract member events: ResizeArray<TraceItem> with get
    abstract member traces: ResizeArray<TraceItem> with get

[<AllowNullLiteral>]
[<Interface>]
type TraceItem =
    abstract member event: U2<U9<TraceItemFetchEventInfo, TraceItemJsRpcEventInfo, TraceItemScheduledEventInfo, TraceItemAlarmEventInfo, TraceItemQueueEventInfo, TraceItemEmailEventInfo, TraceItemTailEventInfo, TraceItemCustomEventInfo, TraceItemHibernatableWebSocketEventInfo>, obj> with get
    abstract member eventTimestamp: U2<float, obj> with get
    abstract member logs: ResizeArray<TraceLog> with get
    abstract member exceptions: ResizeArray<TraceException> with get
    abstract member diagnosticsChannelEvents: ResizeArray<TraceDiagnosticChannelEvent> with get
    abstract member scriptName: U2<string, obj> with get
    abstract member entrypoint: string option with get
    abstract member scriptVersion: ScriptVersion option with get
    abstract member dispatchNamespace: string option with get
    abstract member scriptTags: ResizeArray<string> option with get
    abstract member durableObjectId: string option with get
    abstract member outcome: string with get
    abstract member executionModel: string with get
    abstract member truncated: bool with get
    abstract member cpuTime: float with get
    abstract member wallTime: float with get

[<AllowNullLiteral>]
[<Interface>]
type TraceItemAlarmEventInfo =
    abstract member scheduledTime: JS.Date with get

[<AllowNullLiteral>]
[<Interface>]
type TraceItemCustomEventInfo =
    interface end

[<AllowNullLiteral>]
[<Interface>]
type TraceItemScheduledEventInfo =
    abstract member scheduledTime: float with get
    abstract member cron: string with get

[<AllowNullLiteral>]
[<Interface>]
type TraceItemQueueEventInfo =
    abstract member queue: string with get
    abstract member batchSize: float with get

[<AllowNullLiteral>]
[<Interface>]
type TraceItemEmailEventInfo =
    abstract member mailFrom: string with get
    abstract member rcptTo: string with get
    abstract member rawSize: float with get

[<AllowNullLiteral>]
[<Interface>]
type TraceItemTailEventInfo =
    abstract member consumedEvents: ResizeArray<TraceItemTailEventInfoTailItem> with get

[<AllowNullLiteral>]
[<Interface>]
type TraceItemTailEventInfoTailItem =
    abstract member scriptName: U2<string, obj> with get

[<AllowNullLiteral>]
[<Interface>]
type TraceItemFetchEventInfo =
    abstract member response: TraceItemFetchEventInfoResponse option with get
    abstract member request: TraceItemFetchEventInfoRequest with get

[<AllowNullLiteral>]
[<Interface>]
type TraceItemFetchEventInfoRequest =
    abstract member cf: obj option with get
    abstract member headers: TraceItemFetchEventInfoRequest.headers with get
    abstract member ``method``: string with get
    abstract member url: string with get
    abstract member getUnredacted: unit -> TraceItemFetchEventInfoRequest

[<AllowNullLiteral>]
[<Interface>]
type TraceItemFetchEventInfoResponse =
    abstract member status: float with get

[<AllowNullLiteral>]
[<Interface>]
type TraceItemJsRpcEventInfo =
    abstract member rpcMethod: string with get

[<AllowNullLiteral>]
[<Interface>]
type TraceItemHibernatableWebSocketEventInfo =
    abstract member getWebSocketEvent: U3<TraceItemHibernatableWebSocketEventInfoMessage, TraceItemHibernatableWebSocketEventInfoClose, TraceItemHibernatableWebSocketEventInfoError> with get

[<AllowNullLiteral>]
[<Interface>]
type TraceItemHibernatableWebSocketEventInfoMessage =
    abstract member webSocketEventType: string with get

[<AllowNullLiteral>]
[<Interface>]
type TraceItemHibernatableWebSocketEventInfoClose =
    abstract member webSocketEventType: string with get
    abstract member code: float with get
    abstract member wasClean: bool with get

[<AllowNullLiteral>]
[<Interface>]
type TraceItemHibernatableWebSocketEventInfoError =
    abstract member webSocketEventType: string with get

[<AllowNullLiteral>]
[<Interface>]
type TraceLog =
    abstract member timestamp: float with get
    abstract member level: string with get
    abstract member message: obj with get

[<AllowNullLiteral>]
[<Interface>]
type TraceException =
    abstract member timestamp: float with get
    abstract member message: string with get
    abstract member name: string with get
    abstract member stack: string option with get

[<AllowNullLiteral>]
[<Interface>]
type TraceDiagnosticChannelEvent =
    abstract member timestamp: float with get
    abstract member channel: string with get
    abstract member message: obj with get

[<AllowNullLiteral>]
[<Interface>]
type TraceMetrics =
    abstract member cpuTime: float with get
    abstract member wallTime: float with get

[<AllowNullLiteral>]
[<Interface>]
type UnsafeTraceMetrics =
    abstract member fromTrace: item: TraceItem -> TraceMetrics

/// <summary>
/// The **<c>URL</c>** interface is used to parse, construct, normalize, and encode URL.
///
/// [MDN Reference](https://developer.mozilla.org/docs/Web/API/URL)
/// </summary>
[<AllowNullLiteral>]
[<Interface>]
type URL =
    /// <summary>
    /// The **<c>href</c>** property of the URL interface is a string containing the whole URL.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/URL/href)
    /// </summary>
    abstract member href: string with get, set
    /// <summary>
    /// The **<c>origin</c>** read-only property of the URL interface returns a string containing the Unicode serialization of the origin of the represented URL.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/URL/origin)
    /// </summary>
    abstract member origin: string with get
    /// <summary>
    /// The **<c>protocol</c>** property of the URL interface is a string containing the protocol or scheme of the URL, including the final <c>':'</c>.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/URL/protocol)
    /// </summary>
    abstract member protocol: string with get, set
    /// <summary>
    /// The **<c>username</c>** property of the URL interface is a string containing the username component of the URL.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/URL/username)
    /// </summary>
    abstract member username: string with get, set
    /// <summary>
    /// The **<c>password</c>** property of the URL interface is a string containing the password component of the URL.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/URL/password)
    /// </summary>
    abstract member password: string with get, set
    /// <summary>
    /// The **<c>host</c>** property of the URL interface is a string containing the host, which is the URL.hostname, and then, if the port of the URL is nonempty, a <c>':'</c>, followed by the URL.port of the URL.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/URL/host)
    /// </summary>
    abstract member host: string with get, set
    /// <summary>
    /// The **<c>hostname</c>** property of the URL interface is a string containing either the domain name or IP address of the URL.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/URL/hostname)
    /// </summary>
    abstract member hostname: string with get, set
    /// <summary>
    /// The **<c>port</c>** property of the URL interface is a string containing the port number of the URL.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/URL/port)
    /// </summary>
    abstract member port: string with get, set
    /// <summary>
    /// The **<c>pathname</c>** property of the URL interface represents a location in a hierarchical structure.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/URL/pathname)
    /// </summary>
    abstract member pathname: string with get, set
    /// <summary>
    /// The **<c>search</c>** property of the URL interface is a search string, also called a _query string_, that is a string containing a <c>'?'</c> followed by the parameters of the URL.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/URL/search)
    /// </summary>
    abstract member search: string with get, set
    /// <summary>
    /// The **<c>searchParams</c>** read-only property of the access to the [MISSING: httpmethod('GET')] decoded query arguments contained in the URL.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/URL/searchParams)
    /// </summary>
    abstract member searchParams: URLSearchParams with get
    /// <summary>
    /// The **<c>hash</c>** property of the URL interface is a string containing a <c>'#'</c> followed by the fragment identifier of the URL.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/URL/hash)
    /// </summary>
    abstract member hash: string with get, set
    abstract member toString: unit -> string
    /// <summary>
    /// The **<c>toJSON()</c>** method of the URL interface returns a string containing a serialized version of the URL, although in practice it seems to have the same effect as <code lang="js-nolint"> toJSON() </code> None.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/URL/toJSON)
    /// </summary>
    abstract member toJSON: unit -> string

/// <summary>
/// The **<c>URLSearchParams</c>** interface defines utility methods to work with the query string of a URL.
///
/// [MDN Reference](https://developer.mozilla.org/docs/Web/API/URLSearchParams)
/// </summary>
[<AllowNullLiteral>]
[<Interface>]
type URLSearchParams =
    /// <summary>
    /// The **<c>size</c>** read-only property of the URLSearchParams interface indicates the total number of search parameter entries.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/URLSearchParams/size)
    /// </summary>
    abstract member size: float with get
    /// <summary>
    /// The **<c>append()</c>** method of the URLSearchParams interface appends a specified key/value pair as a new search parameter.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/URLSearchParams/append)
    /// </summary>
    abstract member append: name: string * value: string -> unit
    /// <summary>
    /// The **<c>delete()</c>** method of the URLSearchParams interface deletes specified parameters and their associated value(s) from the list of all search parameters.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/URLSearchParams/delete)
    /// </summary>
    abstract member delete: name: string -> unit
    /// <summary>
    /// The **<c>get()</c>** method of the URLSearchParams interface returns the first value associated to the given search parameter.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/URLSearchParams/get)
    /// </summary>
    abstract member get: name: string -> U2<string, obj>
    /// <summary>
    /// The **<c>getAll()</c>** method of the URLSearchParams interface returns all the values associated with a given search parameter as an array.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/URLSearchParams/getAll)
    /// </summary>
    abstract member getAll: name: string -> ResizeArray<string>
    /// <summary>
    /// The **<c>has()</c>** method of the URLSearchParams interface returns a boolean value that indicates whether the specified parameter is in the search parameters.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/URLSearchParams/has)
    /// </summary>
    abstract member has: name: string -> bool
    /// <summary>
    /// The **<c>set()</c>** method of the URLSearchParams interface sets the value associated with a given search parameter to the given value.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/URLSearchParams/set)
    /// </summary>
    abstract member set: name: string * value: string -> unit
    /// <summary>
    /// The **<c>URLSearchParams.sort()</c>** method sorts all key/value pairs contained in this object in place and returns <c>undefined</c>.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/URLSearchParams/sort)
    /// </summary>
    abstract member sort: unit -> unit
    abstract member entries: unit -> IterableIterator<string * string>
    abstract member keys: unit -> IterableIterator<string>
    abstract member values: unit -> IterableIterator<string>
    abstract member forEach: callback: URLSearchParams.forEach.callback * ?thisArg: 'This -> unit
    abstract member toString: unit -> string

[<AllowNullLiteral>]
[<Interface>]
type URLPattern =
    abstract member protocol: string with get
    abstract member username: string with get
    abstract member password: string with get
    abstract member hostname: string with get
    abstract member port: string with get
    abstract member pathname: string with get
    abstract member search: string with get
    abstract member hash: string with get
    abstract member test: ?input: U2<string, URLPatternInit> * ?baseURL: string -> bool
    abstract member exec: ?input: U2<string, URLPatternInit> * ?baseURL: string -> U2<URLPatternResult, obj>

[<AllowNullLiteral>]
[<Interface>]
type URLPatternInit =
    abstract member protocol: string option with get, set
    abstract member username: string option with get, set
    abstract member password: string option with get, set
    abstract member hostname: string option with get, set
    abstract member port: string option with get, set
    abstract member pathname: string option with get, set
    abstract member search: string option with get, set
    abstract member hash: string option with get, set
    abstract member baseURL: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type URLPatternComponentResult =
    abstract member input: string with get, set
    abstract member groups: URLPatternComponentResult.groups with get, set

[<AllowNullLiteral>]
[<Interface>]
type URLPatternResult =
    abstract member inputs: ResizeArray<U2<string, URLPatternInit>> with get, set
    abstract member protocol: URLPatternComponentResult with get, set
    abstract member username: URLPatternComponentResult with get, set
    abstract member password: URLPatternComponentResult with get, set
    abstract member hostname: URLPatternComponentResult with get, set
    abstract member port: URLPatternComponentResult with get, set
    abstract member pathname: URLPatternComponentResult with get, set
    abstract member search: URLPatternComponentResult with get, set
    abstract member hash: URLPatternComponentResult with get, set

[<AllowNullLiteral>]
[<Interface>]
type URLPatternOptions =
    abstract member ignoreCase: bool option with get, set

/// <summary>
/// A <c>CloseEvent</c> is sent to clients using WebSockets when the connection is closed.
///
/// [MDN Reference](https://developer.mozilla.org/docs/Web/API/CloseEvent)
/// </summary>
[<AllowNullLiteral>]
[<Interface>]
type CloseEvent =
    inherit Event
    /// <summary>
    /// The **<c>code</c>** read-only property of the CloseEvent interface returns a WebSocket connection close code indicating the reason the connection was closed.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/CloseEvent/code)
    /// </summary>
    abstract member code: float with get
    /// <summary>
    /// The **<c>reason</c>** read-only property of the CloseEvent interface returns the WebSocket connection close reason the server gave for closing the connection; that is, a concise human-readable prose explanation for the closure.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/CloseEvent/reason)
    /// </summary>
    abstract member reason: string with get
    /// <summary>
    /// The **<c>wasClean</c>** read-only property of the CloseEvent interface returns <c>true</c> if the connection closed cleanly.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/CloseEvent/wasClean)
    /// </summary>
    abstract member wasClean: bool with get

[<AllowNullLiteral>]
[<Interface>]
type CloseEventInit =
    abstract member code: float option with get, set
    abstract member reason: string option with get, set
    abstract member wasClean: bool option with get, set

[<AllowNullLiteral>]
[<Interface>]
type WebSocketEventMap =
    abstract member close: CloseEvent with get, set
    abstract member message: MessageEvent with get, set
    abstract member ``open``: Event with get, set
    abstract member error: ErrorEvent with get, set


[<AllowNullLiteral>]
[<Interface>]
type WebSocket =
    inherit EventTarget<WebSocketEventMap>
    abstract member accept: unit -> unit
    /// <summary>
    /// Transmits data using the WebSocket connection. data can be a string, a Blob, an ArrayBuffer, or an ArrayBufferView.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/WebSocket/send)
    /// The **<c>WebSocket.send()</c>** method enqueues the specified data to be transmitted to the server over the WebSocket connection, increasing the value of <c>bufferedAmount</c> by the number of bytes needed to contain the data.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/WebSocket/send)
    /// </summary>
    abstract member send: message: U2<U2<ArrayBuffer, ArrayBufferView>, string> -> unit
    /// <summary>
    /// Closes the WebSocket connection, optionally using code as the the WebSocket connection close code and reason as the the WebSocket connection close reason.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/WebSocket/close)
    /// The **<c>WebSocket.close()</c>** method closes the already <c>CLOSED</c>, this method does nothing.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/WebSocket/close)
    /// </summary>
    abstract member close: ?code: float * ?reason: string -> unit
    abstract member serializeAttachment: attachment: obj -> unit
    abstract member deserializeAttachment: unit -> U2<obj, obj>
    /// <summary>
    /// Returns the state of the WebSocket object's connection. It can have the values described below.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/WebSocket/readyState)
    /// The **<c>WebSocket.readyState</c>** read-only property returns the current state of the WebSocket connection.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/WebSocket/readyState)
    /// </summary>
    abstract member readyState: float with get
    /// <summary>
    /// Returns the URL that was used to establish the WebSocket connection.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/WebSocket/url)
    /// The **<c>WebSocket.url</c>** read-only property returns the absolute URL of the WebSocket as resolved by the constructor.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/WebSocket/url)
    /// </summary>
    abstract member url: U2<string, obj> with get
    /// <summary>
    /// Returns the subprotocol selected by the server, if any. It can be used in conjunction with the array form of the constructor's second argument to perform subprotocol negotiation.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/WebSocket/protocol)
    /// The **<c>WebSocket.protocol</c>** read-only property returns the name of the sub-protocol the server selected; this will be one of the strings specified in the <c>protocols</c> parameter when creating the WebSocket object, or the empty string if no connection is established.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/WebSocket/protocol)
    /// </summary>
    abstract member protocol: U2<string, obj> with get
    /// <summary>
    /// Returns the extensions selected by the server, if any.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/WebSocket/extensions)
    /// The **<c>WebSocket.extensions</c>** read-only property returns the extensions selected by the server.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/WebSocket/extensions)
    /// </summary>
    abstract member extensions: U2<string, obj> with get
    /// <summary>
    /// Returns a string that indicates how binary data from the WebSocket object is exposed to scripts:
    ///
    /// Can be set, to change how binary data is returned. The default is "blob".
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/WebSocket/binaryType)
    /// The **<c>WebSocket.binaryType</c>** property controls the type of binary data being received over the WebSocket connection.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/WebSocket/binaryType)
    /// </summary>
    abstract member binaryType: WebSocket.binaryType with get, set


[<AllowNullLiteral>]
[<Interface>]
type SqlStorage =
    abstract member exec: query: string * [<ParamArray>] bindings: obj [] -> SqlStorageCursor<'T>
    abstract member databaseSize: float with get
    abstract member Cursor: SqlStorageCursor with get, set
    abstract member Statement: SqlStorageStatement with get, set

[<AllowNullLiteral>]
[<Interface>]
type SqlStorageStatement =
    interface end

type SqlStorageValue =
    U4<ArrayBuffer, string, float, obj>

[<AllowNullLiteral>]
[<Interface>]
type SqlStorageCursor<'T when 'T :> SqlStorageCursor> =
    abstract member next: unit -> SqlStorageCursor.next
    abstract member toArray: unit -> ResizeArray<'T>
    abstract member one: unit -> 'T
    abstract member raw: unit -> IterableIterator<'U>
    abstract member columnNames: ResizeArray<string> with get, set
    abstract member rowsRead: float with get
    abstract member rowsWritten: float with get
    [<EmitIndexer>]
    abstract member Item: key: string -> SqlStorageValue with get, set

[<AllowNullLiteral>]
[<Interface>]
type Socket =
    abstract member readable: ReadableStream with get
    abstract member writable: WritableStream with get
    abstract member closed: JS.Promise<unit> with get
    abstract member opened: JS.Promise<SocketInfo> with get
    abstract member upgraded: bool with get
    abstract member secureTransport: Socket.secureTransport with get
    abstract member close: unit -> JS.Promise<unit>
    abstract member startTls: ?options: TlsOptions -> Socket

[<AllowNullLiteral>]
[<Interface>]
type SocketOptions =
    abstract member secureTransport: string option with get, set
    abstract member allowHalfOpen: bool with get, set
    abstract member highWaterMark: U2<float, obj> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type SocketAddress =
    abstract member hostname: string with get, set
    abstract member port: float with get, set

[<AllowNullLiteral>]
[<Interface>]
type TlsOptions =
    abstract member expectedServerHostname: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type SocketInfo =
    abstract member remoteAddress: string option with get, set
    abstract member localAddress: string option with get, set

/// <summary>
/// The **<c>EventSource</c>** interface is web content's interface to server-sent events.
///
/// [MDN Reference](https://developer.mozilla.org/docs/Web/API/EventSource)
/// </summary>
[<AllowNullLiteral>]
[<Interface>]
type EventSource =
    inherit EventTarget
    /// <summary>
    /// The **<c>close()</c>** method of the EventSource interface closes the connection, if one is made, and sets the <code lang="js-nolint"> close() </code> None.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/EventSource/close)
    /// </summary>
    abstract member close: unit -> unit
    /// <summary>
    /// The **<c>url</c>** read-only property of the URL of the source.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/EventSource/url)
    /// </summary>
    abstract member url: string with get
    /// <summary>
    /// The **<c>withCredentials</c>** read-only property of the the <c>EventSource</c> object was instantiated with CORS credentials set.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/EventSource/withCredentials)
    /// </summary>
    abstract member withCredentials: bool with get
    /// <summary>
    /// The **<c>readyState</c>** read-only property of the connection.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/EventSource/readyState)
    /// </summary>
    abstract member readyState: float with get
    abstract member onopen: U2<obj, obj> with get, set
    abstract member onmessage: U2<obj, obj> with get, set
    abstract member onerror: U2<obj, obj> with get, set
    static member inline CONNECTING
        with get () : float =
            emitJsExpr () $$"""
import { EventSource } from "Fidelity.CloudEdge.Worker.Context";
EventSource.CONNECTING"""
    static member inline OPEN
        with get () : float =
            emitJsExpr () $$"""
import { EventSource } from "Fidelity.CloudEdge.Worker.Context";
EventSource.OPEN"""
    static member inline CLOSED
        with get () : float =
            emitJsExpr () $$"""
import { EventSource } from "Fidelity.CloudEdge.Worker.Context";
EventSource.CLOSED"""
    static member inline from (stream: ReadableStream): EventSource =
        emitJsExpr (stream) $$"""
import { EventSource } from "Fidelity.CloudEdge.Worker.Context";
EventSource.from($0)"""

[<AllowNullLiteral>]
[<Interface>]
type EventSourceEventSourceInit =
    abstract member withCredentials: bool option with get, set
    abstract member fetcher: Fetcher option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Container =
    abstract member running: bool with get
    abstract member start: ?options: ContainerStartupOptions -> unit
    abstract member monitor: unit -> JS.Promise<unit>
    abstract member destroy: ?error: obj -> JS.Promise<unit>
    abstract member signal: signo: float -> unit
    abstract member getTcpPort: port: float -> Fetcher
    abstract member setInactivityTimeout: durationMs: U2<float, obj> -> JS.Promise<unit>

[<AllowNullLiteral>]
[<Interface>]
type ContainerStartupOptions =
    abstract member entrypoint: ResizeArray<string> option with get, set
    abstract member enableInternet: bool with get, set
    abstract member env: ContainerStartupOptions.env option with get, set
    abstract member hardTimeout: U2<float, obj> option with get, set

/// <summary>
/// The **<c>MessagePort</c>** interface of the Channel Messaging API represents one of the two ports of a MessageChannel, allowing messages to be sent from one port and listening out for them arriving at the other.
///
/// [MDN Reference](https://developer.mozilla.org/docs/Web/API/MessagePort)
/// </summary>
[<AllowNullLiteral>]
[<Interface>]
type MessagePort =
    inherit EventTarget
    /// <summary>
    /// The **<c>postMessage()</c>** method of the transfers ownership of objects to other browsing contexts.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/MessagePort/postMessage)
    /// </summary>
    abstract member postMessage: ?data: obj * ?options: U2<ResizeArray<obj>, MessagePortPostMessageOptions> -> unit
    /// <summary>
    /// The **<c>close()</c>** method of the MessagePort interface disconnects the port, so it is no longer active.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/MessagePort/close)
    /// </summary>
    abstract member close: unit -> unit
    /// <summary>
    /// The **<c>start()</c>** method of the MessagePort interface starts the sending of messages queued on the port.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/MessagePort/start)
    /// </summary>
    abstract member start: unit -> unit
    abstract member onmessage: U2<obj, obj> with get, set

[<AllowNullLiteral>]
[<Interface>]
type MessagePortPostMessageOptions =
    abstract member transfer: ResizeArray<obj> option with get, set

type LoopbackForExport =
    'T

[<AllowNullLiteral>]
[<Interface>]
type LoopbackServiceStub<'T when 'T :> Rpc.WorkerEntrypointBranded option> =
    abstract member [__WORKER_ENTRYPOINT_BRAND]: obj with get, set
    abstract member fetch: input: U2<RequestInfo, URL> * ?init: RequestInit -> JS.Promise<Response>
    abstract member connect: address: U2<SocketAddress, string> * ?options: SocketOptions -> Socket

[<AllowNullLiteral>]
[<Interface>]
type LoopbackDurableObjectClass<'T when 'T :> Rpc.DurableObjectBranded option> =
    interface end

[<AllowNullLiteral>]
[<Interface>]
type SyncKvStorage =
    abstract member get: key: string -> 'T option
    abstract member list: ?options: SyncKvListOptions -> Iterable<string * 'T>
    abstract member put: key: string * value: 'T -> unit
    abstract member delete: key: string -> bool

[<AllowNullLiteral>]
[<Interface>]
type SyncKvListOptions =
    abstract member start: string option with get, set
    abstract member startAfter: string option with get, set
    abstract member ``end``: string option with get, set
    abstract member prefix: string option with get, set
    abstract member reverse: bool option with get, set
    abstract member limit: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type WorkerStub =
    abstract member getEntrypoint: ?name: string * ?options: WorkerStubEntrypointOptions -> Fetcher<'T>

[<AllowNullLiteral>]
[<Interface>]
type WorkerStubEntrypointOptions =
    abstract member props: obj option with get, set

[<AllowNullLiteral>]
[<Interface>]
type WorkerLoader =
    abstract member get: name: U2<string, obj> * getCode: (unit -> U2<WorkerLoaderWorkerCode, JS.Promise<WorkerLoaderWorkerCode>>) -> WorkerStub

[<AllowNullLiteral>]
[<Interface>]
type WorkerLoaderModule =
    abstract member js: string option with get, set
    abstract member cjs: string option with get, set
    abstract member text: string option with get, set
    abstract member data: ArrayBuffer option with get, set
    abstract member json: obj option with get, set
    abstract member py: string option with get, set
    abstract member wasm: ArrayBuffer option with get, set

[<AllowNullLiteral>]
[<Interface>]
type WorkerLoaderWorkerCode =
    abstract member compatibilityDate: string with get, set
    abstract member compatibilityFlags: ResizeArray<string> option with get, set
    abstract member allowExperimental: bool option with get, set
    abstract member mainModule: string with get, set
    abstract member modules: WorkerLoaderWorkerCode.modules with get, set
    abstract member env: obj option with get, set
    abstract member globalOutbound: U2<Fetcher, obj> option with get, set
    abstract member tails: ResizeArray<Fetcher> option with get, set
    abstract member streamingTails: ResizeArray<Fetcher> option with get, set

/// <summary>
/// The Workers runtime supports a subset of the Performance API, used to measure timing and performance,
/// as well as timing of subrequests and other operations.
///
/// [Cloudflare Docs Reference](https://developers.cloudflare.com/workers/runtime-apis/performance/)
/// </summary>
[<AllowNullLiteral>]
[<Interface>]
type Performance =
    abstract member timeOrigin: float with get
    abstract member now: unit -> float
    /// <summary>
    /// The **<c>toJSON()</c>** method of the Performance interface is a Serialization; it returns a JSON representation of the Performance object.
    ///
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/Performance/toJSON)
    /// </summary>
    abstract member toJSON: unit -> obj

[<AllowNullLiteral>]
[<Interface>]
type AiSearchInternalError =
    inherit Exception

[<AllowNullLiteral>]
[<Interface>]
type AiSearchNotFoundError =
    inherit Exception

[<AllowNullLiteral>]
[<Interface>]
type AiSearchNameNotSetError =
    inherit Exception

[<AllowNullLiteral>]
[<Interface>]
type AiSearchSearchRequest =
    abstract member messages: ResizeArray<AiSearchSearchRequest.messages> with get, set
    abstract member ai_search_options: AiSearchSearchRequest.ai_search_options option with get, set

[<AllowNullLiteral>]
[<Interface>]
type AiSearchChatCompletionsRequest =
    abstract member messages: ResizeArray<AiSearchChatCompletionsRequest.messages> with get, set
    abstract member model: string option with get, set
    abstract member stream: bool option with get, set
    abstract member ai_search_options: AiSearchChatCompletionsRequest.ai_search_options option with get, set
    [<EmitIndexer>]
    abstract member Item: key: string -> obj with get, set

[<AllowNullLiteral>]
[<Interface>]
type AiSearchSearchResponse =
    abstract member search_query: string with get, set
    abstract member chunks: ResizeArray<AiSearchSearchResponse.chunks> with get, set

type AiSearchListResponse =
    ResizeArray<AiSearchListResponse.ResizeArray>

[<AllowNullLiteral>]
[<Interface>]
type AiSearchConfig =
    /// <summary>
    /// Instance ID (1-32 chars, pattern: ^[a-z0-9_]+(?:-[a-z0-9_]+)*$)
    /// </summary>
    abstract member id: string with get, set
    abstract member ``type``: AiSearchConfig.``type`` with get, set
    abstract member source: string with get, set
    abstract member source_params: obj option with get, set
    /// <summary>
    /// Token ID (UUID format)
    /// </summary>
    abstract member token_id: string option with get, set
    abstract member ai_gateway_id: string option with get, set
    /// <summary>
    /// Enable query rewriting (default false)
    /// </summary>
    abstract member rewrite_query: bool option with get, set
    /// <summary>
    /// Enable reranking (default false)
    /// </summary>
    abstract member reranking: bool option with get, set
    abstract member embedding_model: string option with get, set
    abstract member ai_search_model: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type AiSearchInstance =
    abstract member id: string with get, set
    abstract member enable: bool option with get, set
    abstract member ``type``: AiSearchInstance.``type`` option with get, set
    abstract member source: string option with get, set
    [<EmitIndexer>]
    abstract member Item: key: string -> obj with get, set

[<AllowNullLiteral>]
[<Interface>]
type AiSearchInstanceService =
    /// <summary>
    /// Search the AI Search instance for relevant chunks.
    /// </summary>
    /// <param name="params">
    /// Search request with messages and AI search options
    /// </param>
    /// <returns>
    /// Search response with matching chunks
    /// </returns>
    abstract member search: ``params``: AiSearchSearchRequest -> JS.Promise<AiSearchSearchResponse>
    /// <summary>
    /// Generate chat completions with AI Search context.
    /// </summary>
    /// <param name="params">
    /// Chat completions request with optional streaming
    /// </param>
    /// <returns>
    /// Response object (if streaming) or chat completion result
    /// </returns>
    abstract member chatCompletions: ``params``: AiSearchChatCompletionsRequest -> JS.Promise<U2<Response, obj>>
    /// <summary>
    /// Delete this AI Search instance.
    /// </summary>
    abstract member delete: unit -> JS.Promise<unit>

[<AllowNullLiteral>]
[<Interface>]
type AiSearchAccountService =
    /// <summary>
    /// List all AI Search instances in the account.
    /// </summary>
    /// <returns>
    /// Array of AI Search instances
    /// </returns>
    abstract member list: unit -> JS.Promise<AiSearchListResponse>
    /// <summary>
    /// Get an AI Search instance by ID.
    /// </summary>
    /// <param name="name">
    /// Instance ID
    /// </param>
    /// <returns>
    /// Instance service for performing operations
    /// </returns>
    abstract member get: name: string -> AiSearchInstanceService
    /// <summary>
    /// Create a new AI Search instance.
    /// </summary>
    /// <param name="config">
    /// Instance configuration
    /// </param>
    /// <returns>
    /// Instance service for performing operations
    /// </returns>
    abstract member create: config: AiSearchConfig -> JS.Promise<AiSearchInstanceService>

[<AllowNullLiteral>]
[<Interface>]
type AiImageClassificationInput =
    abstract member image: ResizeArray<float> with get, set

type AiImageClassificationOutput =
    ResizeArray<AiImageClassificationOutput>

[<AllowNullLiteral>]
[<Interface>]
type BaseAiImageClassification =
    abstract member inputs: AiImageClassificationInput with get, set
    abstract member postProcessedOutputs: AiImageClassificationOutput with get, set

[<AllowNullLiteral>]
[<Interface>]
type AiImageToTextInput =
    abstract member image: ResizeArray<float> with get, set
    abstract member prompt: string option with get, set
    abstract member max_tokens: float option with get, set
    abstract member temperature: float option with get, set
    abstract member top_p: float option with get, set
    abstract member top_k: float option with get, set
    abstract member seed: float option with get, set
    abstract member repetition_penalty: float option with get, set
    abstract member frequency_penalty: float option with get, set
    abstract member presence_penalty: float option with get, set
    abstract member raw: bool option with get, set
    abstract member messages: ResizeArray<RoleScopedChatInput> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type AiImageToTextOutput =
    abstract member description: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type BaseAiImageToText =
    abstract member inputs: AiImageToTextInput with get, set
    abstract member postProcessedOutputs: AiImageToTextOutput with get, set

[<AllowNullLiteral>]
[<Interface>]
type AiImageTextToTextInput =
    abstract member image: string with get, set
    abstract member prompt: string option with get, set
    abstract member max_tokens: float option with get, set
    abstract member temperature: float option with get, set
    abstract member ignore_eos: bool option with get, set
    abstract member top_p: float option with get, set
    abstract member top_k: float option with get, set
    abstract member seed: float option with get, set
    abstract member repetition_penalty: float option with get, set
    abstract member frequency_penalty: float option with get, set
    abstract member presence_penalty: float option with get, set
    abstract member raw: bool option with get, set
    abstract member messages: ResizeArray<RoleScopedChatInput> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type AiImageTextToTextOutput =
    abstract member description: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type BaseAiImageTextToText =
    abstract member inputs: AiImageTextToTextInput with get, set
    abstract member postProcessedOutputs: AiImageTextToTextOutput with get, set

[<AllowNullLiteral>]
[<Interface>]
type AiMultimodalEmbeddingsInput =
    abstract member image: string with get, set
    abstract member text: ResizeArray<string> with get, set

[<AllowNullLiteral>]
[<Interface>]
type AiIMultimodalEmbeddingsOutput =
    abstract member data: ResizeArray<ResizeArray<float>> with get, set
    abstract member shape: ResizeArray<float> with get, set

[<AllowNullLiteral>]
[<Interface>]
type BaseAiMultimodalEmbeddings =
    abstract member inputs: AiImageTextToTextInput with get, set
    abstract member postProcessedOutputs: AiImageTextToTextOutput with get, set

[<AllowNullLiteral>]
[<Interface>]
type AiObjectDetectionInput =
    abstract member image: ResizeArray<float> with get, set

type AiObjectDetectionOutput =
    ResizeArray<AiObjectDetectionOutput>

[<AllowNullLiteral>]
[<Interface>]
type BaseAiObjectDetection =
    abstract member inputs: AiObjectDetectionInput with get, set
    abstract member postProcessedOutputs: AiObjectDetectionOutput with get, set

[<AllowNullLiteral>]
[<Interface>]
type AiSentenceSimilarityInput =
    abstract member source: string with get, set
    abstract member sentences: ResizeArray<string> with get, set

type AiSentenceSimilarityOutput =
    ResizeArray<float>

[<AllowNullLiteral>]
[<Interface>]
type BaseAiSentenceSimilarity =
    abstract member inputs: AiSentenceSimilarityInput with get, set
    abstract member postProcessedOutputs: AiSentenceSimilarityOutput with get, set

[<AllowNullLiteral>]
[<Interface>]
type AiAutomaticSpeechRecognitionInput =
    abstract member audio: ResizeArray<float> with get, set

[<AllowNullLiteral>]
[<Interface>]
type AiAutomaticSpeechRecognitionOutput =
    abstract member text: string option with get, set
    abstract member words: ResizeArray<AiAutomaticSpeechRecognitionOutput.words> option with get, set
    abstract member vtt: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type BaseAiAutomaticSpeechRecognition =
    abstract member inputs: AiAutomaticSpeechRecognitionInput with get, set
    abstract member postProcessedOutputs: AiAutomaticSpeechRecognitionOutput with get, set

[<AllowNullLiteral>]
[<Interface>]
type AiSummarizationInput =
    abstract member input_text: string with get, set
    abstract member max_length: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type AiSummarizationOutput =
    abstract member summary: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type BaseAiSummarization =
    abstract member inputs: AiSummarizationInput with get, set
    abstract member postProcessedOutputs: AiSummarizationOutput with get, set

[<AllowNullLiteral>]
[<Interface>]
type AiTextClassificationInput =
    abstract member text: string with get, set

type AiTextClassificationOutput =
    ResizeArray<AiTextClassificationOutput>

[<AllowNullLiteral>]
[<Interface>]
type BaseAiTextClassification =
    abstract member inputs: AiTextClassificationInput with get, set
    abstract member postProcessedOutputs: AiTextClassificationOutput with get, set

[<AllowNullLiteral>]
[<Interface>]
type AiTextEmbeddingsInput =
    abstract member text: U2<string, ResizeArray<string>> with get, set

[<AllowNullLiteral>]
[<Interface>]
type AiTextEmbeddingsOutput =
    abstract member shape: ResizeArray<float> with get, set
    abstract member data: ResizeArray<ResizeArray<float>> with get, set

[<AllowNullLiteral>]
[<Interface>]
type BaseAiTextEmbeddings =
    abstract member inputs: AiTextEmbeddingsInput with get, set
    abstract member postProcessedOutputs: AiTextEmbeddingsOutput with get, set

[<AllowNullLiteral>]
[<Interface>]
type RoleScopedChatInput =
    abstract member role: RoleScopedChatInput.role with get, set
    abstract member content: string with get, set
    abstract member name: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type AiTextGenerationToolLegacyInput =
    abstract member name: string with get, set
    abstract member description: string with get, set
    abstract member parameters: AiTextGenerationToolLegacyInput.parameters option with get, set

[<AllowNullLiteral>]
[<Interface>]
type AiTextGenerationToolInput =
    abstract member ``type``: AiTextGenerationToolInput.``type`` with get, set
    abstract member ``function``: AiTextGenerationToolInput.``function`` with get, set

[<AllowNullLiteral>]
[<Interface>]
type AiTextGenerationFunctionsInput =
    abstract member name: string with get, set
    abstract member code: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type AiTextGenerationResponseFormat =
    abstract member ``type``: string with get, set
    abstract member json_schema: obj option with get, set

[<AllowNullLiteral>]
[<Interface>]
type AiTextGenerationInput =
    abstract member prompt: string option with get, set
    abstract member raw: bool option with get, set
    abstract member stream: bool option with get, set
    abstract member max_tokens: float option with get, set
    abstract member temperature: float option with get, set
    abstract member top_p: float option with get, set
    abstract member top_k: float option with get, set
    abstract member seed: float option with get, set
    abstract member repetition_penalty: float option with get, set
    abstract member frequency_penalty: float option with get, set
    abstract member presence_penalty: float option with get, set
    abstract member messages: ResizeArray<RoleScopedChatInput> option with get, set
    abstract member response_format: AiTextGenerationResponseFormat option with get, set
    abstract member tools: U3<ResizeArray<AiTextGenerationToolInput>, ResizeArray<AiTextGenerationToolLegacyInput>, obj> option with get, set
    abstract member functions: ResizeArray<AiTextGenerationFunctionsInput> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type AiTextGenerationToolLegacyOutput =
    abstract member name: string with get, set
    abstract member arguments: obj with get, set

[<AllowNullLiteral>]
[<Interface>]
type AiTextGenerationToolOutput =
    abstract member id: string with get, set
    abstract member ``type``: string with get, set
    abstract member ``function``: AiTextGenerationToolOutput.``function`` with get, set

[<AllowNullLiteral>]
[<Interface>]
type UsageTags =
    abstract member prompt_tokens: float with get, set
    abstract member completion_tokens: float with get, set
    abstract member total_tokens: float with get, set

[<AllowNullLiteral>]
[<Interface>]
type AiTextGenerationOutput =
    abstract member response: string option with get, set
    abstract member tool_calls: obj option with get, set
    abstract member usage: UsageTags option with get, set

[<AllowNullLiteral>]
[<Interface>]
type BaseAiTextGeneration =
    abstract member inputs: AiTextGenerationInput with get, set
    abstract member postProcessedOutputs: AiTextGenerationOutput with get, set

[<AllowNullLiteral>]
[<Interface>]
type AiTextToSpeechInput =
    abstract member prompt: string with get, set
    abstract member lang: string option with get, set

type AiTextToSpeechOutput =
    U2<JS.Uint8Array, AiTextToSpeechOutput.U2.Case2>

[<AllowNullLiteral>]
[<Interface>]
type BaseAiTextToSpeech =
    abstract member inputs: AiTextToSpeechInput with get, set
    abstract member postProcessedOutputs: AiTextToSpeechOutput with get, set

[<AllowNullLiteral>]
[<Interface>]
type AiTextToImageInput =
    abstract member prompt: string with get, set
    abstract member negative_prompt: string option with get, set
    abstract member height: float option with get, set
    abstract member width: float option with get, set
    abstract member image: ResizeArray<float> option with get, set
    abstract member image_b64: string option with get, set
    abstract member mask: ResizeArray<float> option with get, set
    abstract member num_steps: float option with get, set
    abstract member strength: float option with get, set
    abstract member guidance: float option with get, set
    abstract member seed: float option with get, set

type AiTextToImageOutput =
    ReadableStream<JS.Uint8Array>

[<AllowNullLiteral>]
[<Interface>]
type BaseAiTextToImage =
    abstract member inputs: AiTextToImageInput with get, set
    abstract member postProcessedOutputs: AiTextToImageOutput with get, set

[<AllowNullLiteral>]
[<Interface>]
type AiTranslationInput =
    abstract member text: string with get, set
    abstract member target_lang: string with get, set
    abstract member source_lang: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type AiTranslationOutput =
    abstract member translated_text: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type BaseAiTranslation =
    abstract member inputs: AiTranslationInput with get, set
    abstract member postProcessedOutputs: AiTranslationOutput with get, set

[<AllowNullLiteral>]
[<Interface>]
type ResponsesInput =
    abstract member background: U2<bool, obj> option with get, set
    abstract member conversation: U3<string, ResponseConversationParam, obj> option with get, set
    abstract member ``include``: U2<ResizeArray<ResponseIncludable>, obj> option with get, set
    abstract member input: U2<string, ResponseInput> option with get, set
    abstract member instructions: U2<string, obj> option with get, set
    abstract member max_output_tokens: U2<float, obj> option with get, set
    abstract member parallel_tool_calls: U2<bool, obj> option with get, set
    abstract member previous_response_id: U2<string, obj> option with get, set
    abstract member prompt_cache_key: string option with get, set
    abstract member reasoning: U2<Reasoning, obj> option with get, set
    abstract member safety_identifier: string option with get, set
    abstract member service_tier: U6<string, string, string, string, string, obj> option with get, set
    abstract member stream: U2<bool, obj> option with get, set
    abstract member stream_options: U2<StreamOptions, obj> option with get, set
    abstract member temperature: U2<float, obj> option with get, set
    abstract member text: ResponseTextConfig option with get, set
    abstract member tool_choice: U2<ToolChoiceOptions, ToolChoiceFunction> option with get, set
    abstract member tools: ResizeArray<Tool> option with get, set
    abstract member top_p: U2<float, obj> option with get, set
    abstract member truncation: U3<string, string, obj> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type ResponsesOutput =
    abstract member id: string option with get, set
    abstract member created_at: float option with get, set
    abstract member output_text: string option with get, set
    abstract member error: U2<ResponseError, obj> option with get, set
    abstract member incomplete_details: U2<ResponseIncompleteDetails, obj> option with get, set
    abstract member instructions: U3<string, ResizeArray<ResponseInputItem>, obj> option with get, set
    abstract member ``object``: string option with get, set
    abstract member output: ResizeArray<ResponseOutputItem> option with get, set
    abstract member parallel_tool_calls: bool option with get, set
    abstract member temperature: U2<float, obj> option with get, set
    abstract member tool_choice: U2<ToolChoiceOptions, ToolChoiceFunction> option with get, set
    abstract member tools: ResizeArray<Tool> option with get, set
    abstract member top_p: U2<float, obj> option with get, set
    abstract member max_output_tokens: U2<float, obj> option with get, set
    abstract member previous_response_id: U2<string, obj> option with get, set
    abstract member prompt: U2<ResponsePrompt, obj> option with get, set
    abstract member reasoning: U2<Reasoning, obj> option with get, set
    abstract member safety_identifier: string option with get, set
    abstract member service_tier: U6<string, string, string, string, string, obj> option with get, set
    abstract member status: ResponseStatus option with get, set
    abstract member text: ResponseTextConfig option with get, set
    abstract member truncation: U3<string, string, obj> option with get, set
    abstract member usage: ResponseUsage option with get, set

[<AllowNullLiteral>]
[<Interface>]
type EasyInputMessage =
    abstract member content: U2<string, ResponseInputMessageContentList> with get, set
    abstract member role: EasyInputMessage.role with get, set
    abstract member ``type``: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type ResponsesFunctionTool =
    abstract member name: string with get, set
    abstract member parameters: U2<ResponsesFunctionTool.parameters.U2.Case1, obj> with get, set
    abstract member strict: U2<bool, obj> with get, set
    abstract member ``type``: string with get, set
    abstract member description: U2<string, obj> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type ResponseIncompleteDetails =
    abstract member reason: ResponseIncompleteDetails.reason option with get, set

[<AllowNullLiteral>]
[<Interface>]
type ResponsePrompt =
    abstract member id: string with get, set
    abstract member variables: U2<ResponsePrompt.variables.U2.Case1, obj> option with get, set
    abstract member version: U2<string, obj> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Reasoning =
    abstract member effort: U2<ReasoningEffort, obj> option with get, set
    abstract member generate_summary: U4<string, string, string, obj> option with get, set
    abstract member summary: U4<string, string, string, obj> option with get, set

type ResponseContent =
    U5<ResponseInputText, ResponseInputImage, ResponseOutputText, ResponseOutputRefusal, ResponseContentReasoningText>

[<AllowNullLiteral>]
[<Interface>]
type ResponseContentReasoningText =
    abstract member text: string with get, set
    abstract member ``type``: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type ResponseConversationParam =
    abstract member id: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type ResponseCreatedEvent =
    abstract member response: Response with get, set
    abstract member sequence_number: float with get, set
    abstract member ``type``: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type ResponseCustomToolCallOutput =
    abstract member call_id: string with get, set
    abstract member output: U2<string, ResizeArray<U2<ResponseInputText, ResponseInputImage>>> with get, set
    abstract member ``type``: string with get, set
    abstract member id: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type ResponseError =
    abstract member code: ResponseError.code with get, set
    abstract member message: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type ResponseErrorEvent =
    abstract member code: U2<string, obj> with get, set
    abstract member message: string with get, set
    abstract member param: U2<string, obj> with get, set
    abstract member sequence_number: float with get, set
    abstract member ``type``: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type ResponseFailedEvent =
    abstract member response: Response with get, set
    abstract member sequence_number: float with get, set
    abstract member ``type``: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type ResponseFormatText =
    abstract member ``type``: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type ResponseFormatJSONObject =
    abstract member ``type``: string with get, set

type ResponseFormatTextConfig =
    U3<ResponseFormatText, ResponseFormatTextJSONSchemaConfig, ResponseFormatJSONObject>

[<AllowNullLiteral>]
[<Interface>]
type ResponseFormatTextJSONSchemaConfig =
    abstract member name: string with get, set
    abstract member schema: ResponseFormatTextJSONSchemaConfig.schema with get, set
    abstract member ``type``: string with get, set
    abstract member description: string option with get, set
    abstract member strict: U2<bool, obj> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type ResponseFunctionCallArgumentsDeltaEvent =
    abstract member delta: string with get, set
    abstract member item_id: string with get, set
    abstract member output_index: float with get, set
    abstract member sequence_number: float with get, set
    abstract member ``type``: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type ResponseFunctionCallArgumentsDoneEvent =
    abstract member arguments: string with get, set
    abstract member item_id: string with get, set
    abstract member name: string with get, set
    abstract member output_index: float with get, set
    abstract member sequence_number: float with get, set
    abstract member ``type``: string with get, set

type ResponseFunctionCallOutputItem =
    U2<ResponseInputTextContent, ResponseInputImageContent>

type ResponseFunctionCallOutputItemList =
    ResizeArray<ResponseFunctionCallOutputItem>

[<AllowNullLiteral>]
[<Interface>]
type ResponseFunctionToolCall =
    abstract member arguments: string with get, set
    abstract member call_id: string with get, set
    abstract member name: string with get, set
    abstract member ``type``: string with get, set
    abstract member id: string option with get, set
    abstract member status: ResponseFunctionToolCall.status option with get, set

[<AllowNullLiteral>]
[<Interface>]
type ResponseFunctionToolCallItem =
    inherit ResponseFunctionToolCall
    abstract member id: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type ResponseFunctionToolCallOutputItem =
    abstract member id: string with get, set
    abstract member call_id: string with get, set
    abstract member output: U2<string, ResizeArray<U2<ResponseInputText, ResponseInputImage>>> with get, set
    abstract member ``type``: string with get, set
    abstract member status: ResponseFunctionToolCallOutputItem.status option with get, set

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type ResponseIncludable =
    | [<CompiledName("message.input_image.image_url")>] message_input_image_image_url
    | [<CompiledName("message.output_text.logprobs")>] message_output_text_logprobs

[<AllowNullLiteral>]
[<Interface>]
type ResponseIncompleteEvent =
    abstract member response: Response with get, set
    abstract member sequence_number: float with get, set
    abstract member ``type``: string with get, set

type ResponseInput =
    ResizeArray<ResponseInputItem>

type ResponseInputContent =
    U2<ResponseInputText, ResponseInputImage>

[<AllowNullLiteral>]
[<Interface>]
type ResponseInputImage =
    abstract member detail: ResponseInputImage.detail with get, set
    abstract member ``type``: string with get, set
    /// <summary>
    /// Base64 encoded image
    /// </summary>
    abstract member image_url: U2<string, obj> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type ResponseInputImageContent =
    abstract member ``type``: string with get, set
    abstract member detail: U4<string, string, string, obj> option with get, set
    /// <summary>
    /// Base64 encoded image
    /// </summary>
    abstract member image_url: U2<string, obj> option with get, set

type ResponseInputItem =
    U6<EasyInputMessage, ResponseInputItemMessage, ResponseOutputMessage, ResponseFunctionToolCall, ResponseInputItemFunctionCallOutput, ResponseReasoningItem>

[<AllowNullLiteral>]
[<Interface>]
type ResponseInputItemFunctionCallOutput =
    abstract member call_id: string with get, set
    abstract member output: U2<string, ResponseFunctionCallOutputItemList> with get, set
    abstract member ``type``: string with get, set
    abstract member id: U2<string, obj> option with get, set
    abstract member status: U4<string, string, string, obj> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type ResponseInputItemMessage =
    abstract member content: ResponseInputMessageContentList with get, set
    abstract member role: ResponseInputItemMessage.role with get, set
    abstract member status: ResponseInputItemMessage.status option with get, set
    abstract member ``type``: string option with get, set

type ResponseInputMessageContentList =
    ResizeArray<ResponseInputContent>

[<AllowNullLiteral>]
[<Interface>]
type ResponseInputMessageItem =
    abstract member id: string with get, set
    abstract member content: ResponseInputMessageContentList with get, set
    abstract member role: ResponseInputMessageItem.role with get, set
    abstract member status: ResponseInputMessageItem.status option with get, set
    abstract member ``type``: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type ResponseInputText =
    abstract member text: string with get, set
    abstract member ``type``: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type ResponseInputTextContent =
    abstract member text: string with get, set
    abstract member ``type``: string with get, set

type ResponseItem =
    U4<ResponseInputMessageItem, ResponseOutputMessage, ResponseFunctionToolCallItem, ResponseFunctionToolCallOutputItem>

type ResponseOutputItem =
    U3<ResponseOutputMessage, ResponseFunctionToolCall, ResponseReasoningItem>

[<AllowNullLiteral>]
[<Interface>]
type ResponseOutputItemAddedEvent =
    abstract member item: ResponseOutputItem with get, set
    abstract member output_index: float with get, set
    abstract member sequence_number: float with get, set
    abstract member ``type``: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type ResponseOutputItemDoneEvent =
    abstract member item: ResponseOutputItem with get, set
    abstract member output_index: float with get, set
    abstract member sequence_number: float with get, set
    abstract member ``type``: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type ResponseOutputMessage =
    abstract member id: string with get, set
    abstract member content: ResizeArray<U2<ResponseOutputText, ResponseOutputRefusal>> with get, set
    abstract member role: string with get, set
    abstract member status: ResponseOutputMessage.status with get, set
    abstract member ``type``: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type ResponseOutputRefusal =
    abstract member refusal: string with get, set
    abstract member ``type``: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type ResponseOutputText =
    abstract member text: string with get, set
    abstract member ``type``: string with get, set
    abstract member logprobs: ResizeArray<Logprob> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type ResponseReasoningItem =
    abstract member id: string with get, set
    abstract member summary: ResizeArray<ResponseReasoningSummaryItem> with get, set
    abstract member ``type``: string with get, set
    abstract member content: ResizeArray<ResponseReasoningContentItem> option with get, set
    abstract member encrypted_content: U2<string, obj> option with get, set
    abstract member status: ResponseReasoningItem.status option with get, set

[<AllowNullLiteral>]
[<Interface>]
type ResponseReasoningSummaryItem =
    abstract member text: string with get, set
    abstract member ``type``: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type ResponseReasoningContentItem =
    abstract member text: string with get, set
    abstract member ``type``: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type ResponseReasoningTextDeltaEvent =
    abstract member content_index: float with get, set
    abstract member delta: string with get, set
    abstract member item_id: string with get, set
    abstract member output_index: float with get, set
    abstract member sequence_number: float with get, set
    abstract member ``type``: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type ResponseReasoningTextDoneEvent =
    abstract member content_index: float with get, set
    abstract member item_id: string with get, set
    abstract member output_index: float with get, set
    abstract member sequence_number: float with get, set
    abstract member text: string with get, set
    abstract member ``type``: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type ResponseRefusalDeltaEvent =
    abstract member content_index: float with get, set
    abstract member delta: string with get, set
    abstract member item_id: string with get, set
    abstract member output_index: float with get, set
    abstract member sequence_number: float with get, set
    abstract member ``type``: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type ResponseRefusalDoneEvent =
    abstract member content_index: float with get, set
    abstract member item_id: string with get, set
    abstract member output_index: float with get, set
    abstract member refusal: string with get, set
    abstract member sequence_number: float with get, set
    abstract member ``type``: string with get, set

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type ResponseStatus =
    | completed
    | failed
    | in_progress
    | cancelled
    | queued
    | incomplete

type ResponseStreamEvent =
    U15<ResponseCompletedEvent, ResponseCreatedEvent, ResponseErrorEvent, ResponseFunctionCallArgumentsDeltaEvent, ResponseFunctionCallArgumentsDoneEvent, ResponseFailedEvent, ResponseIncompleteEvent, ResponseOutputItemAddedEvent, ResponseOutputItemDoneEvent, ResponseReasoningTextDeltaEvent, ResponseReasoningTextDoneEvent, ResponseRefusalDeltaEvent, ResponseRefusalDoneEvent, ResponseTextDeltaEvent, ResponseTextDoneEvent>

[<AllowNullLiteral>]
[<Interface>]
type ResponseCompletedEvent =
    abstract member response: Response with get, set
    abstract member sequence_number: float with get, set
    abstract member ``type``: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type ResponseTextConfig =
    abstract member format: ResponseFormatTextConfig option with get, set
    abstract member verbosity: U4<string, string, string, obj> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type ResponseTextDeltaEvent =
    abstract member content_index: float with get, set
    abstract member delta: string with get, set
    abstract member item_id: string with get, set
    abstract member logprobs: ResizeArray<Logprob> with get, set
    abstract member output_index: float with get, set
    abstract member sequence_number: float with get, set
    abstract member ``type``: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type ResponseTextDoneEvent =
    abstract member content_index: float with get, set
    abstract member item_id: string with get, set
    abstract member logprobs: ResizeArray<Logprob> with get, set
    abstract member output_index: float with get, set
    abstract member sequence_number: float with get, set
    abstract member text: string with get, set
    abstract member ``type``: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type Logprob =
    abstract member token: string with get, set
    abstract member logprob: float with get, set
    abstract member top_logprobs: ResizeArray<TopLogprob> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type TopLogprob =
    abstract member token: string option with get, set
    abstract member logprob: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type ResponseUsage =
    abstract member input_tokens: float with get, set
    abstract member output_tokens: float with get, set
    abstract member total_tokens: float with get, set

type Tool =
    ResponsesFunctionTool

[<AllowNullLiteral>]
[<Interface>]
type ToolChoiceFunction =
    abstract member name: string with get, set
    abstract member ``type``: string with get, set

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type ToolChoiceOptions =
    | none

type ReasoningEffort =
    U5<string, string, string, string, obj>

[<AllowNullLiteral>]
[<Interface>]
type StreamOptions =
    abstract member include_obfuscation: bool option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Baai_Bge_Base_En_V1_5_Input =
    abstract member text: U2<string, ResizeArray<string>> with get, set
    /// <summary>
    /// The pooling method used in the embedding process. <c>cls</c> pooling will generate more accurate embeddings on larger inputs - however, embeddings created with cls pooling are not compatible with embeddings generated with mean pooling. The default pooling method is <c>mean</c> in order for this to not be a breaking change, but we highly suggest using the new <c>cls</c> pooling for better accuracy.
    /// </summary>
    abstract member pooling: Ai_Cf_Baai_Bge_Base_En_V1_5_Input.pooling option with get, set
    /// <summary>
    /// Batch of the embeddings requests to run using async-queue
    /// </summary>
    abstract member requests: ResizeArray<Ai_Cf_Baai_Bge_Base_En_V1_5_Input.requests> with get, set

type Ai_Cf_Baai_Bge_Base_En_V1_5_Output =
    U2<Ai_Cf_Baai_Bge_Base_En_V1_5_Output.U2.Case1, Ai_Cf_Baai_Bge_Base_En_V1_5_AsyncResponse>

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Baai_Bge_Base_En_V1_5_AsyncResponse =
    /// <summary>
    /// The async request id that can be used to obtain the results.
    /// </summary>
    abstract member request_id: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Base_Ai_Cf_Baai_Bge_Base_En_V1_5 =
    abstract member inputs: Ai_Cf_Baai_Bge_Base_En_V1_5_Input with get, set
    abstract member postProcessedOutputs: Ai_Cf_Baai_Bge_Base_En_V1_5_Output with get, set

type Ai_Cf_Openai_Whisper_Input =
    U2<string, Ai_Cf_Openai_Whisper_Input.U2.Case2>

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Openai_Whisper_Output =
    /// <summary>
    /// The transcription
    /// </summary>
    abstract member text: string with get, set
    abstract member word_count: float option with get, set
    abstract member words: ResizeArray<Ai_Cf_Openai_Whisper_Output.words> option with get, set
    abstract member vtt: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Base_Ai_Cf_Openai_Whisper =
    abstract member inputs: Ai_Cf_Openai_Whisper_Input with get, set
    abstract member postProcessedOutputs: Ai_Cf_Openai_Whisper_Output with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Meta_M2M100_1_2B_Input =
    /// <summary>
    /// The text to be translated
    /// </summary>
    abstract member text: string with get, set
    /// <summary>
    /// The language code of the source text (e.g., 'en' for English). Defaults to 'en' if not specified
    /// </summary>
    abstract member source_lang: string option with get, set
    /// <summary>
    /// The language code to translate the text into (e.g., 'es' for Spanish)
    /// </summary>
    abstract member target_lang: string with get, set
    /// <summary>
    /// Batch of the embeddings requests to run using async-queue
    /// </summary>
    abstract member requests: ResizeArray<Ai_Cf_Meta_M2M100_1_2B_Input.requests> with get, set

type Ai_Cf_Meta_M2M100_1_2B_Output =
    U2<Ai_Cf_Meta_M2M100_1_2B_Output.U2.Case1, Ai_Cf_Meta_M2M100_1_2B_AsyncResponse>

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Meta_M2M100_1_2B_AsyncResponse =
    /// <summary>
    /// The async request id that can be used to obtain the results.
    /// </summary>
    abstract member request_id: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Base_Ai_Cf_Meta_M2M100_1_2B =
    abstract member inputs: Ai_Cf_Meta_M2M100_1_2B_Input with get, set
    abstract member postProcessedOutputs: Ai_Cf_Meta_M2M100_1_2B_Output with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Baai_Bge_Small_En_V1_5_Input =
    abstract member text: U2<string, ResizeArray<string>> with get, set
    /// <summary>
    /// The pooling method used in the embedding process. <c>cls</c> pooling will generate more accurate embeddings on larger inputs - however, embeddings created with cls pooling are not compatible with embeddings generated with mean pooling. The default pooling method is <c>mean</c> in order for this to not be a breaking change, but we highly suggest using the new <c>cls</c> pooling for better accuracy.
    /// </summary>
    abstract member pooling: Ai_Cf_Baai_Bge_Small_En_V1_5_Input.pooling option with get, set
    /// <summary>
    /// Batch of the embeddings requests to run using async-queue
    /// </summary>
    abstract member requests: ResizeArray<Ai_Cf_Baai_Bge_Small_En_V1_5_Input.requests> with get, set

type Ai_Cf_Baai_Bge_Small_En_V1_5_Output =
    U2<Ai_Cf_Baai_Bge_Small_En_V1_5_Output.U2.Case1, Ai_Cf_Baai_Bge_Small_En_V1_5_AsyncResponse>

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Baai_Bge_Small_En_V1_5_AsyncResponse =
    /// <summary>
    /// The async request id that can be used to obtain the results.
    /// </summary>
    abstract member request_id: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Base_Ai_Cf_Baai_Bge_Small_En_V1_5 =
    abstract member inputs: Ai_Cf_Baai_Bge_Small_En_V1_5_Input with get, set
    abstract member postProcessedOutputs: Ai_Cf_Baai_Bge_Small_En_V1_5_Output with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Baai_Bge_Large_En_V1_5_Input =
    abstract member text: U2<string, ResizeArray<string>> with get, set
    /// <summary>
    /// The pooling method used in the embedding process. <c>cls</c> pooling will generate more accurate embeddings on larger inputs - however, embeddings created with cls pooling are not compatible with embeddings generated with mean pooling. The default pooling method is <c>mean</c> in order for this to not be a breaking change, but we highly suggest using the new <c>cls</c> pooling for better accuracy.
    /// </summary>
    abstract member pooling: Ai_Cf_Baai_Bge_Large_En_V1_5_Input.pooling option with get, set
    /// <summary>
    /// Batch of the embeddings requests to run using async-queue
    /// </summary>
    abstract member requests: ResizeArray<Ai_Cf_Baai_Bge_Large_En_V1_5_Input.requests> with get, set

type Ai_Cf_Baai_Bge_Large_En_V1_5_Output =
    U2<Ai_Cf_Baai_Bge_Large_En_V1_5_Output.U2.Case1, Ai_Cf_Baai_Bge_Large_En_V1_5_AsyncResponse>

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Baai_Bge_Large_En_V1_5_AsyncResponse =
    /// <summary>
    /// The async request id that can be used to obtain the results.
    /// </summary>
    abstract member request_id: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Base_Ai_Cf_Baai_Bge_Large_En_V1_5 =
    abstract member inputs: Ai_Cf_Baai_Bge_Large_En_V1_5_Input with get, set
    abstract member postProcessedOutputs: Ai_Cf_Baai_Bge_Large_En_V1_5_Output with get, set

type Ai_Cf_Unum_Uform_Gen2_Qwen_500M_Input =
    U2<string, Ai_Cf_Unum_Uform_Gen2_Qwen_500M_Input.U2.Case2>

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Unum_Uform_Gen2_Qwen_500M_Output =
    abstract member description: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Base_Ai_Cf_Unum_Uform_Gen2_Qwen_500M =
    abstract member inputs: Ai_Cf_Unum_Uform_Gen2_Qwen_500M_Input with get, set
    abstract member postProcessedOutputs: Ai_Cf_Unum_Uform_Gen2_Qwen_500M_Output with get, set

type Ai_Cf_Openai_Whisper_Tiny_En_Input =
    U2<string, Ai_Cf_Openai_Whisper_Tiny_En_Input.U2.Case2>

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Openai_Whisper_Tiny_En_Output =
    /// <summary>
    /// The transcription
    /// </summary>
    abstract member text: string with get, set
    abstract member word_count: float option with get, set
    abstract member words: ResizeArray<Ai_Cf_Openai_Whisper_Tiny_En_Output.words> option with get, set
    abstract member vtt: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Base_Ai_Cf_Openai_Whisper_Tiny_En =
    abstract member inputs: Ai_Cf_Openai_Whisper_Tiny_En_Input with get, set
    abstract member postProcessedOutputs: Ai_Cf_Openai_Whisper_Tiny_En_Output with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Openai_Whisper_Large_V3_Turbo_Input =
    /// <summary>
    /// Base64 encoded value of the audio data.
    /// </summary>
    abstract member audio: string with get, set
    /// <summary>
    /// Supported tasks are 'translate' or 'transcribe'.
    /// </summary>
    abstract member task: string option with get, set
    /// <summary>
    /// The language of the audio being transcribed or translated.
    /// </summary>
    abstract member language: string option with get, set
    /// <summary>
    /// Preprocess the audio with a voice activity detection model.
    /// </summary>
    abstract member vad_filter: bool option with get, set
    /// <summary>
    /// A text prompt to help provide context to the model on the contents of the audio.
    /// </summary>
    abstract member initial_prompt: string option with get, set
    /// <summary>
    /// The prefix it appended the the beginning of the output of the transcription and can guide the transcription result.
    /// </summary>
    abstract member prefix: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Openai_Whisper_Large_V3_Turbo_Output =
    abstract member transcription_info: Ai_Cf_Openai_Whisper_Large_V3_Turbo_Output.transcription_info option with get, set
    /// <summary>
    /// The complete transcription of the audio.
    /// </summary>
    abstract member text: string with get, set
    /// <summary>
    /// The total number of words in the transcription.
    /// </summary>
    abstract member word_count: float option with get, set
    abstract member segments: ResizeArray<Ai_Cf_Openai_Whisper_Large_V3_Turbo_Output.segments> option with get, set
    /// <summary>
    /// The transcription in WebVTT format, which includes timing and text information for use in subtitles.
    /// </summary>
    abstract member vtt: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Base_Ai_Cf_Openai_Whisper_Large_V3_Turbo =
    abstract member inputs: Ai_Cf_Openai_Whisper_Large_V3_Turbo_Input with get, set
    abstract member postProcessedOutputs: Ai_Cf_Openai_Whisper_Large_V3_Turbo_Output with get, set

type Ai_Cf_Baai_Bge_M3_Input =
    U3<Ai_Cf_Baai_Bge_M3_Input_QueryAnd_Contexts, Ai_Cf_Baai_Bge_M3_Input_Embedding, Ai_Cf_Baai_Bge_M3_Input.U3.Case3>

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Baai_Bge_M3_Input_QueryAnd_Contexts =
    /// <summary>
    /// A query you wish to perform against the provided contexts. If no query is provided the model with respond with embeddings for contexts
    /// </summary>
    abstract member query: string option with get, set
    /// <summary>
    /// List of provided contexts. Note that the index in this array is important, as the response will refer to it.
    /// </summary>
    abstract member contexts: ResizeArray<Ai_Cf_Baai_Bge_M3_Input_QueryAnd_Contexts.contexts> with get, set
    /// <summary>
    /// When provided with too long context should the model error out or truncate the context to fit?
    /// </summary>
    abstract member truncate_inputs: bool option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Baai_Bge_M3_Input_Embedding =
    abstract member text: U2<string, ResizeArray<string>> with get, set
    /// <summary>
    /// When provided with too long context should the model error out or truncate the context to fit?
    /// </summary>
    abstract member truncate_inputs: bool option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Baai_Bge_M3_Input_QueryAnd_Contexts_1 =
    /// <summary>
    /// A query you wish to perform against the provided contexts. If no query is provided the model with respond with embeddings for contexts
    /// </summary>
    abstract member query: string option with get, set
    /// <summary>
    /// List of provided contexts. Note that the index in this array is important, as the response will refer to it.
    /// </summary>
    abstract member contexts: ResizeArray<Ai_Cf_Baai_Bge_M3_Input_QueryAnd_Contexts_1.contexts> with get, set
    /// <summary>
    /// When provided with too long context should the model error out or truncate the context to fit?
    /// </summary>
    abstract member truncate_inputs: bool option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Baai_Bge_M3_Input_Embedding_1 =
    abstract member text: U2<string, ResizeArray<string>> with get, set
    /// <summary>
    /// When provided with too long context should the model error out or truncate the context to fit?
    /// </summary>
    abstract member truncate_inputs: bool option with get, set

type Ai_Cf_Baai_Bge_M3_Output =
    U4<Ai_Cf_Baai_Bge_M3_Ouput_Query, Ai_Cf_Baai_Bge_M3_Output_EmbeddingFor_Contexts, Ai_Cf_Baai_Bge_M3_Ouput_Embedding, Ai_Cf_Baai_Bge_M3_AsyncResponse>

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Baai_Bge_M3_Ouput_Query =
    abstract member response: ResizeArray<Ai_Cf_Baai_Bge_M3_Ouput_Query.response> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Baai_Bge_M3_Output_EmbeddingFor_Contexts =
    abstract member response: ResizeArray<ResizeArray<float>> option with get, set
    abstract member shape: ResizeArray<float> option with get, set
    /// <summary>
    /// The pooling method used in the embedding process.
    /// </summary>
    abstract member pooling: Ai_Cf_Baai_Bge_M3_Output_EmbeddingFor_Contexts.pooling option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Baai_Bge_M3_Ouput_Embedding =
    abstract member shape: ResizeArray<float> option with get, set
    /// <summary>
    /// Embeddings of the requested text values
    /// </summary>
    abstract member data: ResizeArray<ResizeArray<float>> option with get, set
    /// <summary>
    /// The pooling method used in the embedding process.
    /// </summary>
    abstract member pooling: Ai_Cf_Baai_Bge_M3_Ouput_Embedding.pooling option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Baai_Bge_M3_AsyncResponse =
    /// <summary>
    /// The async request id that can be used to obtain the results.
    /// </summary>
    abstract member request_id: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Base_Ai_Cf_Baai_Bge_M3 =
    abstract member inputs: Ai_Cf_Baai_Bge_M3_Input with get, set
    abstract member postProcessedOutputs: Ai_Cf_Baai_Bge_M3_Output with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Black_Forest_Labs_Flux_1_Schnell_Input =
    /// <summary>
    /// A text description of the image you want to generate.
    /// </summary>
    abstract member prompt: string with get, set
    /// <summary>
    /// The number of diffusion steps; higher values can improve quality but take longer.
    /// </summary>
    abstract member steps: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Black_Forest_Labs_Flux_1_Schnell_Output =
    /// <summary>
    /// The generated image in Base64 format.
    /// </summary>
    abstract member image: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Base_Ai_Cf_Black_Forest_Labs_Flux_1_Schnell =
    abstract member inputs: Ai_Cf_Black_Forest_Labs_Flux_1_Schnell_Input with get, set
    abstract member postProcessedOutputs: Ai_Cf_Black_Forest_Labs_Flux_1_Schnell_Output with get, set

type Ai_Cf_Meta_Llama_3_2_11B_Vision_Instruct_Input =
    U2<Ai_Cf_Meta_Llama_3_2_11B_Vision_Instruct_Prompt, Ai_Cf_Meta_Llama_3_2_11B_Vision_Instruct_Messages>

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Meta_Llama_3_2_11B_Vision_Instruct_Prompt =
    /// <summary>
    /// The input text prompt for the model to generate a response.
    /// </summary>
    abstract member prompt: string with get, set
    abstract member image: U2<ResizeArray<float>, obj> option with get, set
    /// <summary>
    /// If true, a chat template is not applied and you must adhere to the specific model's expected formatting.
    /// </summary>
    abstract member raw: bool option with get, set
    /// <summary>
    /// If true, the response will be streamed back incrementally using SSE, Server Sent Events.
    /// </summary>
    abstract member stream: bool option with get, set
    /// <summary>
    /// The maximum number of tokens to generate in the response.
    /// </summary>
    abstract member max_tokens: float option with get, set
    /// <summary>
    /// Controls the randomness of the output; higher values produce more random results.
    /// </summary>
    abstract member temperature: float option with get, set
    /// <summary>
    /// Adjusts the creativity of the AI's responses by controlling how many possible words it considers. Lower values make outputs more predictable; higher values allow for more varied and creative responses.
    /// </summary>
    abstract member top_p: float option with get, set
    /// <summary>
    /// Limits the AI to choose from the top 'k' most probable words. Lower values make responses more focused; higher values introduce more variety and potential surprises.
    /// </summary>
    abstract member top_k: float option with get, set
    /// <summary>
    /// Random seed for reproducibility of the generation.
    /// </summary>
    abstract member seed: float option with get, set
    /// <summary>
    /// Penalty for repeated tokens; higher values discourage repetition.
    /// </summary>
    abstract member repetition_penalty: float option with get, set
    /// <summary>
    /// Decreases the likelihood of the model repeating the same lines verbatim.
    /// </summary>
    abstract member frequency_penalty: float option with get, set
    /// <summary>
    /// Increases the likelihood of the model introducing new topics.
    /// </summary>
    abstract member presence_penalty: float option with get, set
    /// <summary>
    /// Name of the LoRA (Low-Rank Adaptation) model to fine-tune the base model.
    /// </summary>
    abstract member lora: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Meta_Llama_3_2_11B_Vision_Instruct_Messages =
    /// <summary>
    /// An array of message objects representing the conversation history.
    /// </summary>
    abstract member messages: ResizeArray<Ai_Cf_Meta_Llama_3_2_11B_Vision_Instruct_Messages.messages> with get, set
    abstract member image: U2<ResizeArray<float>, obj> option with get, set
    abstract member functions: ResizeArray<Ai_Cf_Meta_Llama_3_2_11B_Vision_Instruct_Messages.functions> option with get, set
    /// <summary>
    /// A list of tools available for the assistant to use.
    /// </summary>
    abstract member tools: ResizeArray<Ai_Cf_Meta_Llama_3_2_11B_Vision_Instruct_Messages.tools> option with get, set
    /// <summary>
    /// If true, the response will be streamed back incrementally.
    /// </summary>
    abstract member stream: bool option with get, set
    /// <summary>
    /// The maximum number of tokens to generate in the response.
    /// </summary>
    abstract member max_tokens: float option with get, set
    /// <summary>
    /// Controls the randomness of the output; higher values produce more random results.
    /// </summary>
    abstract member temperature: float option with get, set
    /// <summary>
    /// Controls the creativity of the AI's responses by adjusting how many possible words it considers. Lower values make outputs more predictable; higher values allow for more varied and creative responses.
    /// </summary>
    abstract member top_p: float option with get, set
    /// <summary>
    /// Limits the AI to choose from the top 'k' most probable words. Lower values make responses more focused; higher values introduce more variety and potential surprises.
    /// </summary>
    abstract member top_k: float option with get, set
    /// <summary>
    /// Random seed for reproducibility of the generation.
    /// </summary>
    abstract member seed: float option with get, set
    /// <summary>
    /// Penalty for repeated tokens; higher values discourage repetition.
    /// </summary>
    abstract member repetition_penalty: float option with get, set
    /// <summary>
    /// Decreases the likelihood of the model repeating the same lines verbatim.
    /// </summary>
    abstract member frequency_penalty: float option with get, set
    /// <summary>
    /// Increases the likelihood of the model introducing new topics.
    /// </summary>
    abstract member presence_penalty: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Meta_Llama_3_2_11B_Vision_Instruct_Output =
    /// <summary>
    /// The generated text response from the model
    /// </summary>
    abstract member response: string option with get, set
    /// <summary>
    /// An array of tool calls requests made during the response generation
    /// </summary>
    abstract member tool_calls: ResizeArray<Ai_Cf_Meta_Llama_3_2_11B_Vision_Instruct_Output.tool_calls> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Base_Ai_Cf_Meta_Llama_3_2_11B_Vision_Instruct =
    abstract member inputs: Ai_Cf_Meta_Llama_3_2_11B_Vision_Instruct_Input with get, set
    abstract member postProcessedOutputs: Ai_Cf_Meta_Llama_3_2_11B_Vision_Instruct_Output with get, set

type Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_Input =
    U3<Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_Prompt, Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_Messages, Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_Async_Batch>

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_Prompt =
    /// <summary>
    /// The input text prompt for the model to generate a response.
    /// </summary>
    abstract member prompt: string with get, set
    /// <summary>
    /// Name of the LoRA (Low-Rank Adaptation) model to fine-tune the base model.
    /// </summary>
    abstract member lora: string option with get, set
    abstract member response_format: Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_JSON_Mode option with get, set
    /// <summary>
    /// If true, a chat template is not applied and you must adhere to the specific model's expected formatting.
    /// </summary>
    abstract member raw: bool option with get, set
    /// <summary>
    /// If true, the response will be streamed back incrementally using SSE, Server Sent Events.
    /// </summary>
    abstract member stream: bool option with get, set
    /// <summary>
    /// The maximum number of tokens to generate in the response.
    /// </summary>
    abstract member max_tokens: float option with get, set
    /// <summary>
    /// Controls the randomness of the output; higher values produce more random results.
    /// </summary>
    abstract member temperature: float option with get, set
    /// <summary>
    /// Adjusts the creativity of the AI's responses by controlling how many possible words it considers. Lower values make outputs more predictable; higher values allow for more varied and creative responses.
    /// </summary>
    abstract member top_p: float option with get, set
    /// <summary>
    /// Limits the AI to choose from the top 'k' most probable words. Lower values make responses more focused; higher values introduce more variety and potential surprises.
    /// </summary>
    abstract member top_k: float option with get, set
    /// <summary>
    /// Random seed for reproducibility of the generation.
    /// </summary>
    abstract member seed: float option with get, set
    /// <summary>
    /// Penalty for repeated tokens; higher values discourage repetition.
    /// </summary>
    abstract member repetition_penalty: float option with get, set
    /// <summary>
    /// Decreases the likelihood of the model repeating the same lines verbatim.
    /// </summary>
    abstract member frequency_penalty: float option with get, set
    /// <summary>
    /// Increases the likelihood of the model introducing new topics.
    /// </summary>
    abstract member presence_penalty: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_JSON_Mode =
    abstract member ``type``: Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_JSON_Mode.``type`` option with get, set
    abstract member json_schema: obj option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_Messages =
    /// <summary>
    /// An array of message objects representing the conversation history.
    /// </summary>
    abstract member messages: ResizeArray<Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_Messages.messages> with get, set
    abstract member functions: ResizeArray<Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_Messages.functions> option with get, set
    /// <summary>
    /// A list of tools available for the assistant to use.
    /// </summary>
    abstract member tools: ResizeArray<Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_Messages.tools> option with get, set
    abstract member response_format: Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_JSON_Mode_1 option with get, set
    /// <summary>
    /// If true, a chat template is not applied and you must adhere to the specific model's expected formatting.
    /// </summary>
    abstract member raw: bool option with get, set
    /// <summary>
    /// If true, the response will be streamed back incrementally using SSE, Server Sent Events.
    /// </summary>
    abstract member stream: bool option with get, set
    /// <summary>
    /// The maximum number of tokens to generate in the response.
    /// </summary>
    abstract member max_tokens: float option with get, set
    /// <summary>
    /// Controls the randomness of the output; higher values produce more random results.
    /// </summary>
    abstract member temperature: float option with get, set
    /// <summary>
    /// Adjusts the creativity of the AI's responses by controlling how many possible words it considers. Lower values make outputs more predictable; higher values allow for more varied and creative responses.
    /// </summary>
    abstract member top_p: float option with get, set
    /// <summary>
    /// Limits the AI to choose from the top 'k' most probable words. Lower values make responses more focused; higher values introduce more variety and potential surprises.
    /// </summary>
    abstract member top_k: float option with get, set
    /// <summary>
    /// Random seed for reproducibility of the generation.
    /// </summary>
    abstract member seed: float option with get, set
    /// <summary>
    /// Penalty for repeated tokens; higher values discourage repetition.
    /// </summary>
    abstract member repetition_penalty: float option with get, set
    /// <summary>
    /// Decreases the likelihood of the model repeating the same lines verbatim.
    /// </summary>
    abstract member frequency_penalty: float option with get, set
    /// <summary>
    /// Increases the likelihood of the model introducing new topics.
    /// </summary>
    abstract member presence_penalty: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_JSON_Mode_1 =
    abstract member ``type``: Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_JSON_Mode_1.``type`` option with get, set
    abstract member json_schema: obj option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_Async_Batch =
    abstract member requests: ResizeArray<Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_Async_Batch.requests> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_JSON_Mode_2 =
    abstract member ``type``: Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_JSON_Mode_2.``type`` option with get, set
    abstract member json_schema: obj option with get, set

type Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_Output =
    U3<Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_Output.U3.Case1, string, Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_AsyncResponse>

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_AsyncResponse =
    /// <summary>
    /// The async request id that can be used to obtain the results.
    /// </summary>
    abstract member request_id: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Base_Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast =
    abstract member inputs: Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_Input with get, set
    abstract member postProcessedOutputs: Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_Output with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Meta_Llama_Guard_3_8B_Input =
    /// <summary>
    /// An array of message objects representing the conversation history.
    /// </summary>
    abstract member messages: ResizeArray<Ai_Cf_Meta_Llama_Guard_3_8B_Input.messages> with get, set
    /// <summary>
    /// The maximum number of tokens to generate in the response.
    /// </summary>
    abstract member max_tokens: float option with get, set
    /// <summary>
    /// Controls the randomness of the output; higher values produce more random results.
    /// </summary>
    abstract member temperature: float option with get, set
    /// <summary>
    /// Dictate the output format of the generated response.
    /// </summary>
    abstract member response_format: Ai_Cf_Meta_Llama_Guard_3_8B_Input.response_format option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Meta_Llama_Guard_3_8B_Output =
    abstract member response: U2<string, Ai_Cf_Meta_Llama_Guard_3_8B_Output.response.U2.Case2> option with get, set
    /// <summary>
    /// Usage statistics for the inference request
    /// </summary>
    abstract member usage: Ai_Cf_Meta_Llama_Guard_3_8B_Output.usage option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Base_Ai_Cf_Meta_Llama_Guard_3_8B =
    abstract member inputs: Ai_Cf_Meta_Llama_Guard_3_8B_Input with get, set
    abstract member postProcessedOutputs: Ai_Cf_Meta_Llama_Guard_3_8B_Output with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Baai_Bge_Reranker_Base_Input =
    /// <summary>
    /// Number of returned results starting with the best score.
    /// </summary>
    abstract member top_k: float option with get, set
    /// <summary>
    /// List of provided contexts. Note that the index in this array is important, as the response will refer to it.
    /// </summary>
    abstract member contexts: ResizeArray<Ai_Cf_Baai_Bge_Reranker_Base_Input.contexts> with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Baai_Bge_Reranker_Base_Output =
    abstract member response: ResizeArray<Ai_Cf_Baai_Bge_Reranker_Base_Output.response> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Base_Ai_Cf_Baai_Bge_Reranker_Base =
    abstract member inputs: Ai_Cf_Baai_Bge_Reranker_Base_Input with get, set
    abstract member postProcessedOutputs: Ai_Cf_Baai_Bge_Reranker_Base_Output with get, set

type Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct_Input =
    U2<Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct_Prompt, Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct_Messages>

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct_Prompt =
    /// <summary>
    /// The input text prompt for the model to generate a response.
    /// </summary>
    abstract member prompt: string with get, set
    /// <summary>
    /// Name of the LoRA (Low-Rank Adaptation) model to fine-tune the base model.
    /// </summary>
    abstract member lora: string option with get, set
    abstract member response_format: Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct_JSON_Mode option with get, set
    /// <summary>
    /// If true, a chat template is not applied and you must adhere to the specific model's expected formatting.
    /// </summary>
    abstract member raw: bool option with get, set
    /// <summary>
    /// If true, the response will be streamed back incrementally using SSE, Server Sent Events.
    /// </summary>
    abstract member stream: bool option with get, set
    /// <summary>
    /// The maximum number of tokens to generate in the response.
    /// </summary>
    abstract member max_tokens: float option with get, set
    /// <summary>
    /// Controls the randomness of the output; higher values produce more random results.
    /// </summary>
    abstract member temperature: float option with get, set
    /// <summary>
    /// Adjusts the creativity of the AI's responses by controlling how many possible words it considers. Lower values make outputs more predictable; higher values allow for more varied and creative responses.
    /// </summary>
    abstract member top_p: float option with get, set
    /// <summary>
    /// Limits the AI to choose from the top 'k' most probable words. Lower values make responses more focused; higher values introduce more variety and potential surprises.
    /// </summary>
    abstract member top_k: float option with get, set
    /// <summary>
    /// Random seed for reproducibility of the generation.
    /// </summary>
    abstract member seed: float option with get, set
    /// <summary>
    /// Penalty for repeated tokens; higher values discourage repetition.
    /// </summary>
    abstract member repetition_penalty: float option with get, set
    /// <summary>
    /// Decreases the likelihood of the model repeating the same lines verbatim.
    /// </summary>
    abstract member frequency_penalty: float option with get, set
    /// <summary>
    /// Increases the likelihood of the model introducing new topics.
    /// </summary>
    abstract member presence_penalty: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct_JSON_Mode =
    abstract member ``type``: Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct_JSON_Mode.``type`` option with get, set
    abstract member json_schema: obj option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct_Messages =
    /// <summary>
    /// An array of message objects representing the conversation history.
    /// </summary>
    abstract member messages: ResizeArray<Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct_Messages.messages> with get, set
    abstract member functions: ResizeArray<Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct_Messages.functions> option with get, set
    /// <summary>
    /// A list of tools available for the assistant to use.
    /// </summary>
    abstract member tools: ResizeArray<Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct_Messages.tools> option with get, set
    abstract member response_format: Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct_JSON_Mode_1 option with get, set
    /// <summary>
    /// If true, a chat template is not applied and you must adhere to the specific model's expected formatting.
    /// </summary>
    abstract member raw: bool option with get, set
    /// <summary>
    /// If true, the response will be streamed back incrementally using SSE, Server Sent Events.
    /// </summary>
    abstract member stream: bool option with get, set
    /// <summary>
    /// The maximum number of tokens to generate in the response.
    /// </summary>
    abstract member max_tokens: float option with get, set
    /// <summary>
    /// Controls the randomness of the output; higher values produce more random results.
    /// </summary>
    abstract member temperature: float option with get, set
    /// <summary>
    /// Adjusts the creativity of the AI's responses by controlling how many possible words it considers. Lower values make outputs more predictable; higher values allow for more varied and creative responses.
    /// </summary>
    abstract member top_p: float option with get, set
    /// <summary>
    /// Limits the AI to choose from the top 'k' most probable words. Lower values make responses more focused; higher values introduce more variety and potential surprises.
    /// </summary>
    abstract member top_k: float option with get, set
    /// <summary>
    /// Random seed for reproducibility of the generation.
    /// </summary>
    abstract member seed: float option with get, set
    /// <summary>
    /// Penalty for repeated tokens; higher values discourage repetition.
    /// </summary>
    abstract member repetition_penalty: float option with get, set
    /// <summary>
    /// Decreases the likelihood of the model repeating the same lines verbatim.
    /// </summary>
    abstract member frequency_penalty: float option with get, set
    /// <summary>
    /// Increases the likelihood of the model introducing new topics.
    /// </summary>
    abstract member presence_penalty: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct_JSON_Mode_1 =
    abstract member ``type``: Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct_JSON_Mode_1.``type`` option with get, set
    abstract member json_schema: obj option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct_Output =
    /// <summary>
    /// The generated text response from the model
    /// </summary>
    abstract member response: string with get, set
    /// <summary>
    /// Usage statistics for the inference request
    /// </summary>
    abstract member usage: Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct_Output.usage option with get, set
    /// <summary>
    /// An array of tool calls requests made during the response generation
    /// </summary>
    abstract member tool_calls: ResizeArray<Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct_Output.tool_calls> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Base_Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct =
    abstract member inputs: Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct_Input with get, set
    abstract member postProcessedOutputs: Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct_Output with get, set

type Ai_Cf_Qwen_Qwq_32B_Input =
    U2<Ai_Cf_Qwen_Qwq_32B_Prompt, Ai_Cf_Qwen_Qwq_32B_Messages>

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Qwen_Qwq_32B_Prompt =
    /// <summary>
    /// The input text prompt for the model to generate a response.
    /// </summary>
    abstract member prompt: string with get, set
    /// <summary>
    /// JSON schema that should be fulfilled for the response.
    /// </summary>
    abstract member guided_json: obj option with get, set
    /// <summary>
    /// If true, a chat template is not applied and you must adhere to the specific model's expected formatting.
    /// </summary>
    abstract member raw: bool option with get, set
    /// <summary>
    /// If true, the response will be streamed back incrementally using SSE, Server Sent Events.
    /// </summary>
    abstract member stream: bool option with get, set
    /// <summary>
    /// The maximum number of tokens to generate in the response.
    /// </summary>
    abstract member max_tokens: float option with get, set
    /// <summary>
    /// Controls the randomness of the output; higher values produce more random results.
    /// </summary>
    abstract member temperature: float option with get, set
    /// <summary>
    /// Adjusts the creativity of the AI's responses by controlling how many possible words it considers. Lower values make outputs more predictable; higher values allow for more varied and creative responses.
    /// </summary>
    abstract member top_p: float option with get, set
    /// <summary>
    /// Limits the AI to choose from the top 'k' most probable words. Lower values make responses more focused; higher values introduce more variety and potential surprises.
    /// </summary>
    abstract member top_k: float option with get, set
    /// <summary>
    /// Random seed for reproducibility of the generation.
    /// </summary>
    abstract member seed: float option with get, set
    /// <summary>
    /// Penalty for repeated tokens; higher values discourage repetition.
    /// </summary>
    abstract member repetition_penalty: float option with get, set
    /// <summary>
    /// Decreases the likelihood of the model repeating the same lines verbatim.
    /// </summary>
    abstract member frequency_penalty: float option with get, set
    /// <summary>
    /// Increases the likelihood of the model introducing new topics.
    /// </summary>
    abstract member presence_penalty: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Qwen_Qwq_32B_Messages =
    /// <summary>
    /// An array of message objects representing the conversation history.
    /// </summary>
    abstract member messages: ResizeArray<Ai_Cf_Qwen_Qwq_32B_Messages.messages> with get, set
    abstract member functions: ResizeArray<Ai_Cf_Qwen_Qwq_32B_Messages.functions> option with get, set
    /// <summary>
    /// A list of tools available for the assistant to use.
    /// </summary>
    abstract member tools: ResizeArray<Ai_Cf_Qwen_Qwq_32B_Messages.tools> option with get, set
    /// <summary>
    /// JSON schema that should be fulfilled for the response.
    /// </summary>
    abstract member guided_json: obj option with get, set
    /// <summary>
    /// If true, a chat template is not applied and you must adhere to the specific model's expected formatting.
    /// </summary>
    abstract member raw: bool option with get, set
    /// <summary>
    /// If true, the response will be streamed back incrementally using SSE, Server Sent Events.
    /// </summary>
    abstract member stream: bool option with get, set
    /// <summary>
    /// The maximum number of tokens to generate in the response.
    /// </summary>
    abstract member max_tokens: float option with get, set
    /// <summary>
    /// Controls the randomness of the output; higher values produce more random results.
    /// </summary>
    abstract member temperature: float option with get, set
    /// <summary>
    /// Adjusts the creativity of the AI's responses by controlling how many possible words it considers. Lower values make outputs more predictable; higher values allow for more varied and creative responses.
    /// </summary>
    abstract member top_p: float option with get, set
    /// <summary>
    /// Limits the AI to choose from the top 'k' most probable words. Lower values make responses more focused; higher values introduce more variety and potential surprises.
    /// </summary>
    abstract member top_k: float option with get, set
    /// <summary>
    /// Random seed for reproducibility of the generation.
    /// </summary>
    abstract member seed: float option with get, set
    /// <summary>
    /// Penalty for repeated tokens; higher values discourage repetition.
    /// </summary>
    abstract member repetition_penalty: float option with get, set
    /// <summary>
    /// Decreases the likelihood of the model repeating the same lines verbatim.
    /// </summary>
    abstract member frequency_penalty: float option with get, set
    /// <summary>
    /// Increases the likelihood of the model introducing new topics.
    /// </summary>
    abstract member presence_penalty: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Qwen_Qwq_32B_Output =
    /// <summary>
    /// The generated text response from the model
    /// </summary>
    abstract member response: string with get, set
    /// <summary>
    /// Usage statistics for the inference request
    /// </summary>
    abstract member usage: Ai_Cf_Qwen_Qwq_32B_Output.usage option with get, set
    /// <summary>
    /// An array of tool calls requests made during the response generation
    /// </summary>
    abstract member tool_calls: ResizeArray<Ai_Cf_Qwen_Qwq_32B_Output.tool_calls> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Base_Ai_Cf_Qwen_Qwq_32B =
    abstract member inputs: Ai_Cf_Qwen_Qwq_32B_Input with get, set
    abstract member postProcessedOutputs: Ai_Cf_Qwen_Qwq_32B_Output with get, set

type Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct_Input =
    U2<Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct_Prompt, Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct_Messages>

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct_Prompt =
    /// <summary>
    /// The input text prompt for the model to generate a response.
    /// </summary>
    abstract member prompt: string with get, set
    /// <summary>
    /// JSON schema that should be fulfilled for the response.
    /// </summary>
    abstract member guided_json: obj option with get, set
    /// <summary>
    /// If true, a chat template is not applied and you must adhere to the specific model's expected formatting.
    /// </summary>
    abstract member raw: bool option with get, set
    /// <summary>
    /// If true, the response will be streamed back incrementally using SSE, Server Sent Events.
    /// </summary>
    abstract member stream: bool option with get, set
    /// <summary>
    /// The maximum number of tokens to generate in the response.
    /// </summary>
    abstract member max_tokens: float option with get, set
    /// <summary>
    /// Controls the randomness of the output; higher values produce more random results.
    /// </summary>
    abstract member temperature: float option with get, set
    /// <summary>
    /// Adjusts the creativity of the AI's responses by controlling how many possible words it considers. Lower values make outputs more predictable; higher values allow for more varied and creative responses.
    /// </summary>
    abstract member top_p: float option with get, set
    /// <summary>
    /// Limits the AI to choose from the top 'k' most probable words. Lower values make responses more focused; higher values introduce more variety and potential surprises.
    /// </summary>
    abstract member top_k: float option with get, set
    /// <summary>
    /// Random seed for reproducibility of the generation.
    /// </summary>
    abstract member seed: float option with get, set
    /// <summary>
    /// Penalty for repeated tokens; higher values discourage repetition.
    /// </summary>
    abstract member repetition_penalty: float option with get, set
    /// <summary>
    /// Decreases the likelihood of the model repeating the same lines verbatim.
    /// </summary>
    abstract member frequency_penalty: float option with get, set
    /// <summary>
    /// Increases the likelihood of the model introducing new topics.
    /// </summary>
    abstract member presence_penalty: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct_Messages =
    /// <summary>
    /// An array of message objects representing the conversation history.
    /// </summary>
    abstract member messages: ResizeArray<Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct_Messages.messages> with get, set
    abstract member functions: ResizeArray<Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct_Messages.functions> option with get, set
    /// <summary>
    /// A list of tools available for the assistant to use.
    /// </summary>
    abstract member tools: ResizeArray<Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct_Messages.tools> option with get, set
    /// <summary>
    /// JSON schema that should be fulfilled for the response.
    /// </summary>
    abstract member guided_json: obj option with get, set
    /// <summary>
    /// If true, a chat template is not applied and you must adhere to the specific model's expected formatting.
    /// </summary>
    abstract member raw: bool option with get, set
    /// <summary>
    /// If true, the response will be streamed back incrementally using SSE, Server Sent Events.
    /// </summary>
    abstract member stream: bool option with get, set
    /// <summary>
    /// The maximum number of tokens to generate in the response.
    /// </summary>
    abstract member max_tokens: float option with get, set
    /// <summary>
    /// Controls the randomness of the output; higher values produce more random results.
    /// </summary>
    abstract member temperature: float option with get, set
    /// <summary>
    /// Adjusts the creativity of the AI's responses by controlling how many possible words it considers. Lower values make outputs more predictable; higher values allow for more varied and creative responses.
    /// </summary>
    abstract member top_p: float option with get, set
    /// <summary>
    /// Limits the AI to choose from the top 'k' most probable words. Lower values make responses more focused; higher values introduce more variety and potential surprises.
    /// </summary>
    abstract member top_k: float option with get, set
    /// <summary>
    /// Random seed for reproducibility of the generation.
    /// </summary>
    abstract member seed: float option with get, set
    /// <summary>
    /// Penalty for repeated tokens; higher values discourage repetition.
    /// </summary>
    abstract member repetition_penalty: float option with get, set
    /// <summary>
    /// Decreases the likelihood of the model repeating the same lines verbatim.
    /// </summary>
    abstract member frequency_penalty: float option with get, set
    /// <summary>
    /// Increases the likelihood of the model introducing new topics.
    /// </summary>
    abstract member presence_penalty: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct_Output =
    /// <summary>
    /// The generated text response from the model
    /// </summary>
    abstract member response: string with get, set
    /// <summary>
    /// Usage statistics for the inference request
    /// </summary>
    abstract member usage: Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct_Output.usage option with get, set
    /// <summary>
    /// An array of tool calls requests made during the response generation
    /// </summary>
    abstract member tool_calls: ResizeArray<Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct_Output.tool_calls> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Base_Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct =
    abstract member inputs: Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct_Input with get, set
    abstract member postProcessedOutputs: Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct_Output with get, set

type Ai_Cf_Google_Gemma_3_12B_It_Input =
    U2<Ai_Cf_Google_Gemma_3_12B_It_Prompt, Ai_Cf_Google_Gemma_3_12B_It_Messages>

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Google_Gemma_3_12B_It_Prompt =
    /// <summary>
    /// The input text prompt for the model to generate a response.
    /// </summary>
    abstract member prompt: string with get, set
    /// <summary>
    /// JSON schema that should be fulfilled for the response.
    /// </summary>
    abstract member guided_json: obj option with get, set
    /// <summary>
    /// If true, a chat template is not applied and you must adhere to the specific model's expected formatting.
    /// </summary>
    abstract member raw: bool option with get, set
    /// <summary>
    /// If true, the response will be streamed back incrementally using SSE, Server Sent Events.
    /// </summary>
    abstract member stream: bool option with get, set
    /// <summary>
    /// The maximum number of tokens to generate in the response.
    /// </summary>
    abstract member max_tokens: float option with get, set
    /// <summary>
    /// Controls the randomness of the output; higher values produce more random results.
    /// </summary>
    abstract member temperature: float option with get, set
    /// <summary>
    /// Adjusts the creativity of the AI's responses by controlling how many possible words it considers. Lower values make outputs more predictable; higher values allow for more varied and creative responses.
    /// </summary>
    abstract member top_p: float option with get, set
    /// <summary>
    /// Limits the AI to choose from the top 'k' most probable words. Lower values make responses more focused; higher values introduce more variety and potential surprises.
    /// </summary>
    abstract member top_k: float option with get, set
    /// <summary>
    /// Random seed for reproducibility of the generation.
    /// </summary>
    abstract member seed: float option with get, set
    /// <summary>
    /// Penalty for repeated tokens; higher values discourage repetition.
    /// </summary>
    abstract member repetition_penalty: float option with get, set
    /// <summary>
    /// Decreases the likelihood of the model repeating the same lines verbatim.
    /// </summary>
    abstract member frequency_penalty: float option with get, set
    /// <summary>
    /// Increases the likelihood of the model introducing new topics.
    /// </summary>
    abstract member presence_penalty: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Google_Gemma_3_12B_It_Messages =
    /// <summary>
    /// An array of message objects representing the conversation history.
    /// </summary>
    abstract member messages: ResizeArray<Ai_Cf_Google_Gemma_3_12B_It_Messages.messages> with get, set
    abstract member functions: ResizeArray<Ai_Cf_Google_Gemma_3_12B_It_Messages.functions> option with get, set
    /// <summary>
    /// A list of tools available for the assistant to use.
    /// </summary>
    abstract member tools: ResizeArray<Ai_Cf_Google_Gemma_3_12B_It_Messages.tools> option with get, set
    /// <summary>
    /// JSON schema that should be fulfilled for the response.
    /// </summary>
    abstract member guided_json: obj option with get, set
    /// <summary>
    /// If true, a chat template is not applied and you must adhere to the specific model's expected formatting.
    /// </summary>
    abstract member raw: bool option with get, set
    /// <summary>
    /// If true, the response will be streamed back incrementally using SSE, Server Sent Events.
    /// </summary>
    abstract member stream: bool option with get, set
    /// <summary>
    /// The maximum number of tokens to generate in the response.
    /// </summary>
    abstract member max_tokens: float option with get, set
    /// <summary>
    /// Controls the randomness of the output; higher values produce more random results.
    /// </summary>
    abstract member temperature: float option with get, set
    /// <summary>
    /// Adjusts the creativity of the AI's responses by controlling how many possible words it considers. Lower values make outputs more predictable; higher values allow for more varied and creative responses.
    /// </summary>
    abstract member top_p: float option with get, set
    /// <summary>
    /// Limits the AI to choose from the top 'k' most probable words. Lower values make responses more focused; higher values introduce more variety and potential surprises.
    /// </summary>
    abstract member top_k: float option with get, set
    /// <summary>
    /// Random seed for reproducibility of the generation.
    /// </summary>
    abstract member seed: float option with get, set
    /// <summary>
    /// Penalty for repeated tokens; higher values discourage repetition.
    /// </summary>
    abstract member repetition_penalty: float option with get, set
    /// <summary>
    /// Decreases the likelihood of the model repeating the same lines verbatim.
    /// </summary>
    abstract member frequency_penalty: float option with get, set
    /// <summary>
    /// Increases the likelihood of the model introducing new topics.
    /// </summary>
    abstract member presence_penalty: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Google_Gemma_3_12B_It_Output =
    /// <summary>
    /// The generated text response from the model
    /// </summary>
    abstract member response: string with get, set
    /// <summary>
    /// Usage statistics for the inference request
    /// </summary>
    abstract member usage: Ai_Cf_Google_Gemma_3_12B_It_Output.usage option with get, set
    /// <summary>
    /// An array of tool calls requests made during the response generation
    /// </summary>
    abstract member tool_calls: ResizeArray<Ai_Cf_Google_Gemma_3_12B_It_Output.tool_calls> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Base_Ai_Cf_Google_Gemma_3_12B_It =
    abstract member inputs: Ai_Cf_Google_Gemma_3_12B_It_Input with get, set
    abstract member postProcessedOutputs: Ai_Cf_Google_Gemma_3_12B_It_Output with get, set

type Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Input =
    U3<Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Prompt, Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages, Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Async_Batch>

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Prompt =
    /// <summary>
    /// The input text prompt for the model to generate a response.
    /// </summary>
    abstract member prompt: string with get, set
    /// <summary>
    /// JSON schema that should be fulfilled for the response.
    /// </summary>
    abstract member guided_json: obj option with get, set
    abstract member response_format: Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_JSON_Mode option with get, set
    /// <summary>
    /// If true, a chat template is not applied and you must adhere to the specific model's expected formatting.
    /// </summary>
    abstract member raw: bool option with get, set
    /// <summary>
    /// If true, the response will be streamed back incrementally using SSE, Server Sent Events.
    /// </summary>
    abstract member stream: bool option with get, set
    /// <summary>
    /// The maximum number of tokens to generate in the response.
    /// </summary>
    abstract member max_tokens: float option with get, set
    /// <summary>
    /// Controls the randomness of the output; higher values produce more random results.
    /// </summary>
    abstract member temperature: float option with get, set
    /// <summary>
    /// Adjusts the creativity of the AI's responses by controlling how many possible words it considers. Lower values make outputs more predictable; higher values allow for more varied and creative responses.
    /// </summary>
    abstract member top_p: float option with get, set
    /// <summary>
    /// Limits the AI to choose from the top 'k' most probable words. Lower values make responses more focused; higher values introduce more variety and potential surprises.
    /// </summary>
    abstract member top_k: float option with get, set
    /// <summary>
    /// Random seed for reproducibility of the generation.
    /// </summary>
    abstract member seed: float option with get, set
    /// <summary>
    /// Penalty for repeated tokens; higher values discourage repetition.
    /// </summary>
    abstract member repetition_penalty: float option with get, set
    /// <summary>
    /// Decreases the likelihood of the model repeating the same lines verbatim.
    /// </summary>
    abstract member frequency_penalty: float option with get, set
    /// <summary>
    /// Increases the likelihood of the model introducing new topics.
    /// </summary>
    abstract member presence_penalty: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_JSON_Mode =
    abstract member ``type``: Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_JSON_Mode.``type`` option with get, set
    abstract member json_schema: obj option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages =
    /// <summary>
    /// An array of message objects representing the conversation history.
    /// </summary>
    abstract member messages: ResizeArray<Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages.messages> with get, set
    abstract member functions: ResizeArray<Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages.functions> option with get, set
    /// <summary>
    /// A list of tools available for the assistant to use.
    /// </summary>
    abstract member tools: ResizeArray<Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages.tools> option with get, set
    abstract member response_format: Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_JSON_Mode option with get, set
    /// <summary>
    /// JSON schema that should be fulfilled for the response.
    /// </summary>
    abstract member guided_json: obj option with get, set
    /// <summary>
    /// If true, a chat template is not applied and you must adhere to the specific model's expected formatting.
    /// </summary>
    abstract member raw: bool option with get, set
    /// <summary>
    /// If true, the response will be streamed back incrementally using SSE, Server Sent Events.
    /// </summary>
    abstract member stream: bool option with get, set
    /// <summary>
    /// The maximum number of tokens to generate in the response.
    /// </summary>
    abstract member max_tokens: float option with get, set
    /// <summary>
    /// Controls the randomness of the output; higher values produce more random results.
    /// </summary>
    abstract member temperature: float option with get, set
    /// <summary>
    /// Adjusts the creativity of the AI's responses by controlling how many possible words it considers. Lower values make outputs more predictable; higher values allow for more varied and creative responses.
    /// </summary>
    abstract member top_p: float option with get, set
    /// <summary>
    /// Limits the AI to choose from the top 'k' most probable words. Lower values make responses more focused; higher values introduce more variety and potential surprises.
    /// </summary>
    abstract member top_k: float option with get, set
    /// <summary>
    /// Random seed for reproducibility of the generation.
    /// </summary>
    abstract member seed: float option with get, set
    /// <summary>
    /// Penalty for repeated tokens; higher values discourage repetition.
    /// </summary>
    abstract member repetition_penalty: float option with get, set
    /// <summary>
    /// Decreases the likelihood of the model repeating the same lines verbatim.
    /// </summary>
    abstract member frequency_penalty: float option with get, set
    /// <summary>
    /// Increases the likelihood of the model introducing new topics.
    /// </summary>
    abstract member presence_penalty: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Async_Batch =
    abstract member requests: ResizeArray<U2<Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Prompt_Inner, Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages_Inner>> with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Prompt_Inner =
    /// <summary>
    /// The input text prompt for the model to generate a response.
    /// </summary>
    abstract member prompt: string with get, set
    /// <summary>
    /// JSON schema that should be fulfilled for the response.
    /// </summary>
    abstract member guided_json: obj option with get, set
    abstract member response_format: Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_JSON_Mode option with get, set
    /// <summary>
    /// If true, a chat template is not applied and you must adhere to the specific model's expected formatting.
    /// </summary>
    abstract member raw: bool option with get, set
    /// <summary>
    /// If true, the response will be streamed back incrementally using SSE, Server Sent Events.
    /// </summary>
    abstract member stream: bool option with get, set
    /// <summary>
    /// The maximum number of tokens to generate in the response.
    /// </summary>
    abstract member max_tokens: float option with get, set
    /// <summary>
    /// Controls the randomness of the output; higher values produce more random results.
    /// </summary>
    abstract member temperature: float option with get, set
    /// <summary>
    /// Adjusts the creativity of the AI's responses by controlling how many possible words it considers. Lower values make outputs more predictable; higher values allow for more varied and creative responses.
    /// </summary>
    abstract member top_p: float option with get, set
    /// <summary>
    /// Limits the AI to choose from the top 'k' most probable words. Lower values make responses more focused; higher values introduce more variety and potential surprises.
    /// </summary>
    abstract member top_k: float option with get, set
    /// <summary>
    /// Random seed for reproducibility of the generation.
    /// </summary>
    abstract member seed: float option with get, set
    /// <summary>
    /// Penalty for repeated tokens; higher values discourage repetition.
    /// </summary>
    abstract member repetition_penalty: float option with get, set
    /// <summary>
    /// Decreases the likelihood of the model repeating the same lines verbatim.
    /// </summary>
    abstract member frequency_penalty: float option with get, set
    /// <summary>
    /// Increases the likelihood of the model introducing new topics.
    /// </summary>
    abstract member presence_penalty: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages_Inner =
    /// <summary>
    /// An array of message objects representing the conversation history.
    /// </summary>
    abstract member messages: ResizeArray<Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages_Inner.messages> with get, set
    abstract member functions: ResizeArray<Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages_Inner.functions> option with get, set
    /// <summary>
    /// A list of tools available for the assistant to use.
    /// </summary>
    abstract member tools: ResizeArray<Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages_Inner.tools> option with get, set
    abstract member response_format: Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_JSON_Mode option with get, set
    /// <summary>
    /// JSON schema that should be fulfilled for the response.
    /// </summary>
    abstract member guided_json: obj option with get, set
    /// <summary>
    /// If true, a chat template is not applied and you must adhere to the specific model's expected formatting.
    /// </summary>
    abstract member raw: bool option with get, set
    /// <summary>
    /// If true, the response will be streamed back incrementally using SSE, Server Sent Events.
    /// </summary>
    abstract member stream: bool option with get, set
    /// <summary>
    /// The maximum number of tokens to generate in the response.
    /// </summary>
    abstract member max_tokens: float option with get, set
    /// <summary>
    /// Controls the randomness of the output; higher values produce more random results.
    /// </summary>
    abstract member temperature: float option with get, set
    /// <summary>
    /// Adjusts the creativity of the AI's responses by controlling how many possible words it considers. Lower values make outputs more predictable; higher values allow for more varied and creative responses.
    /// </summary>
    abstract member top_p: float option with get, set
    /// <summary>
    /// Limits the AI to choose from the top 'k' most probable words. Lower values make responses more focused; higher values introduce more variety and potential surprises.
    /// </summary>
    abstract member top_k: float option with get, set
    /// <summary>
    /// Random seed for reproducibility of the generation.
    /// </summary>
    abstract member seed: float option with get, set
    /// <summary>
    /// Penalty for repeated tokens; higher values discourage repetition.
    /// </summary>
    abstract member repetition_penalty: float option with get, set
    /// <summary>
    /// Decreases the likelihood of the model repeating the same lines verbatim.
    /// </summary>
    abstract member frequency_penalty: float option with get, set
    /// <summary>
    /// Increases the likelihood of the model introducing new topics.
    /// </summary>
    abstract member presence_penalty: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Output =
    /// <summary>
    /// The generated text response from the model
    /// </summary>
    abstract member response: string with get, set
    /// <summary>
    /// Usage statistics for the inference request
    /// </summary>
    abstract member usage: Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Output.usage option with get, set
    /// <summary>
    /// An array of tool calls requests made during the response generation
    /// </summary>
    abstract member tool_calls: ResizeArray<Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Output.tool_calls> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Base_Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct =
    abstract member inputs: Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Input with get, set
    abstract member postProcessedOutputs: Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Output with get, set

type Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Input =
    U3<Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Prompt, Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Messages, Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Async_Batch>

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Prompt =
    /// <summary>
    /// The input text prompt for the model to generate a response.
    /// </summary>
    abstract member prompt: string with get, set
    /// <summary>
    /// Name of the LoRA (Low-Rank Adaptation) model to fine-tune the base model.
    /// </summary>
    abstract member lora: string option with get, set
    abstract member response_format: Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_JSON_Mode option with get, set
    /// <summary>
    /// If true, a chat template is not applied and you must adhere to the specific model's expected formatting.
    /// </summary>
    abstract member raw: bool option with get, set
    /// <summary>
    /// If true, the response will be streamed back incrementally using SSE, Server Sent Events.
    /// </summary>
    abstract member stream: bool option with get, set
    /// <summary>
    /// The maximum number of tokens to generate in the response.
    /// </summary>
    abstract member max_tokens: float option with get, set
    /// <summary>
    /// Controls the randomness of the output; higher values produce more random results.
    /// </summary>
    abstract member temperature: float option with get, set
    /// <summary>
    /// Adjusts the creativity of the AI's responses by controlling how many possible words it considers. Lower values make outputs more predictable; higher values allow for more varied and creative responses.
    /// </summary>
    abstract member top_p: float option with get, set
    /// <summary>
    /// Limits the AI to choose from the top 'k' most probable words. Lower values make responses more focused; higher values introduce more variety and potential surprises.
    /// </summary>
    abstract member top_k: float option with get, set
    /// <summary>
    /// Random seed for reproducibility of the generation.
    /// </summary>
    abstract member seed: float option with get, set
    /// <summary>
    /// Penalty for repeated tokens; higher values discourage repetition.
    /// </summary>
    abstract member repetition_penalty: float option with get, set
    /// <summary>
    /// Decreases the likelihood of the model repeating the same lines verbatim.
    /// </summary>
    abstract member frequency_penalty: float option with get, set
    /// <summary>
    /// Increases the likelihood of the model introducing new topics.
    /// </summary>
    abstract member presence_penalty: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_JSON_Mode =
    abstract member ``type``: Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_JSON_Mode.``type`` option with get, set
    abstract member json_schema: obj option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Messages =
    /// <summary>
    /// An array of message objects representing the conversation history.
    /// </summary>
    abstract member messages: ResizeArray<Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Messages.messages> with get, set
    abstract member functions: ResizeArray<Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Messages.functions> option with get, set
    /// <summary>
    /// A list of tools available for the assistant to use.
    /// </summary>
    abstract member tools: ResizeArray<Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Messages.tools> option with get, set
    abstract member response_format: Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_JSON_Mode_1 option with get, set
    /// <summary>
    /// If true, a chat template is not applied and you must adhere to the specific model's expected formatting.
    /// </summary>
    abstract member raw: bool option with get, set
    /// <summary>
    /// If true, the response will be streamed back incrementally using SSE, Server Sent Events.
    /// </summary>
    abstract member stream: bool option with get, set
    /// <summary>
    /// The maximum number of tokens to generate in the response.
    /// </summary>
    abstract member max_tokens: float option with get, set
    /// <summary>
    /// Controls the randomness of the output; higher values produce more random results.
    /// </summary>
    abstract member temperature: float option with get, set
    /// <summary>
    /// Adjusts the creativity of the AI's responses by controlling how many possible words it considers. Lower values make outputs more predictable; higher values allow for more varied and creative responses.
    /// </summary>
    abstract member top_p: float option with get, set
    /// <summary>
    /// Limits the AI to choose from the top 'k' most probable words. Lower values make responses more focused; higher values introduce more variety and potential surprises.
    /// </summary>
    abstract member top_k: float option with get, set
    /// <summary>
    /// Random seed for reproducibility of the generation.
    /// </summary>
    abstract member seed: float option with get, set
    /// <summary>
    /// Penalty for repeated tokens; higher values discourage repetition.
    /// </summary>
    abstract member repetition_penalty: float option with get, set
    /// <summary>
    /// Decreases the likelihood of the model repeating the same lines verbatim.
    /// </summary>
    abstract member frequency_penalty: float option with get, set
    /// <summary>
    /// Increases the likelihood of the model introducing new topics.
    /// </summary>
    abstract member presence_penalty: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_JSON_Mode_1 =
    abstract member ``type``: Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_JSON_Mode_1.``type`` option with get, set
    abstract member json_schema: obj option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Async_Batch =
    abstract member requests: ResizeArray<U2<Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Prompt_1, Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Messages_1>> with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Prompt_1 =
    /// <summary>
    /// The input text prompt for the model to generate a response.
    /// </summary>
    abstract member prompt: string with get, set
    /// <summary>
    /// Name of the LoRA (Low-Rank Adaptation) model to fine-tune the base model.
    /// </summary>
    abstract member lora: string option with get, set
    abstract member response_format: Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_JSON_Mode_2 option with get, set
    /// <summary>
    /// If true, a chat template is not applied and you must adhere to the specific model's expected formatting.
    /// </summary>
    abstract member raw: bool option with get, set
    /// <summary>
    /// If true, the response will be streamed back incrementally using SSE, Server Sent Events.
    /// </summary>
    abstract member stream: bool option with get, set
    /// <summary>
    /// The maximum number of tokens to generate in the response.
    /// </summary>
    abstract member max_tokens: float option with get, set
    /// <summary>
    /// Controls the randomness of the output; higher values produce more random results.
    /// </summary>
    abstract member temperature: float option with get, set
    /// <summary>
    /// Adjusts the creativity of the AI's responses by controlling how many possible words it considers. Lower values make outputs more predictable; higher values allow for more varied and creative responses.
    /// </summary>
    abstract member top_p: float option with get, set
    /// <summary>
    /// Limits the AI to choose from the top 'k' most probable words. Lower values make responses more focused; higher values introduce more variety and potential surprises.
    /// </summary>
    abstract member top_k: float option with get, set
    /// <summary>
    /// Random seed for reproducibility of the generation.
    /// </summary>
    abstract member seed: float option with get, set
    /// <summary>
    /// Penalty for repeated tokens; higher values discourage repetition.
    /// </summary>
    abstract member repetition_penalty: float option with get, set
    /// <summary>
    /// Decreases the likelihood of the model repeating the same lines verbatim.
    /// </summary>
    abstract member frequency_penalty: float option with get, set
    /// <summary>
    /// Increases the likelihood of the model introducing new topics.
    /// </summary>
    abstract member presence_penalty: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_JSON_Mode_2 =
    abstract member ``type``: Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_JSON_Mode_2.``type`` option with get, set
    abstract member json_schema: obj option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Messages_1 =
    /// <summary>
    /// An array of message objects representing the conversation history.
    /// </summary>
    abstract member messages: ResizeArray<Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Messages_1.messages> with get, set
    abstract member functions: ResizeArray<Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Messages_1.functions> option with get, set
    /// <summary>
    /// A list of tools available for the assistant to use.
    /// </summary>
    abstract member tools: ResizeArray<Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Messages_1.tools> option with get, set
    abstract member response_format: Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_JSON_Mode_3 option with get, set
    /// <summary>
    /// If true, a chat template is not applied and you must adhere to the specific model's expected formatting.
    /// </summary>
    abstract member raw: bool option with get, set
    /// <summary>
    /// If true, the response will be streamed back incrementally using SSE, Server Sent Events.
    /// </summary>
    abstract member stream: bool option with get, set
    /// <summary>
    /// The maximum number of tokens to generate in the response.
    /// </summary>
    abstract member max_tokens: float option with get, set
    /// <summary>
    /// Controls the randomness of the output; higher values produce more random results.
    /// </summary>
    abstract member temperature: float option with get, set
    /// <summary>
    /// Adjusts the creativity of the AI's responses by controlling how many possible words it considers. Lower values make outputs more predictable; higher values allow for more varied and creative responses.
    /// </summary>
    abstract member top_p: float option with get, set
    /// <summary>
    /// Limits the AI to choose from the top 'k' most probable words. Lower values make responses more focused; higher values introduce more variety and potential surprises.
    /// </summary>
    abstract member top_k: float option with get, set
    /// <summary>
    /// Random seed for reproducibility of the generation.
    /// </summary>
    abstract member seed: float option with get, set
    /// <summary>
    /// Penalty for repeated tokens; higher values discourage repetition.
    /// </summary>
    abstract member repetition_penalty: float option with get, set
    /// <summary>
    /// Decreases the likelihood of the model repeating the same lines verbatim.
    /// </summary>
    abstract member frequency_penalty: float option with get, set
    /// <summary>
    /// Increases the likelihood of the model introducing new topics.
    /// </summary>
    abstract member presence_penalty: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_JSON_Mode_3 =
    abstract member ``type``: Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_JSON_Mode_3.``type`` option with get, set
    abstract member json_schema: obj option with get, set

type Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Output =
    U4<Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Chat_Completion_Response, Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Text_Completion_Response, string, Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_AsyncResponse>

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Chat_Completion_Response =
    /// <summary>
    /// Unique identifier for the completion
    /// </summary>
    abstract member id: string option with get, set
    /// <summary>
    /// Object type identifier
    /// </summary>
    abstract member ``object``: string option with get, set
    /// <summary>
    /// Unix timestamp of when the completion was created
    /// </summary>
    abstract member created: float option with get, set
    /// <summary>
    /// Model used for the completion
    /// </summary>
    abstract member model: string option with get, set
    /// <summary>
    /// List of completion choices
    /// </summary>
    abstract member choices: ResizeArray<Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Chat_Completion_Response.choices> option with get, set
    /// <summary>
    /// Usage statistics for the inference request
    /// </summary>
    abstract member usage: Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Chat_Completion_Response.usage option with get, set
    /// <summary>
    /// Log probabilities for the prompt (if requested)
    /// </summary>
    abstract member prompt_logprobs: U2<Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Chat_Completion_Response.prompt_logprobs.U2.Case1, obj> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Text_Completion_Response =
    /// <summary>
    /// Unique identifier for the completion
    /// </summary>
    abstract member id: string option with get, set
    /// <summary>
    /// Object type identifier
    /// </summary>
    abstract member ``object``: string option with get, set
    /// <summary>
    /// Unix timestamp of when the completion was created
    /// </summary>
    abstract member created: float option with get, set
    /// <summary>
    /// Model used for the completion
    /// </summary>
    abstract member model: string option with get, set
    /// <summary>
    /// List of completion choices
    /// </summary>
    abstract member choices: ResizeArray<Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Text_Completion_Response.choices> option with get, set
    /// <summary>
    /// Usage statistics for the inference request
    /// </summary>
    abstract member usage: Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Text_Completion_Response.usage option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_AsyncResponse =
    /// <summary>
    /// The async request id that can be used to obtain the results.
    /// </summary>
    abstract member request_id: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Base_Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8 =
    abstract member inputs: Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Input with get, set
    abstract member postProcessedOutputs: Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Output with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Deepgram_Nova_3_Input =
    abstract member audio: Ai_Cf_Deepgram_Nova_3_Input.audio with get, set
    /// <summary>
    /// Sets how the model will interpret strings submitted to the custom_topic param. When strict, the model will only return topics submitted using the custom_topic param. When extended, the model will return its own detected topics in addition to those submitted using the custom_topic param.
    /// </summary>
    abstract member custom_topic_mode: Ai_Cf_Deepgram_Nova_3_Input.custom_topic_mode option with get, set
    /// <summary>
    /// Custom topics you want the model to detect within your input audio or text if present Submit up to 100
    /// </summary>
    abstract member custom_topic: string option with get, set
    /// <summary>
    /// Sets how the model will interpret intents submitted to the custom_intent param. When strict, the model will only return intents submitted using the custom_intent param. When extended, the model will return its own detected intents in addition those submitted using the custom_intents param
    /// </summary>
    abstract member custom_intent_mode: Ai_Cf_Deepgram_Nova_3_Input.custom_intent_mode option with get, set
    /// <summary>
    /// Custom intents you want the model to detect within your input audio if present
    /// </summary>
    abstract member custom_intent: string option with get, set
    /// <summary>
    /// Identifies and extracts key entities from content in submitted audio
    /// </summary>
    abstract member detect_entities: bool option with get, set
    /// <summary>
    /// Identifies the dominant language spoken in submitted audio
    /// </summary>
    abstract member detect_language: bool option with get, set
    /// <summary>
    /// Recognize speaker changes. Each word in the transcript will be assigned a speaker number starting at 0
    /// </summary>
    abstract member diarize: bool option with get, set
    /// <summary>
    /// Identify and extract key entities from content in submitted audio
    /// </summary>
    abstract member dictation: bool option with get, set
    /// <summary>
    /// Specify the expected encoding of your submitted audio
    /// </summary>
    abstract member encoding: Ai_Cf_Deepgram_Nova_3_Input.encoding option with get, set
    /// <summary>
    /// Arbitrary key-value pairs that are attached to the API response for usage in downstream processing
    /// </summary>
    abstract member extra: string option with get, set
    /// <summary>
    /// Filler Words can help transcribe interruptions in your audio, like 'uh' and 'um'
    /// </summary>
    abstract member filler_words: bool option with get, set
    /// <summary>
    /// Key term prompting can boost or suppress specialized terminology and brands.
    /// </summary>
    abstract member keyterm: string option with get, set
    /// <summary>
    /// Keywords can boost or suppress specialized terminology and brands.
    /// </summary>
    abstract member keywords: string option with get, set
    /// <summary>
    /// The BCP-47 language tag that hints at the primary spoken language. Depending on the Model and API endpoint you choose only certain languages are available.
    /// </summary>
    abstract member language: string option with get, set
    /// <summary>
    /// Spoken measurements will be converted to their corresponding abbreviations.
    /// </summary>
    abstract member measurements: bool option with get, set
    /// <summary>
    /// Opts out requests from the Deepgram Model Improvement Program. Refer to our Docs for pricing impacts before setting this to true. https://dpgr.am/deepgram-mip.
    /// </summary>
    abstract member mip_opt_out: bool option with get, set
    /// <summary>
    /// Mode of operation for the model representing broad area of topic that will be talked about in the supplied audio
    /// </summary>
    abstract member mode: Ai_Cf_Deepgram_Nova_3_Input.mode option with get, set
    /// <summary>
    /// Transcribe each audio channel independently.
    /// </summary>
    abstract member multichannel: bool option with get, set
    /// <summary>
    /// Numerals converts numbers from written format to numerical format.
    /// </summary>
    abstract member numerals: bool option with get, set
    /// <summary>
    /// Splits audio into paragraphs to improve transcript readability.
    /// </summary>
    abstract member paragraphs: bool option with get, set
    /// <summary>
    /// Profanity Filter looks for recognized profanity and converts it to the nearest recognized non-profane word or removes it from the transcript completely.
    /// </summary>
    abstract member profanity_filter: bool option with get, set
    /// <summary>
    /// Add punctuation and capitalization to the transcript.
    /// </summary>
    abstract member punctuate: bool option with get, set
    /// <summary>
    /// Redaction removes sensitive information from your transcripts.
    /// </summary>
    abstract member redact: string option with get, set
    /// <summary>
    /// Search for terms or phrases in submitted audio and replaces them.
    /// </summary>
    abstract member replace: string option with get, set
    /// <summary>
    /// Search for terms or phrases in submitted audio.
    /// </summary>
    abstract member search: string option with get, set
    /// <summary>
    /// Recognizes the sentiment throughout a transcript or text.
    /// </summary>
    abstract member sentiment: bool option with get, set
    /// <summary>
    /// Apply formatting to transcript output. When set to true, additional formatting will be applied to transcripts to improve readability.
    /// </summary>
    abstract member smart_format: bool option with get, set
    /// <summary>
    /// Detect topics throughout a transcript or text.
    /// </summary>
    abstract member topics: bool option with get, set
    /// <summary>
    /// Segments speech into meaningful semantic units.
    /// </summary>
    abstract member utterances: bool option with get, set
    /// <summary>
    /// Seconds to wait before detecting a pause between words in submitted audio.
    /// </summary>
    abstract member utt_split: float option with get, set
    /// <summary>
    /// The number of channels in the submitted audio
    /// </summary>
    abstract member channels: float option with get, set
    /// <summary>
    /// Specifies whether the streaming endpoint should provide ongoing transcription updates as more audio is received. When set to true, the endpoint sends continuous updates, meaning transcription results may evolve over time. Note: Supported only for webosockets.
    /// </summary>
    abstract member interim_results: bool option with get, set
    /// <summary>
    /// Indicates how long model will wait to detect whether a speaker has finished speaking or pauses for a significant period of time. When set to a value, the streaming endpoint immediately finalizes the transcription for the processed time range and returns the transcript with a speech_final parameter set to true. Can also be set to false to disable endpointing
    /// </summary>
    abstract member endpointing: string option with get, set
    /// <summary>
    /// Indicates that speech has started. You'll begin receiving Speech Started messages upon speech starting. Note: Supported only for webosockets.
    /// </summary>
    abstract member vad_events: bool option with get, set
    /// <summary>
    /// Indicates how long model will wait to send an UtteranceEnd message after a word has been transcribed. Use with interim_results. Note: Supported only for webosockets.
    /// </summary>
    abstract member utterance_end_ms: bool option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Deepgram_Nova_3_Output =
    abstract member results: Ai_Cf_Deepgram_Nova_3_Output.results option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Base_Ai_Cf_Deepgram_Nova_3 =
    abstract member inputs: Ai_Cf_Deepgram_Nova_3_Input with get, set
    abstract member postProcessedOutputs: Ai_Cf_Deepgram_Nova_3_Output with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Qwen_Qwen3_Embedding_0_6B_Input =
    abstract member queries: U2<string, ResizeArray<string>> option with get, set
    /// <summary>
    /// Optional instruction for the task
    /// </summary>
    abstract member instruction: string option with get, set
    abstract member documents: U2<string, ResizeArray<string>> option with get, set
    abstract member text: U2<string, ResizeArray<string>> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Qwen_Qwen3_Embedding_0_6B_Output =
    abstract member data: ResizeArray<ResizeArray<float>> option with get, set
    abstract member shape: ResizeArray<float> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Base_Ai_Cf_Qwen_Qwen3_Embedding_0_6B =
    abstract member inputs: Ai_Cf_Qwen_Qwen3_Embedding_0_6B_Input with get, set
    abstract member postProcessedOutputs: Ai_Cf_Qwen_Qwen3_Embedding_0_6B_Output with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Pipecat_Ai_Smart_Turn_V2_Input =
    /// <summary>
    /// readable stream with audio data and content-type specified for that data
    /// </summary>
    abstract member audio: Ai_Cf_Pipecat_Ai_Smart_Turn_V2_Input.audio with get, set
    /// <summary>
    /// type of data PCM data that's sent to the inference server as raw array
    /// </summary>
    abstract member dtype: Ai_Cf_Pipecat_Ai_Smart_Turn_V2_Input.dtype option with get, set
    /// <summary>
    /// base64 encoded audio data
    /// </summary>
    abstract member audio: string with get, set
    /// <summary>
    /// type of data PCM data that's sent to the inference server as raw array
    /// </summary>
    abstract member dtype: Ai_Cf_Pipecat_Ai_Smart_Turn_V2_Input.dtype option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Pipecat_Ai_Smart_Turn_V2_Output =
    /// <summary>
    /// if true, end-of-turn was detected
    /// </summary>
    abstract member is_complete: bool option with get, set
    /// <summary>
    /// probability of the end-of-turn detection
    /// </summary>
    abstract member probability: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Base_Ai_Cf_Pipecat_Ai_Smart_Turn_V2 =
    abstract member inputs: Ai_Cf_Pipecat_Ai_Smart_Turn_V2_Input with get, set
    abstract member postProcessedOutputs: Ai_Cf_Pipecat_Ai_Smart_Turn_V2_Output with get, set

[<AllowNullLiteral>]
[<Interface>]
type Base_Ai_Cf_Openai_Gpt_Oss_120B =
    abstract member inputs: ResponsesInput with get, set
    abstract member postProcessedOutputs: ResponsesOutput with get, set

[<AllowNullLiteral>]
[<Interface>]
type Base_Ai_Cf_Openai_Gpt_Oss_20B =
    abstract member inputs: ResponsesInput with get, set
    abstract member postProcessedOutputs: ResponsesOutput with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Leonardo_Phoenix_1_0_Input =
    /// <summary>
    /// A text description of the image you want to generate.
    /// </summary>
    abstract member prompt: string with get, set
    /// <summary>
    /// Controls how closely the generated image should adhere to the prompt; higher values make the image more aligned with the prompt
    /// </summary>
    abstract member guidance: float option with get, set
    /// <summary>
    /// Random seed for reproducibility of the image generation
    /// </summary>
    abstract member seed: float option with get, set
    /// <summary>
    /// The height of the generated image in pixels
    /// </summary>
    abstract member height: float option with get, set
    /// <summary>
    /// The width of the generated image in pixels
    /// </summary>
    abstract member width: float option with get, set
    /// <summary>
    /// The number of diffusion steps; higher values can improve quality but take longer
    /// </summary>
    abstract member num_steps: float option with get, set
    /// <summary>
    /// Specify what to exclude from the generated images
    /// </summary>
    abstract member negative_prompt: string option with get, set

/// <summary>
/// The generated image in JPEG format
/// </summary>
type Ai_Cf_Leonardo_Phoenix_1_0_Output =
    string

[<AllowNullLiteral>]
[<Interface>]
type Base_Ai_Cf_Leonardo_Phoenix_1_0 =
    abstract member inputs: Ai_Cf_Leonardo_Phoenix_1_0_Input with get, set
    abstract member postProcessedOutputs: Ai_Cf_Leonardo_Phoenix_1_0_Output with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Leonardo_Lucid_Origin_Input =
    /// <summary>
    /// A text description of the image you want to generate.
    /// </summary>
    abstract member prompt: string with get, set
    /// <summary>
    /// Controls how closely the generated image should adhere to the prompt; higher values make the image more aligned with the prompt
    /// </summary>
    abstract member guidance: float option with get, set
    /// <summary>
    /// Random seed for reproducibility of the image generation
    /// </summary>
    abstract member seed: float option with get, set
    /// <summary>
    /// The height of the generated image in pixels
    /// </summary>
    abstract member height: float option with get, set
    /// <summary>
    /// The width of the generated image in pixels
    /// </summary>
    abstract member width: float option with get, set
    /// <summary>
    /// The number of diffusion steps; higher values can improve quality but take longer
    /// </summary>
    abstract member num_steps: float option with get, set
    /// <summary>
    /// The number of diffusion steps; higher values can improve quality but take longer
    /// </summary>
    abstract member steps: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Leonardo_Lucid_Origin_Output =
    /// <summary>
    /// The generated image in Base64 format.
    /// </summary>
    abstract member image: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Base_Ai_Cf_Leonardo_Lucid_Origin =
    abstract member inputs: Ai_Cf_Leonardo_Lucid_Origin_Input with get, set
    abstract member postProcessedOutputs: Ai_Cf_Leonardo_Lucid_Origin_Output with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Deepgram_Aura_1_Input =
    /// <summary>
    /// Speaker used to produce the audio.
    /// </summary>
    abstract member speaker: Ai_Cf_Deepgram_Aura_1_Input.speaker option with get, set
    /// <summary>
    /// Encoding of the output audio.
    /// </summary>
    abstract member encoding: Ai_Cf_Deepgram_Aura_1_Input.encoding option with get, set
    /// <summary>
    /// Container specifies the file format wrapper for the output audio. The available options depend on the encoding type..
    /// </summary>
    abstract member container: Ai_Cf_Deepgram_Aura_1_Input.container option with get, set
    /// <summary>
    /// The text content to be converted to speech
    /// </summary>
    abstract member text: string with get, set
    /// <summary>
    /// Sample Rate specifies the sample rate for the output audio. Based on the encoding, different sample rates are supported. For some encodings, the sample rate is not configurable
    /// </summary>
    abstract member sample_rate: float option with get, set
    /// <summary>
    /// The bitrate of the audio in bits per second. Choose from predefined ranges or specific values based on the encoding type.
    /// </summary>
    abstract member bit_rate: float option with get, set

/// <summary>
/// The generated audio in MP3 format
/// </summary>
type Ai_Cf_Deepgram_Aura_1_Output =
    string

[<AllowNullLiteral>]
[<Interface>]
type Base_Ai_Cf_Deepgram_Aura_1 =
    abstract member inputs: Ai_Cf_Deepgram_Aura_1_Input with get, set
    abstract member postProcessedOutputs: Ai_Cf_Deepgram_Aura_1_Output with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Ai4Bharat_Indictrans2_En_Indic_1B_Input =
    /// <summary>
    /// Input text to translate. Can be a single string or a list of strings.
    /// </summary>
    abstract member text: U2<string, ResizeArray<string>> with get, set
    /// <summary>
    /// Target language to translate to
    /// </summary>
    abstract member target_language: Ai_Cf_Ai4Bharat_Indictrans2_En_Indic_1B_Input.target_language with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Ai4Bharat_Indictrans2_En_Indic_1B_Output =
    /// <summary>
    /// Translated texts
    /// </summary>
    abstract member translations: ResizeArray<string> with get, set

[<AllowNullLiteral>]
[<Interface>]
type Base_Ai_Cf_Ai4Bharat_Indictrans2_En_Indic_1B =
    abstract member inputs: Ai_Cf_Ai4Bharat_Indictrans2_En_Indic_1B_Input with get, set
    abstract member postProcessedOutputs: Ai_Cf_Ai4Bharat_Indictrans2_En_Indic_1B_Output with get, set

type Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Input =
    U3<Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Prompt, Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Messages, Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Async_Batch>

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Prompt =
    /// <summary>
    /// The input text prompt for the model to generate a response.
    /// </summary>
    abstract member prompt: string with get, set
    /// <summary>
    /// Name of the LoRA (Low-Rank Adaptation) model to fine-tune the base model.
    /// </summary>
    abstract member lora: string option with get, set
    abstract member response_format: Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_JSON_Mode option with get, set
    /// <summary>
    /// If true, a chat template is not applied and you must adhere to the specific model's expected formatting.
    /// </summary>
    abstract member raw: bool option with get, set
    /// <summary>
    /// If true, the response will be streamed back incrementally using SSE, Server Sent Events.
    /// </summary>
    abstract member stream: bool option with get, set
    /// <summary>
    /// The maximum number of tokens to generate in the response.
    /// </summary>
    abstract member max_tokens: float option with get, set
    /// <summary>
    /// Controls the randomness of the output; higher values produce more random results.
    /// </summary>
    abstract member temperature: float option with get, set
    /// <summary>
    /// Adjusts the creativity of the AI's responses by controlling how many possible words it considers. Lower values make outputs more predictable; higher values allow for more varied and creative responses.
    /// </summary>
    abstract member top_p: float option with get, set
    /// <summary>
    /// Limits the AI to choose from the top 'k' most probable words. Lower values make responses more focused; higher values introduce more variety and potential surprises.
    /// </summary>
    abstract member top_k: float option with get, set
    /// <summary>
    /// Random seed for reproducibility of the generation.
    /// </summary>
    abstract member seed: float option with get, set
    /// <summary>
    /// Penalty for repeated tokens; higher values discourage repetition.
    /// </summary>
    abstract member repetition_penalty: float option with get, set
    /// <summary>
    /// Decreases the likelihood of the model repeating the same lines verbatim.
    /// </summary>
    abstract member frequency_penalty: float option with get, set
    /// <summary>
    /// Increases the likelihood of the model introducing new topics.
    /// </summary>
    abstract member presence_penalty: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_JSON_Mode =
    abstract member ``type``: Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_JSON_Mode.``type`` option with get, set
    abstract member json_schema: obj option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Messages =
    /// <summary>
    /// An array of message objects representing the conversation history.
    /// </summary>
    abstract member messages: ResizeArray<Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Messages.messages> with get, set
    abstract member functions: ResizeArray<Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Messages.functions> option with get, set
    /// <summary>
    /// A list of tools available for the assistant to use.
    /// </summary>
    abstract member tools: ResizeArray<Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Messages.tools> option with get, set
    abstract member response_format: Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_JSON_Mode_1 option with get, set
    /// <summary>
    /// If true, a chat template is not applied and you must adhere to the specific model's expected formatting.
    /// </summary>
    abstract member raw: bool option with get, set
    /// <summary>
    /// If true, the response will be streamed back incrementally using SSE, Server Sent Events.
    /// </summary>
    abstract member stream: bool option with get, set
    /// <summary>
    /// The maximum number of tokens to generate in the response.
    /// </summary>
    abstract member max_tokens: float option with get, set
    /// <summary>
    /// Controls the randomness of the output; higher values produce more random results.
    /// </summary>
    abstract member temperature: float option with get, set
    /// <summary>
    /// Adjusts the creativity of the AI's responses by controlling how many possible words it considers. Lower values make outputs more predictable; higher values allow for more varied and creative responses.
    /// </summary>
    abstract member top_p: float option with get, set
    /// <summary>
    /// Limits the AI to choose from the top 'k' most probable words. Lower values make responses more focused; higher values introduce more variety and potential surprises.
    /// </summary>
    abstract member top_k: float option with get, set
    /// <summary>
    /// Random seed for reproducibility of the generation.
    /// </summary>
    abstract member seed: float option with get, set
    /// <summary>
    /// Penalty for repeated tokens; higher values discourage repetition.
    /// </summary>
    abstract member repetition_penalty: float option with get, set
    /// <summary>
    /// Decreases the likelihood of the model repeating the same lines verbatim.
    /// </summary>
    abstract member frequency_penalty: float option with get, set
    /// <summary>
    /// Increases the likelihood of the model introducing new topics.
    /// </summary>
    abstract member presence_penalty: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_JSON_Mode_1 =
    abstract member ``type``: Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_JSON_Mode_1.``type`` option with get, set
    abstract member json_schema: obj option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Async_Batch =
    abstract member requests: ResizeArray<U2<Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Prompt_1, Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Messages_1>> with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Prompt_1 =
    /// <summary>
    /// The input text prompt for the model to generate a response.
    /// </summary>
    abstract member prompt: string with get, set
    /// <summary>
    /// Name of the LoRA (Low-Rank Adaptation) model to fine-tune the base model.
    /// </summary>
    abstract member lora: string option with get, set
    abstract member response_format: Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_JSON_Mode_2 option with get, set
    /// <summary>
    /// If true, a chat template is not applied and you must adhere to the specific model's expected formatting.
    /// </summary>
    abstract member raw: bool option with get, set
    /// <summary>
    /// If true, the response will be streamed back incrementally using SSE, Server Sent Events.
    /// </summary>
    abstract member stream: bool option with get, set
    /// <summary>
    /// The maximum number of tokens to generate in the response.
    /// </summary>
    abstract member max_tokens: float option with get, set
    /// <summary>
    /// Controls the randomness of the output; higher values produce more random results.
    /// </summary>
    abstract member temperature: float option with get, set
    /// <summary>
    /// Adjusts the creativity of the AI's responses by controlling how many possible words it considers. Lower values make outputs more predictable; higher values allow for more varied and creative responses.
    /// </summary>
    abstract member top_p: float option with get, set
    /// <summary>
    /// Limits the AI to choose from the top 'k' most probable words. Lower values make responses more focused; higher values introduce more variety and potential surprises.
    /// </summary>
    abstract member top_k: float option with get, set
    /// <summary>
    /// Random seed for reproducibility of the generation.
    /// </summary>
    abstract member seed: float option with get, set
    /// <summary>
    /// Penalty for repeated tokens; higher values discourage repetition.
    /// </summary>
    abstract member repetition_penalty: float option with get, set
    /// <summary>
    /// Decreases the likelihood of the model repeating the same lines verbatim.
    /// </summary>
    abstract member frequency_penalty: float option with get, set
    /// <summary>
    /// Increases the likelihood of the model introducing new topics.
    /// </summary>
    abstract member presence_penalty: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_JSON_Mode_2 =
    abstract member ``type``: Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_JSON_Mode_2.``type`` option with get, set
    abstract member json_schema: obj option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Messages_1 =
    /// <summary>
    /// An array of message objects representing the conversation history.
    /// </summary>
    abstract member messages: ResizeArray<Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Messages_1.messages> with get, set
    abstract member functions: ResizeArray<Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Messages_1.functions> option with get, set
    /// <summary>
    /// A list of tools available for the assistant to use.
    /// </summary>
    abstract member tools: ResizeArray<Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Messages_1.tools> option with get, set
    abstract member response_format: Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_JSON_Mode_3 option with get, set
    /// <summary>
    /// If true, a chat template is not applied and you must adhere to the specific model's expected formatting.
    /// </summary>
    abstract member raw: bool option with get, set
    /// <summary>
    /// If true, the response will be streamed back incrementally using SSE, Server Sent Events.
    /// </summary>
    abstract member stream: bool option with get, set
    /// <summary>
    /// The maximum number of tokens to generate in the response.
    /// </summary>
    abstract member max_tokens: float option with get, set
    /// <summary>
    /// Controls the randomness of the output; higher values produce more random results.
    /// </summary>
    abstract member temperature: float option with get, set
    /// <summary>
    /// Adjusts the creativity of the AI's responses by controlling how many possible words it considers. Lower values make outputs more predictable; higher values allow for more varied and creative responses.
    /// </summary>
    abstract member top_p: float option with get, set
    /// <summary>
    /// Limits the AI to choose from the top 'k' most probable words. Lower values make responses more focused; higher values introduce more variety and potential surprises.
    /// </summary>
    abstract member top_k: float option with get, set
    /// <summary>
    /// Random seed for reproducibility of the generation.
    /// </summary>
    abstract member seed: float option with get, set
    /// <summary>
    /// Penalty for repeated tokens; higher values discourage repetition.
    /// </summary>
    abstract member repetition_penalty: float option with get, set
    /// <summary>
    /// Decreases the likelihood of the model repeating the same lines verbatim.
    /// </summary>
    abstract member frequency_penalty: float option with get, set
    /// <summary>
    /// Increases the likelihood of the model introducing new topics.
    /// </summary>
    abstract member presence_penalty: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_JSON_Mode_3 =
    abstract member ``type``: Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_JSON_Mode_3.``type`` option with get, set
    abstract member json_schema: obj option with get, set

type Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Output =
    U4<Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Chat_Completion_Response, Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Text_Completion_Response, string, Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_AsyncResponse>

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Chat_Completion_Response =
    /// <summary>
    /// Unique identifier for the completion
    /// </summary>
    abstract member id: string option with get, set
    /// <summary>
    /// Object type identifier
    /// </summary>
    abstract member ``object``: string option with get, set
    /// <summary>
    /// Unix timestamp of when the completion was created
    /// </summary>
    abstract member created: float option with get, set
    /// <summary>
    /// Model used for the completion
    /// </summary>
    abstract member model: string option with get, set
    /// <summary>
    /// List of completion choices
    /// </summary>
    abstract member choices: ResizeArray<Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Chat_Completion_Response.choices> option with get, set
    /// <summary>
    /// Usage statistics for the inference request
    /// </summary>
    abstract member usage: Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Chat_Completion_Response.usage option with get, set
    /// <summary>
    /// Log probabilities for the prompt (if requested)
    /// </summary>
    abstract member prompt_logprobs: U2<Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Chat_Completion_Response.prompt_logprobs.U2.Case1, obj> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Text_Completion_Response =
    /// <summary>
    /// Unique identifier for the completion
    /// </summary>
    abstract member id: string option with get, set
    /// <summary>
    /// Object type identifier
    /// </summary>
    abstract member ``object``: string option with get, set
    /// <summary>
    /// Unix timestamp of when the completion was created
    /// </summary>
    abstract member created: float option with get, set
    /// <summary>
    /// Model used for the completion
    /// </summary>
    abstract member model: string option with get, set
    /// <summary>
    /// List of completion choices
    /// </summary>
    abstract member choices: ResizeArray<Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Text_Completion_Response.choices> option with get, set
    /// <summary>
    /// Usage statistics for the inference request
    /// </summary>
    abstract member usage: Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Text_Completion_Response.usage option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_AsyncResponse =
    /// <summary>
    /// The async request id that can be used to obtain the results.
    /// </summary>
    abstract member request_id: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Base_Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It =
    abstract member inputs: Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Input with get, set
    abstract member postProcessedOutputs: Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Output with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Pfnet_Plamo_Embedding_1B_Input =
    /// <summary>
    /// Input text to embed. Can be a single string or a list of strings.
    /// </summary>
    abstract member text: U2<string, ResizeArray<string>> with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Pfnet_Plamo_Embedding_1B_Output =
    /// <summary>
    /// Embedding vectors, where each vector is a list of floats.
    /// </summary>
    abstract member data: ResizeArray<ResizeArray<float>> with get, set
    /// <summary>
    /// Shape of the embedding data as [number_of_embeddings, embedding_dimension].
    /// </summary>
    abstract member shape: float * float with get, set

[<AllowNullLiteral>]
[<Interface>]
type Base_Ai_Cf_Pfnet_Plamo_Embedding_1B =
    abstract member inputs: Ai_Cf_Pfnet_Plamo_Embedding_1B_Input with get, set
    abstract member postProcessedOutputs: Ai_Cf_Pfnet_Plamo_Embedding_1B_Output with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Deepgram_Flux_Input =
    /// <summary>
    /// Encoding of the audio stream. Currently only supports raw signed little-endian 16-bit PCM.
    /// </summary>
    abstract member encoding: string with get, set
    /// <summary>
    /// Sample rate of the audio stream in Hz.
    /// </summary>
    abstract member sample_rate: string with get, set
    /// <summary>
    /// End-of-turn confidence required to fire an eager end-of-turn event. When set, enables EagerEndOfTurn and TurnResumed events. Valid Values 0.3 - 0.9.
    /// </summary>
    abstract member eager_eot_threshold: string option with get, set
    /// <summary>
    /// End-of-turn confidence required to finish a turn. Valid Values 0.5 - 0.9.
    /// </summary>
    abstract member eot_threshold: string option with get, set
    /// <summary>
    /// A turn will be finished when this much time has passed after speech, regardless of EOT confidence.
    /// </summary>
    abstract member eot_timeout_ms: string option with get, set
    /// <summary>
    /// Keyterm prompting can improve recognition of specialized terminology. Pass multiple keyterm query parameters to boost multiple keyterms.
    /// </summary>
    abstract member keyterm: string option with get, set
    /// <summary>
    /// Opts out requests from the Deepgram Model Improvement Program. Refer to Deepgram Docs for pricing impacts before setting this to true. https://dpgr.am/deepgram-mip
    /// </summary>
    abstract member mip_opt_out: Ai_Cf_Deepgram_Flux_Input.mip_opt_out option with get, set
    /// <summary>
    /// Label your requests for the purpose of identification during usage reporting
    /// </summary>
    abstract member tag: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Deepgram_Flux_Output =
    /// <summary>
    /// The unique identifier of the request (uuid)
    /// </summary>
    abstract member request_id: string option with get, set
    /// <summary>
    /// Starts at 0 and increments for each message the server sends to the client.
    /// </summary>
    abstract member sequence_id: float option with get, set
    /// <summary>
    /// The type of event being reported.
    /// </summary>
    abstract member event: Ai_Cf_Deepgram_Flux_Output.event option with get, set
    /// <summary>
    /// The index of the current turn
    /// </summary>
    abstract member turn_index: float option with get, set
    /// <summary>
    /// Start time in seconds of the audio range that was transcribed
    /// </summary>
    abstract member audio_window_start: float option with get, set
    /// <summary>
    /// End time in seconds of the audio range that was transcribed
    /// </summary>
    abstract member audio_window_end: float option with get, set
    /// <summary>
    /// Text that was said over the course of the current turn
    /// </summary>
    abstract member transcript: string option with get, set
    /// <summary>
    /// The words in the transcript
    /// </summary>
    abstract member words: ResizeArray<Ai_Cf_Deepgram_Flux_Output.words> option with get, set
    /// <summary>
    /// Confidence that no more speech is coming in this turn
    /// </summary>
    abstract member end_of_turn_confidence: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Base_Ai_Cf_Deepgram_Flux =
    abstract member inputs: Ai_Cf_Deepgram_Flux_Input with get, set
    abstract member postProcessedOutputs: Ai_Cf_Deepgram_Flux_Output with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Deepgram_Aura_2_En_Input =
    /// <summary>
    /// Speaker used to produce the audio.
    /// </summary>
    abstract member speaker: Ai_Cf_Deepgram_Aura_2_En_Input.speaker option with get, set
    /// <summary>
    /// Encoding of the output audio.
    /// </summary>
    abstract member encoding: Ai_Cf_Deepgram_Aura_2_En_Input.encoding option with get, set
    /// <summary>
    /// Container specifies the file format wrapper for the output audio. The available options depend on the encoding type..
    /// </summary>
    abstract member container: Ai_Cf_Deepgram_Aura_2_En_Input.container option with get, set
    /// <summary>
    /// The text content to be converted to speech
    /// </summary>
    abstract member text: string with get, set
    /// <summary>
    /// Sample Rate specifies the sample rate for the output audio. Based on the encoding, different sample rates are supported. For some encodings, the sample rate is not configurable
    /// </summary>
    abstract member sample_rate: float option with get, set
    /// <summary>
    /// The bitrate of the audio in bits per second. Choose from predefined ranges or specific values based on the encoding type.
    /// </summary>
    abstract member bit_rate: float option with get, set

/// <summary>
/// The generated audio in MP3 format
/// </summary>
type Ai_Cf_Deepgram_Aura_2_En_Output =
    string

[<AllowNullLiteral>]
[<Interface>]
type Base_Ai_Cf_Deepgram_Aura_2_En =
    abstract member inputs: Ai_Cf_Deepgram_Aura_2_En_Input with get, set
    abstract member postProcessedOutputs: Ai_Cf_Deepgram_Aura_2_En_Output with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai_Cf_Deepgram_Aura_2_Es_Input =
    /// <summary>
    /// Speaker used to produce the audio.
    /// </summary>
    abstract member speaker: Ai_Cf_Deepgram_Aura_2_Es_Input.speaker option with get, set
    /// <summary>
    /// Encoding of the output audio.
    /// </summary>
    abstract member encoding: Ai_Cf_Deepgram_Aura_2_Es_Input.encoding option with get, set
    /// <summary>
    /// Container specifies the file format wrapper for the output audio. The available options depend on the encoding type..
    /// </summary>
    abstract member container: Ai_Cf_Deepgram_Aura_2_Es_Input.container option with get, set
    /// <summary>
    /// The text content to be converted to speech
    /// </summary>
    abstract member text: string with get, set
    /// <summary>
    /// Sample Rate specifies the sample rate for the output audio. Based on the encoding, different sample rates are supported. For some encodings, the sample rate is not configurable
    /// </summary>
    abstract member sample_rate: float option with get, set
    /// <summary>
    /// The bitrate of the audio in bits per second. Choose from predefined ranges or specific values based on the encoding type.
    /// </summary>
    abstract member bit_rate: float option with get, set

/// <summary>
/// The generated audio in MP3 format
/// </summary>
type Ai_Cf_Deepgram_Aura_2_Es_Output =
    string

[<AllowNullLiteral>]
[<Interface>]
type Base_Ai_Cf_Deepgram_Aura_2_Es =
    abstract member inputs: Ai_Cf_Deepgram_Aura_2_Es_Input with get, set
    abstract member postProcessedOutputs: Ai_Cf_Deepgram_Aura_2_Es_Output with get, set

[<AllowNullLiteral>]
[<Interface>]
type AiModels =
    abstract member ``_AT_cf/huggingface/distilbert-sst-2-int8``: BaseAiTextClassification with get, set
    abstract member ``_AT_cf/stabilityai/stable-diffusion-xl-base-1_0``: BaseAiTextToImage with get, set
    abstract member ``_AT_cf/runwayml/stable-diffusion-v1-5-inpainting``: BaseAiTextToImage with get, set
    abstract member ``_AT_cf/runwayml/stable-diffusion-v1-5-img2img``: BaseAiTextToImage with get, set
    abstract member ``_AT_cf/lykon/dreamshaper-8-lcm``: BaseAiTextToImage with get, set
    abstract member ``_AT_cf/bytedance/stable-diffusion-xl-lightning``: BaseAiTextToImage with get, set
    abstract member ``_AT_cf/myshell-ai/melotts``: BaseAiTextToSpeech with get, set
    abstract member ``_AT_cf/google/embeddinggemma-300m``: BaseAiTextEmbeddings with get, set
    abstract member ``_AT_cf/microsoft/resnet-50``: BaseAiImageClassification with get, set
    abstract member ``_AT_cf/meta/llama-2-7b-chat-int8``: BaseAiTextGeneration with get, set
    abstract member ``_AT_cf/mistral/mistral-7b-instruct-v0_1``: BaseAiTextGeneration with get, set
    abstract member ``_AT_cf/meta/llama-2-7b-chat-fp16``: BaseAiTextGeneration with get, set
    abstract member ``_AT_hf/thebloke/llama-2-13b-chat-awq``: BaseAiTextGeneration with get, set
    abstract member ``_AT_hf/thebloke/mistral-7b-instruct-v0_1-awq``: BaseAiTextGeneration with get, set
    abstract member ``_AT_hf/thebloke/zephyr-7b-beta-awq``: BaseAiTextGeneration with get, set
    abstract member ``_AT_hf/thebloke/openhermes-2_5-mistral-7b-awq``: BaseAiTextGeneration with get, set
    abstract member ``_AT_hf/thebloke/neural-chat-7b-v3-1-awq``: BaseAiTextGeneration with get, set
    abstract member ``_AT_hf/thebloke/llamaguard-7b-awq``: BaseAiTextGeneration with get, set
    abstract member ``_AT_hf/thebloke/deepseek-coder-6_7b-base-awq``: BaseAiTextGeneration with get, set
    abstract member ``_AT_hf/thebloke/deepseek-coder-6_7b-instruct-awq``: BaseAiTextGeneration with get, set
    abstract member ``_AT_cf/deepseek-ai/deepseek-math-7b-instruct``: BaseAiTextGeneration with get, set
    abstract member ``_AT_cf/defog/sqlcoder-7b-2``: BaseAiTextGeneration with get, set
    abstract member ``_AT_cf/openchat/openchat-3_5-0106``: BaseAiTextGeneration with get, set
    abstract member ``_AT_cf/tiiuae/falcon-7b-instruct``: BaseAiTextGeneration with get, set
    abstract member ``_AT_cf/thebloke/discolm-german-7b-v1-awq``: BaseAiTextGeneration with get, set
    abstract member ``_AT_cf/qwen/qwen1_5-0_5b-chat``: BaseAiTextGeneration with get, set
    abstract member ``_AT_cf/qwen/qwen1_5-7b-chat-awq``: BaseAiTextGeneration with get, set
    abstract member ``_AT_cf/qwen/qwen1_5-14b-chat-awq``: BaseAiTextGeneration with get, set
    abstract member ``_AT_cf/tinyllama/tinyllama-1_1b-chat-v1_0``: BaseAiTextGeneration with get, set
    abstract member ``_AT_cf/microsoft/phi-2``: BaseAiTextGeneration with get, set
    abstract member ``_AT_cf/qwen/qwen1_5-1_8b-chat``: BaseAiTextGeneration with get, set
    abstract member ``_AT_cf/mistral/mistral-7b-instruct-v0_2-lora``: BaseAiTextGeneration with get, set
    abstract member ``_AT_hf/nousresearch/hermes-2-pro-mistral-7b``: BaseAiTextGeneration with get, set
    abstract member ``_AT_hf/nexusflow/starling-lm-7b-beta``: BaseAiTextGeneration with get, set
    abstract member ``_AT_hf/google/gemma-7b-it``: BaseAiTextGeneration with get, set
    abstract member ``_AT_cf/meta-llama/llama-2-7b-chat-hf-lora``: BaseAiTextGeneration with get, set
    abstract member ``_AT_cf/google/gemma-2b-it-lora``: BaseAiTextGeneration with get, set
    abstract member ``_AT_cf/google/gemma-7b-it-lora``: BaseAiTextGeneration with get, set
    abstract member ``_AT_hf/mistral/mistral-7b-instruct-v0_2``: BaseAiTextGeneration with get, set
    abstract member ``_AT_cf/meta/llama-3-8b-instruct``: BaseAiTextGeneration with get, set
    abstract member ``_AT_cf/fblgit/una-cybertron-7b-v2-bf16``: BaseAiTextGeneration with get, set
    abstract member ``_AT_cf/meta/llama-3-8b-instruct-awq``: BaseAiTextGeneration with get, set
    abstract member ``_AT_cf/meta/llama-3_1-8b-instruct-fp8``: BaseAiTextGeneration with get, set
    abstract member ``_AT_cf/meta/llama-3_1-8b-instruct-awq``: BaseAiTextGeneration with get, set
    abstract member ``_AT_cf/meta/llama-3_2-3b-instruct``: BaseAiTextGeneration with get, set
    abstract member ``_AT_cf/meta/llama-3_2-1b-instruct``: BaseAiTextGeneration with get, set
    abstract member ``_AT_cf/deepseek-ai/deepseek-r1-distill-qwen-32b``: BaseAiTextGeneration with get, set
    abstract member ``_AT_cf/ibm-granite/granite-4_0-h-micro``: BaseAiTextGeneration with get, set
    abstract member ``_AT_cf/facebook/bart-large-cnn``: BaseAiSummarization with get, set
    abstract member ``_AT_cf/llava-hf/llava-1_5-7b-hf``: BaseAiImageToText with get, set
    abstract member ``_AT_cf/baai/bge-base-en-v1_5``: Base_Ai_Cf_Baai_Bge_Base_En_V1_5 with get, set
    abstract member _AT_cf/openai/whisper: Base_Ai_Cf_Openai_Whisper with get, set
    abstract member ``_AT_cf/meta/m2m100-1_2b``: Base_Ai_Cf_Meta_M2M100_1_2B with get, set
    abstract member ``_AT_cf/baai/bge-small-en-v1_5``: Base_Ai_Cf_Baai_Bge_Small_En_V1_5 with get, set
    abstract member ``_AT_cf/baai/bge-large-en-v1_5``: Base_Ai_Cf_Baai_Bge_Large_En_V1_5 with get, set
    abstract member ``_AT_cf/unum/uform-gen2-qwen-500m``: Base_Ai_Cf_Unum_Uform_Gen2_Qwen_500M with get, set
    abstract member ``_AT_cf/openai/whisper-tiny-en``: Base_Ai_Cf_Openai_Whisper_Tiny_En with get, set
    abstract member ``_AT_cf/openai/whisper-large-v3-turbo``: Base_Ai_Cf_Openai_Whisper_Large_V3_Turbo with get, set
    abstract member ``_AT_cf/baai/bge-m3``: Base_Ai_Cf_Baai_Bge_M3 with get, set
    abstract member ``_AT_cf/black-forest-labs/flux-1-schnell``: Base_Ai_Cf_Black_Forest_Labs_Flux_1_Schnell with get, set
    abstract member ``_AT_cf/meta/llama-3_2-11b-vision-instruct``: Base_Ai_Cf_Meta_Llama_3_2_11B_Vision_Instruct with get, set
    abstract member ``_AT_cf/meta/llama-3_3-70b-instruct-fp8-fast``: Base_Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast with get, set
    abstract member ``_AT_cf/meta/llama-guard-3-8b``: Base_Ai_Cf_Meta_Llama_Guard_3_8B with get, set
    abstract member ``_AT_cf/baai/bge-reranker-base``: Base_Ai_Cf_Baai_Bge_Reranker_Base with get, set
    abstract member ``_AT_cf/qwen/qwen2_5-coder-32b-instruct``: Base_Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct with get, set
    abstract member ``_AT_cf/qwen/qwq-32b``: Base_Ai_Cf_Qwen_Qwq_32B with get, set
    abstract member ``_AT_cf/mistralai/mistral-small-3_1-24b-instruct``: Base_Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct with get, set
    abstract member ``_AT_cf/google/gemma-3-12b-it``: Base_Ai_Cf_Google_Gemma_3_12B_It with get, set
    abstract member ``_AT_cf/meta/llama-4-scout-17b-16e-instruct``: Base_Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct with get, set
    abstract member ``_AT_cf/qwen/qwen3-30b-a3b-fp8``: Base_Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8 with get, set
    abstract member ``_AT_cf/deepgram/nova-3``: Base_Ai_Cf_Deepgram_Nova_3 with get, set
    abstract member ``_AT_cf/qwen/qwen3-embedding-0_6b``: Base_Ai_Cf_Qwen_Qwen3_Embedding_0_6B with get, set
    abstract member ``_AT_cf/pipecat-ai/smart-turn-v2``: Base_Ai_Cf_Pipecat_Ai_Smart_Turn_V2 with get, set
    abstract member ``_AT_cf/openai/gpt-oss-120b``: Base_Ai_Cf_Openai_Gpt_Oss_120B with get, set
    abstract member ``_AT_cf/openai/gpt-oss-20b``: Base_Ai_Cf_Openai_Gpt_Oss_20B with get, set
    abstract member ``_AT_cf/leonardo/phoenix-1_0``: Base_Ai_Cf_Leonardo_Phoenix_1_0 with get, set
    abstract member ``_AT_cf/leonardo/lucid-origin``: Base_Ai_Cf_Leonardo_Lucid_Origin with get, set
    abstract member ``_AT_cf/deepgram/aura-1``: Base_Ai_Cf_Deepgram_Aura_1 with get, set
    abstract member ``_AT_cf/ai4bharat/indictrans2-en-indic-1B``: Base_Ai_Cf_Ai4Bharat_Indictrans2_En_Indic_1B with get, set
    abstract member ``_AT_cf/aisingapore/gemma-sea-lion-v4-27b-it``: Base_Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It with get, set
    abstract member ``_AT_cf/pfnet/plamo-embedding-1b``: Base_Ai_Cf_Pfnet_Plamo_Embedding_1B with get, set
    abstract member _AT_cf/deepgram/flux: Base_Ai_Cf_Deepgram_Flux with get, set
    abstract member ``_AT_cf/deepgram/aura-2-en``: Base_Ai_Cf_Deepgram_Aura_2_En with get, set
    abstract member ``_AT_cf/deepgram/aura-2-es``: Base_Ai_Cf_Deepgram_Aura_2_Es with get, set

[<AllowNullLiteral>]
[<Interface>]
type AiOptions =
    /// <summary>
    /// Send requests as an asynchronous batch job, only works for supported models
    /// https://developers.cloudflare.com/workers-ai/features/batch-api
    /// </summary>
    abstract member queueRequest: bool option with get, set
    /// <summary>
    /// Establish websocket connections, only works for supported models
    /// </summary>
    abstract member websocket: bool option with get, set
    /// <summary>
    /// Tag your requests to group and view them in Cloudflare dashboard.
    ///
    /// Rules:
    /// Tags must only contain letters, numbers, and the symbols: : - . / @
    /// Each tag can have maximum 50 characters.
    /// Maximum 5 tags are allowed each request.
    /// Duplicate tags will removed.
    /// </summary>
    abstract member tags: ResizeArray<string> option with get, set
    abstract member gateway: GatewayOptions option with get, set
    abstract member returnRawResponse: bool option with get, set
    abstract member prefix: string option with get, set
    abstract member extraHeaders: obj option with get, set

[<AllowNullLiteral>]
[<Interface>]
type AiModelsSearchParams =
    abstract member author: string option with get, set
    abstract member hide_experimental: bool option with get, set
    abstract member page: float option with get, set
    abstract member per_page: float option with get, set
    abstract member search: string option with get, set
    abstract member source: float option with get, set
    abstract member task: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type AiModelsSearchObject =
    abstract member id: string with get, set
    abstract member source: float with get, set
    abstract member name: string with get, set
    abstract member description: string with get, set
    abstract member task: AiModelsSearchObject.task with get, set
    abstract member tags: ResizeArray<string> with get, set
    abstract member properties: ResizeArray<AiModelsSearchObject.properties> with get, set

[<AllowNullLiteral>]
[<Interface>]
type InferenceUpstreamError =
    inherit Exception

[<AllowNullLiteral>]
[<Interface>]
type AiInternalError =
    inherit Exception

[<AllowNullLiteral>]
[<Interface>]
type AiModelListType =
    [<EmitIndexer>]
    abstract member Item: key: string -> obj with get, set

[<AllowNullLiteral>]
[<Interface>]
type Ai<'AiModelList when 'AiModelList :> AiModelListType> =
    abstract member aiGatewayLogId: U2<string, obj> with get, set
    abstract member gateway: gatewayId: string -> AiGateway
    /// <summary>
    /// Access the AI Search API for managing AI-powered search instances.
    ///
    /// This is the new API that replaces AutoRAG with better namespace separation:
    /// - Account-level operations: <c>list()</c>, <c>create()</c>
    /// - Instance-level operations: <c>get(id).search()</c>, <c>get(id).chatCompletions()</c>, <c>get(id).delete()</c>
    /// </summary>
    /// <example>
    /// <code lang="typescript">
    /// // List all AI Search instances
    /// const instances = await env.AI.aiSearch.list();
    ///
    /// // Search an instance
    /// const results = await env.AI.aiSearch.get('my-search').search({
    ///   messages: [{ role: 'user', content: 'What is the policy?' }],
    ///   ai_search_options: {
    ///     retrieval: { max_num_results: 10 }
    ///   }
    /// });
    ///
    /// // Generate chat completions with AI Search context
    /// const response = await env.AI.aiSearch.get('my-search').chatCompletions({
    ///   messages: [{ role: 'user', content: 'What is the policy?' }],
    ///   model: '@cf/meta/llama-3.3-70b-instruct-fp8-fast'
    /// });
    /// </code>
    /// </example>
    abstract member aiSearch: unit -> AiSearchAccountService
    abstract member autorag: autoragId: string -> AutoRAG
    abstract member run: model: 'Name * inputs: 'InputOptions * ?options: 'Options -> JS.Promise<'Options>
    abstract member models: ?``params``: AiModelsSearchParams -> JS.Promise<ResizeArray<AiModelsSearchObject>>
    abstract member toMarkdown: unit -> ToMarkdownService
    abstract member toMarkdown: files: ResizeArray<MarkdownDocument> * ?options: ConversionRequestOptions -> JS.Promise<ResizeArray<ConversionResponse>>
    abstract member toMarkdown: files: MarkdownDocument * ?options: ConversionRequestOptions -> JS.Promise<ConversionResponse>

type Ai =
    Ai<AiModels>

[<AllowNullLiteral>]
[<Interface>]
type GatewayRetries =
    abstract member maxAttempts: GatewayRetries.maxAttempts option with get, set
    abstract member retryDelayMs: float option with get, set
    abstract member backoff: GatewayRetries.backoff option with get, set

[<AllowNullLiteral>]
[<Interface>]
type GatewayOptions =
    abstract member id: string with get, set
    abstract member cacheKey: string option with get, set
    abstract member cacheTtl: float option with get, set
    abstract member skipCache: bool option with get, set
    abstract member metadata: GatewayOptions.metadata option with get, set
    abstract member collectLog: bool option with get, set
    abstract member eventId: string option with get, set
    abstract member requestTimeoutMs: float option with get, set
    abstract member retries: GatewayRetries option with get, set

type UniversalGatewayOptions =
    obj

[<AllowNullLiteral>]
[<Interface>]
type AiGatewayPatchLog =
    abstract member score: U2<float, obj> option with get, set
    abstract member feedback: U3<int, int, obj> option with get, set
    abstract member metadata: U2<AiGatewayPatchLog.metadata.U2.Case1, obj> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type AiGatewayLog =
    abstract member id: string with get, set
    abstract member provider: string with get, set
    abstract member model: string with get, set
    abstract member model_type: string option with get, set
    abstract member path: string with get, set
    abstract member duration: float with get, set
    abstract member request_type: string option with get, set
    abstract member request_content_type: string option with get, set
    abstract member status_code: float with get, set
    abstract member response_content_type: string option with get, set
    abstract member success: bool with get, set
    abstract member cached: bool with get, set
    abstract member tokens_in: float option with get, set
    abstract member tokens_out: float option with get, set
    abstract member metadata: AiGatewayLog.metadata option with get, set
    abstract member step: float option with get, set
    abstract member cost: float option with get, set
    abstract member custom_cost: bool option with get, set
    abstract member request_size: float with get, set
    abstract member request_head: string option with get, set
    abstract member request_head_complete: bool with get, set
    abstract member response_size: float with get, set
    abstract member response_head: string option with get, set
    abstract member response_head_complete: bool with get, set
    abstract member created_at: JS.Date with get, set

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type AIGatewayProviders =
    | ``workers-ai``
    | anthropic
    | ``aws-bedrock``
    | ``azure-openai``
    | ``google-vertex-ai``
    | huggingface
    | openai
    | ``perplexity-ai``
    | replicate
    | groq
    | cohere
    | ``google-ai-studio``
    | mistral
    | grok
    | openrouter
    | deepseek
    | cerebras
    | cartesia
    | elevenlabs
    | ``adobe-firefly``

[<AllowNullLiteral>]
[<Interface>]
type AIGatewayHeaders =
    abstract member ``cf-aig-metadata``: U2<AIGatewayHeaders.````cf-aig-metadata````.U2.Case1, string> with get, set
    abstract member ``cf-aig-custom-cost``: U3<AIGatewayHeaders.````cf-aig-custom-cost````.U3.Case1, AIGatewayHeaders.````cf-aig-custom-cost````.U3.Case2, string> with get, set
    abstract member ``cf-aig-cache-ttl``: U2<float, string> with get, set
    abstract member ``cf-aig-skip-cache``: U2<bool, string> with get, set
    abstract member ``cf-aig-cache-key``: string with get, set
    abstract member ``cf-aig-event-id``: string with get, set
    abstract member ``cf-aig-request-timeout``: U2<float, string> with get, set
    abstract member ``cf-aig-max-attempts``: U2<float, string> with get, set
    abstract member ``cf-aig-retry-delay``: U2<float, string> with get, set
    abstract member ``cf-aig-backoff``: string with get, set
    abstract member ``cf-aig-collect-log``: U2<bool, string> with get, set
    abstract member Authorization: string with get, set
    abstract member ``Content-Type``: string with get, set
    [<EmitIndexer>]
    abstract member Item: key: string -> U4<string, float, bool, obj> with get, set

[<AllowNullLiteral>]
[<Interface>]
type AIGatewayUniversalRequest =
    abstract member provider: U2<AIGatewayProviders, string> with get, set
    abstract member endpoint: string with get, set
    abstract member headers: AIGatewayUniversalRequest.headers with get, set
    abstract member query: obj with get, set

[<AllowNullLiteral>]
[<Interface>]
type AiGatewayInternalError =
    inherit Exception

[<AllowNullLiteral>]
[<Interface>]
type AiGatewayLogNotFound =
    inherit Exception

[<AllowNullLiteral>]
[<Interface>]
type AiGateway =
    abstract member patchLog: logId: string * data: AiGatewayPatchLog -> JS.Promise<unit>
    abstract member getLog: logId: string -> JS.Promise<AiGatewayLog>
    abstract member run: data: U2<AIGatewayUniversalRequest, ResizeArray<AIGatewayUniversalRequest>> * ?options: AiGateway.run.options -> JS.Promise<Response>
    abstract member getUrl: ?provider: U2<AIGatewayProviders, string> -> JS.Promise<string>

[<AllowNullLiteral>]
[<Interface>]
type AutoRAGInternalError =
    inherit Exception

[<AllowNullLiteral>]
[<Interface>]
type AutoRAGNotFoundError =
    inherit Exception

[<AllowNullLiteral>]
[<Interface>]
type AutoRAGUnauthorizedError =
    inherit Exception

[<AllowNullLiteral>]
[<Interface>]
type AutoRAGNameNotSetError =
    inherit Exception

[<AllowNullLiteral>]
[<Interface>]
type ComparisonFilter =
    abstract member key: string with get, set
    abstract member ``type``: ComparisonFilter.``type`` with get, set
    abstract member value: U3<string, float, bool> with get, set

[<AllowNullLiteral>]
[<Interface>]
type CompoundFilter =
    abstract member ``type``: CompoundFilter.``type`` with get, set
    abstract member filters: ResizeArray<ComparisonFilter> with get, set

[<AllowNullLiteral>]
[<Interface>]
type AutoRagSearchRequest =
    abstract member query: string with get, set
    abstract member filters: U2<CompoundFilter, ComparisonFilter> option with get, set
    abstract member max_num_results: float option with get, set
    abstract member ranking_options: AutoRagSearchRequest.ranking_options option with get, set
    abstract member reranking: AutoRagSearchRequest.reranking option with get, set
    abstract member rewrite_query: bool option with get, set

[<AllowNullLiteral>]
[<Interface>]
type AutoRagAiSearchRequest =
    abstract member query: string with get, set
    abstract member filters: U2<CompoundFilter, ComparisonFilter> option with get, set
    abstract member max_num_results: float option with get, set
    abstract member ranking_options: AutoRagAiSearchRequest.ranking_options option with get, set
    abstract member reranking: AutoRagAiSearchRequest.reranking option with get, set
    abstract member rewrite_query: bool option with get, set
    abstract member stream: bool option with get, set
    abstract member system_prompt: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type AutoRagAiSearchRequestStreaming =
    abstract member query: string with get, set
    abstract member filters: U2<CompoundFilter, ComparisonFilter> option with get, set
    abstract member max_num_results: float option with get, set
    abstract member ranking_options: AutoRagAiSearchRequestStreaming.ranking_options option with get, set
    abstract member reranking: AutoRagAiSearchRequestStreaming.reranking option with get, set
    abstract member rewrite_query: bool option with get, set
    abstract member system_prompt: string option with get, set
    abstract member stream: bool with get, set

[<AllowNullLiteral>]
[<Interface>]
type AutoRagSearchResponse =
    abstract member ``object``: string with get, set
    abstract member search_query: string with get, set
    abstract member data: ResizeArray<AutoRagSearchResponse.data> with get, set
    abstract member has_more: bool with get, set
    abstract member next_page: U2<string, obj> with get, set

type AutoRagListResponse =
    ResizeArray<AutoRagListResponse>

[<AllowNullLiteral>]
[<Interface>]
type AutoRagAiSearchResponse =
    abstract member ``object``: string with get, set
    abstract member search_query: string with get, set
    abstract member data: ResizeArray<AutoRagAiSearchResponse.data> with get, set
    abstract member has_more: bool with get, set
    abstract member next_page: U2<string, obj> with get, set
    abstract member response: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type AutoRAG =
    abstract member list: unit -> JS.Promise<AutoRagListResponse>
    abstract member search: ``params``: AutoRagSearchRequest -> JS.Promise<AutoRagSearchResponse>
    abstract member aiSearch: ``params``: AutoRagAiSearchRequestStreaming -> JS.Promise<Response>
    abstract member aiSearch: ``params``: AutoRagAiSearchRequest -> JS.Promise<AutoRagAiSearchResponse>
    abstract member aiSearch: ``params``: AutoRagAiSearchRequest -> JS.Promise<U2<AutoRagAiSearchResponse, Response>>

[<AllowNullLiteral>]
[<Interface>]
type BasicImageTransformations =
    /// <summary>
    /// Maximum width in image pixels. The value must be an integer.
    /// </summary>
    abstract member width: float option with get, set
    /// <summary>
    /// Maximum height in image pixels. The value must be an integer.
    /// </summary>
    abstract member height: float option with get, set
    /// <summary>
    /// Resizing mode as a string. It affects interpretation of width and height
    /// options:
    ///  - scale-down: Similar to contain, but the image is never enlarged. If
    ///    the image is larger than given width or height, it will be resized.
    ///    Otherwise its original size will be kept.
    ///  - contain: Resizes to maximum size that fits within the given width and
    ///    height. If only a single dimension is given (e.g. only width), the
    ///    image will be shrunk or enlarged to exactly match that dimension.
    ///    Aspect ratio is always preserved.
    ///  - cover: Resizes (shrinks or enlarges) to fill the entire area of width
    ///    and height. If the image has an aspect ratio different from the ratio
    ///    of width and height, it will be cropped to fit.
    ///  - crop: The image will be shrunk and cropped to fit within the area
    ///    specified by width and height. The image will not be enlarged. For images
    ///    smaller than the given dimensions it's the same as scale-down. For
    ///    images larger than the given dimensions, it's the same as cover.
    ///    See also trim.
    ///  - pad: Resizes to the maximum size that fits within the given width and
    ///    height, and then fills the remaining area with a background color
    ///    (white by default). Use of this mode is not recommended, as the same
    ///    effect can be more efficiently achieved with the contain mode and the
    ///    CSS object-fit: contain property.
    ///  - squeeze: Stretches and deforms to the width and height given, even if it
    ///    breaks aspect ratio
    /// </summary>
    abstract member fit: BasicImageTransformations.fit option with get, set
    /// <summary>
    /// Image segmentation using artificial intelligence models. Sets pixels not
    /// within selected segment area to transparent e.g "foreground" sets every
    /// background pixel as transparent.
    /// </summary>
    abstract member segment: string option with get, set
    /// <summary>
    /// When cropping with fit: "cover", this defines the side or point that should
    /// be left uncropped. The value is either a string
    /// "left", "right", "top", "bottom", "auto", or "center" (the default),
    /// or an object {x, y} containing focal point coordinates in the original
    /// image expressed as fractions ranging from 0.0 (top or left) to 1.0
    /// (bottom or right), 0.5 being the center. {fit: "cover", gravity: "top"} will
    /// crop bottom or left and right sides as necessary, but won’t crop anything
    /// from the top. {fit: "cover", gravity: {x:0.5, y:0.2}} will crop each side to
    /// preserve as much as possible around a point at 20% of the height of the
    /// source image.
    /// </summary>
    abstract member gravity: BasicImageTransformations.gravity option with get, set
    /// <summary>
    /// Background color to add underneath the image. Applies only to images with
    /// transparency (such as PNG). Accepts any CSS color (#RRGGBB, rgba(…),
    /// hsl(…), etc.)
    /// </summary>
    abstract member background: string option with get, set
    /// <summary>
    /// Number of degrees (90, 180, 270) to rotate the image by. width and height
    /// options refer to axes after rotation.
    /// </summary>
    abstract member rotate: BasicImageTransformations.rotate option with get, set

[<AllowNullLiteral>]
[<Interface>]
type BasicImageTransformationsGravityCoordinates =
    abstract member x: float option with get, set
    abstract member y: float option with get, set
    abstract member mode: BasicImageTransformationsGravityCoordinates.mode option with get, set

[<AllowNullLiteral>]
[<Interface>]
type RequestInitCfProperties =
    inherit Record<string, obj>
    abstract member cacheEverything: bool option with get, set
    /// <summary>
    /// A request's cache key is what determines if two requests are
    /// "the same" for caching purposes. If a request has the same cache key
    /// as some previous request, then we can serve the same cached response for
    /// both. (e.g. 'some-key')
    ///
    /// Only available for Enterprise customers.
    /// </summary>
    abstract member cacheKey: string option with get, set
    /// <summary>
    /// This allows you to append additional Cache-Tag response headers
    /// to the origin response without modifications to the origin server.
    /// This will allow for greater control over the Purge by Cache Tag feature
    /// utilizing changes only in the Workers process.
    ///
    /// Only available for Enterprise customers.
    /// </summary>
    abstract member cacheTags: ResizeArray<string> option with get, set
    /// <summary>
    /// Force response to be cached for a given number of seconds. (e.g. 300)
    /// </summary>
    abstract member cacheTtl: float option with get, set
    /// <summary>
    /// Force response to be cached for a given number of seconds based on the Origin status code.
    /// (e.g. { '200-299': 86400, '404': 1, '500-599': 0 })
    /// </summary>
    abstract member cacheTtlByStatus: RequestInitCfProperties.cacheTtlByStatus option with get, set
    abstract member scrapeShield: bool option with get, set
    abstract member apps: bool option with get, set
    abstract member image: RequestInitCfPropertiesImage option with get, set
    abstract member minify: RequestInitCfPropertiesImageMinify option with get, set
    abstract member mirage: bool option with get, set
    abstract member polish: RequestInitCfProperties.polish option with get, set
    abstract member r2: RequestInitCfPropertiesR2 option with get, set
    /// <summary>
    /// Redirects the request to an alternate origin server. You can use this,
    /// for example, to implement load balancing across several origins.
    /// (e.g.us-east.example.com)
    ///
    /// Note - For security reasons, the hostname set in resolveOverride must
    /// be proxied on the same Cloudflare zone of the incoming request.
    /// Otherwise, the setting is ignored. CNAME hosts are allowed, so to
    /// resolve to a host under a different domain or a DNS only domain first
    /// declare a CNAME record within your own zone’s DNS mapping to the
    /// external hostname, set proxy on Cloudflare, then set resolveOverride
    /// to point to that CNAME record.
    /// </summary>
    abstract member resolveOverride: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type RequestInitCfPropertiesImageDraw =
    inherit BasicImageTransformations
    /// <summary>
    /// Absolute URL of the image file to use for the drawing. It can be any of
    /// the supported file formats. For drawing of watermarks or non-rectangular
    /// overlays we recommend using PNG or WebP images.
    /// </summary>
    abstract member url: string with get, set
    /// <summary>
    /// Floating-point number between 0 (transparent) and 1 (opaque).
    /// For example, opacity: 0.5 makes overlay semitransparent.
    /// </summary>
    abstract member opacity: float option with get, set
    /// <summary>
    /// - If set to true, the overlay image will be tiled to cover the entire
    ///   area. This is useful for stock-photo-like watermarks.
    /// - If set to "x", the overlay image will be tiled horizontally only
    ///   (form a line).
    /// - If set to "y", the overlay image will be tiled vertically only
    ///   (form a line).
    /// </summary>
    abstract member repeat: U3<bool, string, string> option with get, set
    /// <summary>
    /// Position of the overlay image relative to a given edge. Each property is
    /// an offset in pixels. 0 aligns exactly to the edge. For example, left: 10
    /// positions left side of the overlay 10 pixels from the left edge of the
    /// image it's drawn over. bottom: 0 aligns bottom of the overlay with bottom
    /// of the background image.
    ///
    /// Setting both left & right, or both top & bottom is an error.
    ///
    /// If no position is specified, the image will be centered.
    /// </summary>
    abstract member top: float option with get, set
    abstract member left: float option with get, set
    abstract member bottom: float option with get, set
    abstract member right: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type RequestInitCfPropertiesImage =
    inherit BasicImageTransformations
    /// <summary>
    /// Device Pixel Ratio. Default 1. Multiplier for width/height that makes it
    /// easier to specify higher-DPI sizes in <img srcset>.
    /// </summary>
    abstract member dpr: float option with get, set
    /// <summary>
    /// Allows you to trim your image. Takes dpr into account and is performed before
    /// resizing or rotation.
    ///
    /// It can be used as:
    /// - left, top, right, bottom - it will specify the number of pixels to cut
    ///   off each side
    /// - width, height - the width/height you'd like to end up with - can be used
    ///   in combination with the properties above
    /// - border - this will automatically trim the surroundings of an image based on
    ///   it's color. It consists of three properties:
    ///    - color: rgb or hex representation of the color you wish to trim (todo: verify the rgba bit)
    ///    - tolerance: difference from color to treat as color
    ///    - keep: the number of pixels of border to keep
    /// </summary>
    abstract member trim: RequestInitCfPropertiesImage.trim option with get, set
    /// <summary>
    /// Quality setting from 1-100 (useful values are in 60-90 range). Lower values
    /// make images look worse, but load faster. The default is 85. It applies only
    /// to JPEG and WebP images. It doesn’t have any effect on PNG.
    /// </summary>
    abstract member quality: RequestInitCfPropertiesImage.quality option with get, set
    /// <summary>
    /// Output format to generate. It can be:
    ///  - avif: generate images in AVIF format.
    ///  - webp: generate images in Google WebP format. Set quality to 100 to get
    ///    the WebP-lossless format.
    ///  - json: instead of generating an image, outputs information about the
    ///    image, in JSON format. The JSON object will contain image size
    ///    (before and after resizing), source image’s MIME type, file size, etc.
    /// - jpeg: generate images in JPEG format.
    /// - png: generate images in PNG format.
    /// </summary>
    abstract member format: RequestInitCfPropertiesImage.format option with get, set
    /// <summary>
    /// Whether to preserve animation frames from input files. Default is true.
    /// Setting it to false reduces animations to still images. This setting is
    /// recommended when enlarging images or processing arbitrary user content,
    /// because large GIF animations can weigh tens or even hundreds of megabytes.
    /// It is also useful to set anim:false when using format:"json" to get the
    /// response quicker without the number of frames.
    /// </summary>
    abstract member anim: bool option with get, set
    /// <summary>
    /// What EXIF data should be preserved in the output image. Note that EXIF
    /// rotation and embedded color profiles are always applied ("baked in" into
    /// the image), and aren't affected by this option. Note that if the Polish
    /// feature is enabled, all metadata may have been removed already and this
    /// option may have no effect.
    ///  - keep: Preserve most of EXIF metadata, including GPS location if there's
    ///    any.
    ///  - copyright: Only keep the copyright tag, and discard everything else.
    ///    This is the default behavior for JPEG files.
    ///  - none: Discard all invisible EXIF metadata. Currently WebP and PNG
    ///    output formats always discard metadata.
    /// </summary>
    abstract member metadata: RequestInitCfPropertiesImage.metadata option with get, set
    /// <summary>
    /// Strength of sharpening filter to apply to the image. Floating-point
    /// number between 0 (no sharpening, default) and 10 (maximum). 1.0 is a
    /// recommended value for downscaled images.
    /// </summary>
    abstract member sharpen: float option with get, set
    /// <summary>
    /// Radius of a blur filter (approximate gaussian). Maximum supported radius
    /// is 250.
    /// </summary>
    abstract member blur: float option with get, set
    /// <summary>
    /// Overlays are drawn in the order they appear in the array (last array
    /// entry is the topmost layer).
    /// </summary>
    abstract member draw: ResizeArray<RequestInitCfPropertiesImageDraw> option with get, set
    /// <summary>
    /// Fetching image from authenticated origin. Setting this property will
    /// pass authentication headers (Authorization, Cookie, etc.) through to
    /// the origin.
    /// </summary>
    abstract member ``origin-auth``: string option with get, set
    /// <summary>
    /// Adds a border around the image. The border is added after resizing. Border
    /// width takes dpr into account, and can be specified either using a single
    /// width property, or individually for each side.
    /// </summary>
    abstract member border: RequestInitCfPropertiesImage.border option with get, set
    /// <summary>
    /// Increase brightness by a factor. A value of 1.0 equals no change, a value
    /// of 0.5 equals half brightness, and a value of 2.0 equals twice as bright.
    /// 0 is ignored.
    /// </summary>
    abstract member brightness: float option with get, set
    /// <summary>
    /// Increase contrast by a factor. A value of 1.0 equals no change, a value of
    /// 0.5 equals low contrast, and a value of 2.0 equals high contrast. 0 is
    /// ignored.
    /// </summary>
    abstract member contrast: float option with get, set
    /// <summary>
    /// Increase exposure by a factor. A value of 1.0 equals no change, a value of
    /// 0.5 darkens the image, and a value of 2.0 lightens the image. 0 is ignored.
    /// </summary>
    abstract member gamma: float option with get, set
    /// <summary>
    /// Increase contrast by a factor. A value of 1.0 equals no change, a value of
    /// 0.5 equals low contrast, and a value of 2.0 equals high contrast. 0 is
    /// ignored.
    /// </summary>
    abstract member saturation: float option with get, set
    /// <summary>
    /// Flips the images horizontally, vertically, or both. Flipping is applied before
    /// rotation, so if you apply flip=h,rotate=90 then the image will be flipped
    /// horizontally, then rotated by 90 degrees.
    /// </summary>
    abstract member flip: RequestInitCfPropertiesImage.flip option with get, set
    /// <summary>
    /// Slightly reduces latency on a cache miss by selecting a
    /// quickest-to-compress file format, at a cost of increased file size and
    /// lower image quality. It will usually override the format option and choose
    /// JPEG over WebP or AVIF. We do not recommend using this option, except in
    /// unusual circumstances like resizing uncacheable dynamically-generated
    /// images.
    /// </summary>
    abstract member compression: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type RequestInitCfPropertiesImageMinify =
    abstract member javascript: bool option with get, set
    abstract member css: bool option with get, set
    abstract member html: bool option with get, set

[<AllowNullLiteral>]
[<Interface>]
type RequestInitCfPropertiesR2 =
    /// <summary>
    /// Colo id of bucket that an object is stored in
    /// </summary>
    abstract member bucketColoId: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type IncomingRequestCfProperties<'HostMetadata> =
    /// <summary>
    /// [ASN](https://www.iana.org/assignments/as-numbers/as-numbers.xhtml) of the incoming request.
    /// </summary>
    abstract member asn: float option with get, set
    /// <summary>
    /// The organization which owns the ASN of the incoming request.
    /// </summary>
    abstract member asOrganization: string option with get, set
    /// <summary>
    /// The original value of the <c>Accept-Encoding</c> header if Cloudflare modified it.
    /// </summary>
    abstract member clientAcceptEncoding: string option with get, set
    /// <summary>
    /// The number of milliseconds it took for the request to reach your worker.
    /// </summary>
    abstract member clientTcpRtt: float option with get, set
    /// <summary>
    /// The three-letter [IATA](https://en.wikipedia.org/wiki/IATA_airport_code)
    /// airport code of the data center that the request hit.
    /// </summary>
    abstract member colo: string with get, set
    /// <summary>
    /// Represents the upstream's response to a
    /// [TCP <c>keepalive</c> message](https://tldp.org/HOWTO/TCP-Keepalive-HOWTO/overview.html)
    /// from cloudflare.
    ///
    /// For workers with no upstream, this will always be <c>1</c>.
    /// </summary>
    abstract member edgeRequestKeepAliveStatus: IncomingRequestCfPropertiesEdgeRequestKeepAliveStatus with get, set
    /// <summary>
    /// The HTTP Protocol the request used.
    /// </summary>
    abstract member httpProtocol: string with get, set
    /// <summary>
    /// The browser-requested prioritization information in the request object.
    ///
    /// If no information was set, defaults to the empty string <c>""</c>
    /// </summary>
    abstract member requestPriority: string with get, set
    /// <summary>
    /// The TLS version of the connection to Cloudflare.
    /// In requests served over plaintext (without TLS), this property is the empty string <c>""</c>.
    /// </summary>
    abstract member tlsVersion: string with get, set
    /// <summary>
    /// The cipher for the connection to Cloudflare.
    /// In requests served over plaintext (without TLS), this property is the empty string <c>""</c>.
    /// </summary>
    abstract member tlsCipher: string with get, set
    /// <summary>
    /// Metadata containing the [<c>HELLO</c>](https://www.rfc-editor.org/rfc/rfc5246#section-7.4.1.2) and [<c>FINISHED</c>](https://www.rfc-editor.org/rfc/rfc5246#section-7.4.9) messages from this request's TLS handshake.
    ///
    /// If the incoming request was served over plaintext (without TLS) this field is undefined.
    /// </summary>
    abstract member tlsExportedAuthenticator: IncomingRequestCfPropertiesExportedAuthenticatorMetadata option with get, set
    /// <summary>
    /// Results of Cloudflare's Bot Management analysis
    /// </summary>
    abstract member botManagement: IncomingRequestCfProperties.botManagement with get, set
    /// <summary>
    /// Duplicate of <c>botManagement.score</c>.
    /// </summary>
    abstract member clientTrustScore: float with get, set
    /// <summary>
    /// Custom metadata set per-host in [Cloudflare for SaaS](https://developers.cloudflare.com/cloudflare-for-platforms/cloudflare-for-saas/).
    ///
    /// This field is only present if you have Cloudflare for SaaS enabled on your account
    /// and you have followed the [required steps to enable it]((https://developers.cloudflare.com/cloudflare-for-platforms/cloudflare-for-saas/domain-support/custom-metadata/)).
    /// </summary>
    abstract member hostMetadata: 'HostMetadata option with get, set
    /// <summary>
    /// The [ISO 3166-1 Alpha 2](https://www.iso.org/iso-3166-country-codes.html) country code the request originated from.
    ///
    /// If your worker is [configured to accept TOR connections](https://support.cloudflare.com/hc/en-us/articles/203306930-Understanding-Cloudflare-Tor-support-and-Onion-Routing), this may also be <c>"T1"</c>, indicating a request that originated over TOR.
    ///
    /// If Cloudflare is unable to determine where the request originated this property is omitted.
    ///
    /// The country code <c>"T1"</c> is used for requests originating on TOR.
    /// </summary>
    abstract member country: IncomingRequestCfProperties.country option with get, set
    /// <summary>
    /// If present, this property indicates that the request originated in the EU
    /// </summary>
    abstract member isEUCountry: string option with get, set
    /// <summary>
    /// A two-letter code indicating the continent the request originated from.
    /// </summary>
    abstract member continent: ContinentCode option with get, set
    /// <summary>
    /// The city the request originated from
    /// </summary>
    abstract member city: string option with get, set
    /// <summary>
    /// Postal code of the incoming request
    /// </summary>
    abstract member postalCode: string option with get, set
    /// <summary>
    /// Latitude of the incoming request
    /// </summary>
    abstract member latitude: string option with get, set
    /// <summary>
    /// Longitude of the incoming request
    /// </summary>
    abstract member longitude: string option with get, set
    /// <summary>
    /// Timezone of the incoming request
    /// </summary>
    abstract member timezone: string option with get, set
    /// <summary>
    /// If known, the ISO 3166-2 name for the first level region associated with
    /// the IP address of the incoming request
    /// </summary>
    abstract member region: string option with get, set
    /// <summary>
    /// If known, the ISO 3166-2 code for the first-level region associated with
    /// the IP address of the incoming request
    /// </summary>
    abstract member regionCode: string option with get, set
    /// <summary>
    /// Metro code (DMA) of the incoming request
    /// </summary>
    abstract member metroCode: string option with get, set
    /// <summary>
    /// Information about the client certificate presented to Cloudflare.
    ///
    /// This is populated when the incoming request is served over TLS using
    /// either Cloudflare Access or API Shield (mTLS)
    /// and the presented SSL certificate has a valid
    /// [Certificate Serial Number](https://ldapwiki.com/wiki/Certificate%20Serial%20Number)
    /// (i.e., not <c>null</c> or <c>""</c>).
    ///
    /// Otherwise, a set of placeholder values are used.
    ///
    /// The property <c>certPresented</c> will be set to <c>"1"</c> when
    /// the object is populated (i.e. the above conditions were met).
    /// </summary>
    abstract member tlsClientAuth: U2<IncomingRequestCfPropertiesTLSClientAuth, IncomingRequestCfPropertiesTLSClientAuthPlaceholder> with get, set

[<AllowNullLiteral>]
[<Interface>]
type IncomingRequestCfPropertiesBase =
    inherit Record<string, obj>
    /// <summary>
    /// [ASN](https://www.iana.org/assignments/as-numbers/as-numbers.xhtml) of the incoming request.
    /// </summary>
    abstract member asn: float option with get, set
    /// <summary>
    /// The organization which owns the ASN of the incoming request.
    /// </summary>
    abstract member asOrganization: string option with get, set
    /// <summary>
    /// The original value of the <c>Accept-Encoding</c> header if Cloudflare modified it.
    /// </summary>
    abstract member clientAcceptEncoding: string option with get, set
    /// <summary>
    /// The number of milliseconds it took for the request to reach your worker.
    /// </summary>
    abstract member clientTcpRtt: float option with get, set
    /// <summary>
    /// The three-letter [IATA](https://en.wikipedia.org/wiki/IATA_airport_code)
    /// airport code of the data center that the request hit.
    /// </summary>
    abstract member colo: string with get, set
    /// <summary>
    /// Represents the upstream's response to a
    /// [TCP <c>keepalive</c> message](https://tldp.org/HOWTO/TCP-Keepalive-HOWTO/overview.html)
    /// from cloudflare.
    ///
    /// For workers with no upstream, this will always be <c>1</c>.
    /// </summary>
    abstract member edgeRequestKeepAliveStatus: IncomingRequestCfPropertiesEdgeRequestKeepAliveStatus with get, set
    /// <summary>
    /// The HTTP Protocol the request used.
    /// </summary>
    abstract member httpProtocol: string with get, set
    /// <summary>
    /// The browser-requested prioritization information in the request object.
    ///
    /// If no information was set, defaults to the empty string <c>""</c>
    /// </summary>
    abstract member requestPriority: string with get, set
    /// <summary>
    /// The TLS version of the connection to Cloudflare.
    /// In requests served over plaintext (without TLS), this property is the empty string <c>""</c>.
    /// </summary>
    abstract member tlsVersion: string with get, set
    /// <summary>
    /// The cipher for the connection to Cloudflare.
    /// In requests served over plaintext (without TLS), this property is the empty string <c>""</c>.
    /// </summary>
    abstract member tlsCipher: string with get, set
    /// <summary>
    /// Metadata containing the [<c>HELLO</c>](https://www.rfc-editor.org/rfc/rfc5246#section-7.4.1.2) and [<c>FINISHED</c>](https://www.rfc-editor.org/rfc/rfc5246#section-7.4.9) messages from this request's TLS handshake.
    ///
    /// If the incoming request was served over plaintext (without TLS) this field is undefined.
    /// </summary>
    abstract member tlsExportedAuthenticator: IncomingRequestCfPropertiesExportedAuthenticatorMetadata option with get, set

[<AllowNullLiteral>]
[<Interface>]
type IncomingRequestCfPropertiesBotManagementBase =
    /// <summary>
    /// Cloudflare’s [level of certainty](https://developers.cloudflare.com/bots/concepts/bot-score/) that a request comes from a bot,
    /// represented as an integer percentage between <c>1</c> (almost certainly a bot) and <c>99</c> (almost certainly human).
    /// </summary>
    abstract member score: float with get, set
    /// <summary>
    /// A boolean value that is true if the request comes from a good bot, like Google or Bing.
    /// Most customers choose to allow this traffic. For more details, see [Traffic from known bots](https://developers.cloudflare.com/firewall/known-issues-and-faq/#how-does-firewall-rules-handle-traffic-from-known-bots).
    /// </summary>
    abstract member verifiedBot: bool with get, set
    /// <summary>
    /// A boolean value that is true if the request originates from a
    /// Cloudflare-verified proxy service.
    /// </summary>
    abstract member corporateProxy: bool with get, set
    /// <summary>
    /// A boolean value that's true if the request matches [file extensions](https://developers.cloudflare.com/bots/reference/static-resources/) for many types of static resources.
    /// </summary>
    abstract member staticResource: bool with get, set
    /// <summary>
    /// List of IDs that correlate to the Bot Management heuristic detections made on a request (you can have multiple heuristic detections on the same request).
    /// </summary>
    abstract member detectionIds: ResizeArray<float> with get, set

[<AllowNullLiteral>]
[<Interface>]
type IncomingRequestCfPropertiesBotManagement =
    /// <summary>
    /// Results of Cloudflare's Bot Management analysis
    /// </summary>
    abstract member botManagement: IncomingRequestCfPropertiesBotManagementBase with get, set
    /// <summary>
    /// Duplicate of <c>botManagement.score</c>.
    /// </summary>
    abstract member clientTrustScore: float with get, set

[<AllowNullLiteral>]
[<Interface>]
type IncomingRequestCfPropertiesBotManagementEnterprise =
    inherit IncomingRequestCfPropertiesBotManagement
    /// <summary>
    /// Results of Cloudflare's Bot Management analysis
    /// </summary>
    abstract member botManagement: IncomingRequestCfPropertiesBotManagementEnterprise.botManagement with get, set

[<AllowNullLiteral>]
[<Interface>]
type IncomingRequestCfPropertiesCloudflareForSaaSEnterprise<'HostMetadata> =
    /// <summary>
    /// Custom metadata set per-host in [Cloudflare for SaaS](https://developers.cloudflare.com/cloudflare-for-platforms/cloudflare-for-saas/).
    ///
    /// This field is only present if you have Cloudflare for SaaS enabled on your account
    /// and you have followed the [required steps to enable it]((https://developers.cloudflare.com/cloudflare-for-platforms/cloudflare-for-saas/domain-support/custom-metadata/)).
    /// </summary>
    abstract member hostMetadata: 'HostMetadata option with get, set

[<AllowNullLiteral>]
[<Interface>]
type IncomingRequestCfPropertiesCloudflareAccessOrApiShield =
    /// <summary>
    /// Information about the client certificate presented to Cloudflare.
    ///
    /// This is populated when the incoming request is served over TLS using
    /// either Cloudflare Access or API Shield (mTLS)
    /// and the presented SSL certificate has a valid
    /// [Certificate Serial Number](https://ldapwiki.com/wiki/Certificate%20Serial%20Number)
    /// (i.e., not <c>null</c> or <c>""</c>).
    ///
    /// Otherwise, a set of placeholder values are used.
    ///
    /// The property <c>certPresented</c> will be set to <c>"1"</c> when
    /// the object is populated (i.e. the above conditions were met).
    /// </summary>
    abstract member tlsClientAuth: U2<IncomingRequestCfPropertiesTLSClientAuth, IncomingRequestCfPropertiesTLSClientAuthPlaceholder> with get, set

[<AllowNullLiteral>]
[<Interface>]
type IncomingRequestCfPropertiesExportedAuthenticatorMetadata =
    /// <summary>
    /// The client's [<c>HELLO</c> message](https://www.rfc-editor.org/rfc/rfc5246#section-7.4.1.2), encoded in hexadecimal
    /// </summary>
    abstract member clientHandshake: string with get, set
    /// <summary>
    /// The server's [<c>HELLO</c> message](https://www.rfc-editor.org/rfc/rfc5246#section-7.4.1.2), encoded in hexadecimal
    /// </summary>
    abstract member serverHandshake: string with get, set
    /// <summary>
    /// The client's [<c>FINISHED</c> message](https://www.rfc-editor.org/rfc/rfc5246#section-7.4.9), encoded in hexadecimal
    /// </summary>
    abstract member clientFinished: string with get, set
    /// <summary>
    /// The server's [<c>FINISHED</c> message](https://www.rfc-editor.org/rfc/rfc5246#section-7.4.9), encoded in hexadecimal
    /// </summary>
    abstract member serverFinished: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type IncomingRequestCfPropertiesGeographicInformation =
    /// <summary>
    /// The [ISO 3166-1 Alpha 2](https://www.iso.org/iso-3166-country-codes.html) country code the request originated from.
    ///
    /// If your worker is [configured to accept TOR connections](https://support.cloudflare.com/hc/en-us/articles/203306930-Understanding-Cloudflare-Tor-support-and-Onion-Routing), this may also be <c>"T1"</c>, indicating a request that originated over TOR.
    ///
    /// If Cloudflare is unable to determine where the request originated this property is omitted.
    ///
    /// The country code <c>"T1"</c> is used for requests originating on TOR.
    /// </summary>
    abstract member country: IncomingRequestCfPropertiesGeographicInformation.country option with get, set
    /// <summary>
    /// If present, this property indicates that the request originated in the EU
    /// </summary>
    abstract member isEUCountry: string option with get, set
    /// <summary>
    /// A two-letter code indicating the continent the request originated from.
    /// </summary>
    abstract member continent: ContinentCode option with get, set
    /// <summary>
    /// The city the request originated from
    /// </summary>
    abstract member city: string option with get, set
    /// <summary>
    /// Postal code of the incoming request
    /// </summary>
    abstract member postalCode: string option with get, set
    /// <summary>
    /// Latitude of the incoming request
    /// </summary>
    abstract member latitude: string option with get, set
    /// <summary>
    /// Longitude of the incoming request
    /// </summary>
    abstract member longitude: string option with get, set
    /// <summary>
    /// Timezone of the incoming request
    /// </summary>
    abstract member timezone: string option with get, set
    /// <summary>
    /// If known, the ISO 3166-2 name for the first level region associated with
    /// the IP address of the incoming request
    /// </summary>
    abstract member region: string option with get, set
    /// <summary>
    /// If known, the ISO 3166-2 code for the first-level region associated with
    /// the IP address of the incoming request
    /// </summary>
    abstract member regionCode: string option with get, set
    /// <summary>
    /// Metro code (DMA) of the incoming request
    /// </summary>
    abstract member metroCode: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type IncomingRequestCfPropertiesTLSClientAuth =
    /// <summary>
    /// Always <c>"1"</c>, indicating that the certificate was presented
    /// </summary>
    abstract member certPresented: string with get, set
    /// <summary>
    /// Result of certificate verification.
    /// </summary>
    abstract member certVerified: IncomingRequestCfPropertiesTLSClientAuth.certVerified with get, set
    /// <summary>
    /// The presented certificate's revokation status.
    ///
    /// - A value of <c>"1"</c> indicates the certificate has been revoked
    /// - A value of <c>"0"</c> indicates the certificate has not been revoked
    /// </summary>
    abstract member certRevoked: IncomingRequestCfPropertiesTLSClientAuth.certRevoked with get, set
    /// <summary>
    /// The certificate issuer's [distinguished name](https://knowledge.digicert.com/generalinformation/INFO1745.html)
    /// </summary>
    abstract member certIssuerDN: string with get, set
    /// <summary>
    /// The certificate subject's [distinguished name](https://knowledge.digicert.com/generalinformation/INFO1745.html)
    /// </summary>
    abstract member certSubjectDN: string with get, set
    /// <summary>
    /// The certificate issuer's [distinguished name](https://knowledge.digicert.com/generalinformation/INFO1745.html) ([RFC 2253](https://www.rfc-editor.org/rfc/rfc2253.html) formatted)
    /// </summary>
    abstract member certIssuerDNRFC2253: string with get, set
    /// <summary>
    /// The certificate subject's [distinguished name](https://knowledge.digicert.com/generalinformation/INFO1745.html) ([RFC 2253](https://www.rfc-editor.org/rfc/rfc2253.html) formatted)
    /// </summary>
    abstract member certSubjectDNRFC2253: string with get, set
    /// <summary>
    /// The certificate issuer's distinguished name (legacy policies)
    /// </summary>
    abstract member certIssuerDNLegacy: string with get, set
    /// <summary>
    /// The certificate subject's distinguished name (legacy policies)
    /// </summary>
    abstract member certSubjectDNLegacy: string with get, set
    /// <summary>
    /// The certificate's serial number
    /// </summary>
    abstract member certSerial: string with get, set
    /// <summary>
    /// The certificate issuer's serial number
    /// </summary>
    abstract member certIssuerSerial: string with get, set
    /// <summary>
    /// The certificate's Subject Key Identifier
    /// </summary>
    abstract member certSKI: string with get, set
    /// <summary>
    /// The certificate issuer's Subject Key Identifier
    /// </summary>
    abstract member certIssuerSKI: string with get, set
    /// <summary>
    /// The certificate's SHA-1 fingerprint
    /// </summary>
    abstract member certFingerprintSHA1: string with get, set
    /// <summary>
    /// The certificate's SHA-256 fingerprint
    /// </summary>
    abstract member certFingerprintSHA256: string with get, set
    /// <summary>
    /// The effective starting date of the certificate
    /// </summary>
    abstract member certNotBefore: string with get, set
    /// <summary>
    /// The effective expiration date of the certificate
    /// </summary>
    abstract member certNotAfter: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type IncomingRequestCfPropertiesTLSClientAuthPlaceholder =
    abstract member certPresented: string with get, set
    abstract member certVerified: string with get, set
    abstract member certRevoked: string with get, set
    abstract member certIssuerDN: string with get, set
    abstract member certSubjectDN: string with get, set
    abstract member certIssuerDNRFC2253: string with get, set
    abstract member certSubjectDNRFC2253: string with get, set
    abstract member certIssuerDNLegacy: string with get, set
    abstract member certSubjectDNLegacy: string with get, set
    abstract member certSerial: string with get, set
    abstract member certIssuerSerial: string with get, set
    abstract member certSKI: string with get, set
    abstract member certIssuerSKI: string with get, set
    abstract member certFingerprintSHA1: string with get, set
    abstract member certFingerprintSHA256: string with get, set
    abstract member certNotBefore: string with get, set
    abstract member certNotAfter: string with get, set

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type CertVerificationStatus =
    | SUCCESS
    | NONE
    | ``FAILED:self signed certificate``
    | ``FAILED:unable to verify the first certificate``
    | ``FAILED:certificate is not yet valid``
    | ``FAILED:certificate has expired``
    | FAILED

[<RequireQualifiedAccess>]
type IncomingRequestCfPropertiesEdgeRequestKeepAliveStatus =
    | ``0`` = 0
    | ``1`` = 1
    | ``2`` = 2
    | ``3`` = 3
    | ``4`` = 4
    | ``5`` = 5

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type Iso3166Alpha2Code =
    | AD
    | AE
    | AF
    | AG
    | AI
    | AL
    | AM
    | AO
    | AQ
    | AR
    | AS
    | AT
    | AU
    | AW
    | AX
    | AZ
    | BA
    | BB
    | BD
    | BE
    | BF
    | BG
    | BH
    | BI
    | BJ
    | BL
    | BM
    | BN
    | BO
    | BQ
    | BR
    | BS
    | BT
    | BV
    | BW
    | BY
    | BZ
    | CA
    | CC
    | CD
    | CF
    | CG
    | CH
    | CI
    | CK
    | CL
    | CM
    | CN
    | CO
    | CR
    | CU
    | CV
    | CW
    | CX
    | CY
    | CZ
    | DE
    | DJ
    | DK
    | DM
    | DO
    | DZ
    | EC
    | EE
    | EG
    | EH
    | ER
    | ES
    | ET
    | FI
    | FJ
    | FK
    | FM
    | FO
    | FR
    | GA
    | GB
    | GD
    | GE
    | GF
    | GG
    | GH
    | GI
    | GL
    | GM
    | GN
    | GP
    | GQ
    | GR
    | GS
    | GT
    | GU
    | GW
    | GY
    | HK
    | HM
    | HN
    | HR
    | HT
    | HU
    | ID
    | IE
    | IL
    | IM
    | IN
    | IO
    | IQ
    | IR
    | IS
    | IT
    | JE
    | JM
    | JO
    | JP
    | KE
    | KG
    | KH
    | KI
    | KM
    | KN
    | KP
    | KR
    | KW
    | KY
    | KZ
    | LA
    | LB
    | LC
    | LI
    | LK
    | LR
    | LS
    | LT
    | LU
    | LV
    | LY
    | MA
    | MC
    | MD
    | ME
    | MF
    | MG
    | MH
    | MK
    | ML
    | MM
    | MN
    | MO
    | MP
    | MQ
    | MR
    | MS
    | MT
    | MU
    | MV
    | MW
    | MX
    | MY
    | MZ
    | NA
    | NC
    | NE
    | NF
    | NG
    | NI
    | NL
    | NO
    | NP
    | NR
    | NU
    | NZ
    | OM
    | PA
    | PE
    | PF
    | PG
    | PH
    | PK
    | PL
    | PM
    | PN
    | PR
    | PS
    | PT
    | PW
    | PY
    | QA
    | RE
    | RO
    | RS
    | RU
    | RW
    | SA
    | SB
    | SC
    | SD
    | SE
    | SG
    | SH
    | SI
    | SJ
    | SK
    | SL
    | SM
    | SN
    | SO
    | SR
    | SS
    | ST
    | SV
    | SX
    | SY
    | SZ
    | TC
    | TD
    | TF
    | TG
    | TH
    | TJ
    | TK
    | TL
    | TM
    | TN
    | TO
    | TR
    | TT
    | TV
    | TW
    | TZ
    | UA
    | UG
    | UM
    | US
    | UY
    | UZ
    | VA
    | VC
    | VE
    | VG
    | VI
    | VN
    | VU
    | WF
    | WS
    | YE
    | YT
    | ZA
    | ZM
    | ZW

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type ContinentCode =
    | AF
    | AN
    | AS
    | EU
    | NA
    | OC
    | SA

type CfProperties<'HostMetadata> =
    U2<IncomingRequestCfProperties<'HostMetadata>, RequestInitCfProperties>

[<AllowNullLiteral>]
[<Interface>]
type D1Meta =
    abstract member duration: float with get, set
    abstract member size_after: float with get, set
    abstract member rows_read: float with get, set
    abstract member rows_written: float with get, set
    abstract member last_row_id: float with get, set
    abstract member changed_db: bool with get, set
    abstract member changes: float with get, set
    /// <summary>
    /// The region of the database instance that executed the query.
    /// </summary>
    abstract member served_by_region: string option with get, set
    /// <summary>
    /// The three letters airport code of the colo that executed the query.
    /// </summary>
    abstract member served_by_colo: string option with get, set
    /// <summary>
    /// True if-and-only-if the database instance that executed the query was the primary.
    /// </summary>
    abstract member served_by_primary: bool option with get, set
    abstract member timings: D1Meta.timings option with get, set
    /// <summary>
    /// Number of total attempts to execute the query, due to automatic retries.
    /// Note: All other fields in the response like <c>timings</c> only apply to the last attempt.
    /// </summary>
    abstract member total_attempts: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type D1Response =
    abstract member success: bool with get, set
    abstract member meta: D1Response.meta with get, set
    abstract member error: obj option with get, set

[<AllowNullLiteral>]
[<Interface>]
type D1Result<'T> =
    abstract member success: bool with get, set
    abstract member meta: D1Result.meta with get, set
    abstract member error: obj option with get, set
    abstract member results: ResizeArray<'T> with get, set

[<AllowNullLiteral>]
[<Interface>]
type D1ExecResult =
    abstract member count: float with get, set
    abstract member duration: float with get, set

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type D1SessionConstraint =
    | ``first-primary``
    | ``first-unconstrained``

type D1SessionBookmark =
    string

[<AllowNullLiteral>]
[<Interface>]
type D1Database =
    abstract member prepare: query: string -> D1PreparedStatement
    abstract member batch: statements: ResizeArray<D1PreparedStatement> -> JS.Promise<ResizeArray<D1Result<'T>>>
    abstract member exec: query: string -> JS.Promise<D1ExecResult>
    /// <summary>
    /// Creates a new D1 Session anchored at the given constraint or the bookmark.
    /// All queries executed using the created session will have sequential consistency,
    /// meaning that all writes done through the session will be visible in subsequent reads.
    /// </summary>
    /// <param name="constraintOrBookmark">
    /// Either the session constraint or the explicit bookmark to anchor the created session.
    /// </param>
    abstract member withSession: ?constraintOrBookmark: U2<D1SessionBookmark, D1SessionConstraint> -> D1DatabaseSession
    abstract member dump: unit -> JS.Promise<ArrayBuffer>

[<AllowNullLiteral>]
[<Interface>]
type D1DatabaseSession =
    abstract member prepare: query: string -> D1PreparedStatement
    abstract member batch: statements: ResizeArray<D1PreparedStatement> -> JS.Promise<ResizeArray<D1Result<'T>>>
    abstract member getBookmark: unit -> U2<D1SessionBookmark, obj>

[<AllowNullLiteral>]
[<Interface>]
type D1PreparedStatement =
    abstract member bind: [<ParamArray>] values: obj [] -> D1PreparedStatement
    abstract member first: colName: string -> JS.Promise<U2<'T, obj>>
    abstract member first: unit -> JS.Promise<U2<'T, obj>>
    abstract member run: unit -> JS.Promise<D1Result<'T>>
    abstract member all: unit -> JS.Promise<D1Result<'T>>
    abstract member raw: options: D1PreparedStatement.raw.options -> JS.Promise<ResizeArray<string> * obj>
    abstract member raw: ?options: D1PreparedStatement.raw.options_1 -> JS.Promise<ResizeArray<'T>>

[<AllowNullLiteral>]
[<Interface>]
type Disposable =
    interface end

[<AllowNullLiteral>]
[<Interface>]
type EmailSendResult =
    /// <summary>
    /// The Email Message ID
    /// </summary>
    abstract member messageId: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type EmailMessage =
    /// <summary>
    /// Envelope From attribute of the email message.
    /// </summary>
    abstract member from: string with get
    /// <summary>
    /// Envelope To attribute of the email message.
    /// </summary>
    abstract member ``to``: string with get

[<AllowNullLiteral>]
[<Interface>]
type ForwardableEmailMessage =
    inherit EmailMessage
    /// <summary>
    /// Stream of the email message content.
    /// </summary>
    abstract member raw: ReadableStream<JS.Uint8Array> with get
    /// <summary>
    /// An [Headers object](https://developer.mozilla.org/en-US/docs/Web/API/Headers).
    /// </summary>
    abstract member headers: Headers with get
    /// <summary>
    /// Size of the email message content.
    /// </summary>
    abstract member rawSize: float with get
    /// <summary>
    /// Reject this email message by returning a permanent SMTP error back to the connecting client including the given reason.
    /// </summary>
    /// <param name="reason">
    /// The reject reason.
    /// </param>
    /// <returns>
    /// void
    /// </returns>
    abstract member setReject: reason: string -> unit
    /// <summary>
    /// Forward this email message to a verified destination address of the account.
    /// </summary>
    /// <param name="rcptTo">
    /// Verified destination address.
    /// </param>
    /// <param name="headers">
    /// A [Headers object](https://developer.mozilla.org/en-US/docs/Web/API/Headers).
    /// </param>
    /// <returns>
    /// A promise that resolves when the email message is forwarded.
    /// </returns>
    abstract member forward: rcptTo: string * ?headers: Headers -> JS.Promise<EmailSendResult>
    /// <summary>
    /// Reply to the sender of this email message with a new EmailMessage object.
    /// </summary>
    /// <param name="message">
    /// The reply message.
    /// </param>
    /// <returns>
    /// A promise that resolves when the email message is replied.
    /// </returns>
    abstract member reply: message: EmailMessage -> JS.Promise<EmailSendResult>

[<AllowNullLiteral>]
[<Interface>]
type EmailAttachment =
    abstract member disposition: string with get, set
    abstract member contentId: string with get, set
    abstract member filename: string with get, set
    abstract member ``type``: string with get, set
    abstract member content: U3<string, ArrayBuffer, ArrayBufferView> with get, set
    abstract member disposition: string with get, set
    abstract member contentId: obj option with get, set
    abstract member filename: string with get, set
    abstract member ``type``: string with get, set
    abstract member content: U3<string, ArrayBuffer, ArrayBufferView> with get, set

[<AllowNullLiteral>]
[<Interface>]
type EmailAddress =
    abstract member name: string with get, set
    abstract member email: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type SendEmail =
    abstract member send: message: EmailMessage -> JS.Promise<EmailSendResult>
    abstract member send: builder: SendEmail.send.builder -> JS.Promise<EmailSendResult>

[<AllowNullLiteral>]
[<Interface>]
type EmailEvent =
    inherit ExtendableEvent
    abstract member message: ForwardableEmailMessage with get

[<AllowNullLiteral>]
[<Interface>]
type EmailExportedHandler<'Env> =
    [<Emit("$0($1...)")>]
    abstract member Invoke: message: ForwardableEmailMessage * env: 'Env * ctx: ExecutionContext -> U2<unit, JS.Promise<unit>>

module cloudflare:email_ =



[<AllowNullLiteral>]
[<Interface>]
type HelloWorldBinding =
    /// <summary>
    /// Retrieve the current stored value
    /// </summary>
    abstract member get: unit -> JS.Promise<HelloWorldBinding.get>
    /// <summary>
    /// Set a new stored value
    /// </summary>
    abstract member set: value: string -> JS.Promise<unit>

[<AllowNullLiteral>]
[<Interface>]
type Hyperdrive =
    /// <summary>
    /// Connect directly to Hyperdrive as if it's your database, returning a TCP socket.
    ///
    /// Calling this method returns an identical socket to if you call
    /// <c>connect("host:port")</c> using the <c>host</c> and <c>port</c> fields from this object.
    /// Pick whichever approach works better with your preferred DB client library.
    ///
    /// Note that this socket is not yet authenticated -- it's expected that your
    /// code (or preferably, the client library of your choice) will authenticate
    /// using the information in this class's readonly fields.
    /// </summary>
    abstract member connect: unit -> Socket
    /// <summary>
    /// A valid DB connection string that can be passed straight into the typical
    /// client library/driver/ORM. This will typically be the easiest way to use
    /// Hyperdrive.
    /// </summary>
    abstract member connectionString: string with get
    abstract member host: string with get
    abstract member port: float with get
    abstract member user: string with get
    abstract member password: string with get
    abstract member database: string with get

[<AllowNullLiteral>]
[<Interface>]
type ImageInfoResponse =
    abstract member format: string with get, set
    abstract member format: string with get, set
    abstract member fileSize: float with get, set
    abstract member width: float with get, set
    abstract member height: float with get, set

[<AllowNullLiteral>]
[<Interface>]
type ImageTransform =
    abstract member width: float option with get, set
    abstract member height: float option with get, set
    abstract member background: string option with get, set
    abstract member blur: float option with get, set
    abstract member border: ImageTransform.border option with get, set
    abstract member brightness: float option with get, set
    abstract member contrast: float option with get, set
    abstract member fit: ImageTransform.fit option with get, set
    abstract member flip: ImageTransform.flip option with get, set
    abstract member gamma: float option with get, set
    abstract member segment: string option with get, set
    abstract member gravity: ImageTransform.gravity option with get, set
    abstract member rotate: ImageTransform.rotate option with get, set
    abstract member saturation: float option with get, set
    abstract member sharpen: float option with get, set
    abstract member trim: ImageTransform.trim option with get, set

[<AllowNullLiteral>]
[<Interface>]
type ImageDrawOptions =
    abstract member opacity: float option with get, set
    abstract member repeat: U2<bool, string> option with get, set
    abstract member top: float option with get, set
    abstract member left: float option with get, set
    abstract member bottom: float option with get, set
    abstract member right: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type ImageInputOptions =
    abstract member encoding: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type ImageOutputOptions =
    abstract member format: ImageOutputOptions.format with get, set
    abstract member quality: float option with get, set
    abstract member background: string option with get, set
    abstract member anim: bool option with get, set

[<AllowNullLiteral>]
[<Interface>]
type ImageMetadata =
    abstract member id: string with get, set
    abstract member filename: string option with get, set
    abstract member uploaded: string option with get, set
    abstract member requireSignedURLs: bool with get, set
    abstract member meta: ImageMetadata.meta option with get, set
    abstract member variants: ResizeArray<string> with get, set
    abstract member draft: bool option with get, set
    abstract member creator: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type ImageUploadOptions =
    abstract member id: string option with get, set
    abstract member filename: string option with get, set
    abstract member requireSignedURLs: bool option with get, set
    abstract member metadata: ImageUploadOptions.metadata option with get, set
    abstract member creator: string option with get, set
    abstract member encoding: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type ImageUpdateOptions =
    abstract member requireSignedURLs: bool option with get, set
    abstract member metadata: ImageUpdateOptions.metadata option with get, set
    abstract member creator: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type ImageListOptions =
    abstract member limit: float option with get, set
    abstract member cursor: string option with get, set
    abstract member sortOrder: ImageListOptions.sortOrder option with get, set
    abstract member creator: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type ImageList =
    abstract member images: ResizeArray<ImageMetadata> with get, set
    abstract member cursor: string option with get, set
    abstract member listComplete: bool with get, set

[<AllowNullLiteral>]
[<Interface>]
type HostedImagesBinding =
    /// <summary>
    /// Get detailed metadata for a hosted image
    /// </summary>
    /// <param name="imageId">
    /// The ID of the image (UUID or custom ID)
    /// </param>
    /// <returns>
    /// Image metadata, or null if not found
    /// </returns>
    abstract member details: imageId: string -> JS.Promise<U2<ImageMetadata, obj>>
    /// <summary>
    /// Get the raw image data for a hosted image
    /// </summary>
    /// <param name="imageId">
    /// The ID of the image (UUID or custom ID)
    /// </param>
    /// <returns>
    /// ReadableStream of image bytes, or null if not found
    /// </returns>
    abstract member image: imageId: string -> JS.Promise<U2<ReadableStream<JS.Uint8Array>, obj>>
    /// <summary>
    /// Upload a new hosted image
    /// </summary>
    /// <param name="image">
    /// The image file to upload
    /// </param>
    /// <param name="options">
    /// Upload configuration
    /// </param>
    /// <returns>
    /// Metadata for the uploaded image
    /// </returns>
    abstract member upload: image: U2<ReadableStream<JS.Uint8Array>, ArrayBuffer> * ?options: ImageUploadOptions -> JS.Promise<ImageMetadata>
    /// <summary>
    /// Update hosted image metadata
    /// </summary>
    /// <param name="imageId">
    /// The ID of the image
    /// </param>
    /// <param name="options">
    /// Properties to update
    /// </param>
    /// <returns>
    /// Updated image metadata
    /// </returns>
    abstract member update: imageId: string * options: ImageUpdateOptions -> JS.Promise<ImageMetadata>
    /// <summary>
    /// Delete a hosted image
    /// </summary>
    /// <param name="imageId">
    /// The ID of the image
    /// </param>
    /// <returns>
    /// True if deleted, false if not found
    /// </returns>
    abstract member delete: imageId: string -> JS.Promise<bool>
    /// <summary>
    /// List hosted images with pagination
    /// </summary>
    /// <param name="options">
    /// List configuration
    /// </param>
    /// <returns>
    /// List of images with pagination info
    /// </returns>
    abstract member list: ?options: ImageListOptions -> JS.Promise<ImageList>

[<AllowNullLiteral>]
[<Interface>]
type ImagesBinding =
    /// <summary>
    /// Get image metadata (type, width and height)
    /// </summary>
    /// <param name="stream">
    /// The image bytes
    /// </param>
    abstract member info: stream: ReadableStream<JS.Uint8Array> * ?options: ImageInputOptions -> JS.Promise<ImageInfoResponse>
    /// <summary>
    /// Begin applying a series of transformations to an image
    /// </summary>
    /// <param name="stream">
    /// The image bytes
    /// </param>
    /// <returns>
    /// A transform handle
    /// </returns>
    abstract member input: stream: ReadableStream<JS.Uint8Array> * ?options: ImageInputOptions -> ImageTransformer
    /// <summary>
    /// Access hosted images CRUD operations
    /// </summary>
    abstract member hosted: HostedImagesBinding with get

[<AllowNullLiteral>]
[<Interface>]
type ImageTransformer =
    /// <summary>
    /// Apply transform next, returning a transform handle.
    /// You can then apply more transformations, draw, or retrieve the output.
    /// </summary>
    /// <param name="transform">
    ///
    /// </param>
    abstract member transform: transform: ImageTransform -> ImageTransformer
    /// <summary>
    /// Draw an image on this transformer, returning a transform handle.
    /// You can then apply more transformations, draw, or retrieve the output.
    /// </summary>
    /// <param name="image">
    /// The image (or transformer that will give the image) to draw
    /// </param>
    /// <param name="options">
    /// The options configuring how to draw the image
    /// </param>
    abstract member draw: image: U2<ReadableStream<JS.Uint8Array>, ImageTransformer> * ?options: ImageDrawOptions -> ImageTransformer
    /// <summary>
    /// Retrieve the image that results from applying the transforms to the
    /// provided input
    /// </summary>
    /// <param name="options">
    /// Options that apply to the output e.g. output format
    /// </param>
    abstract member output: options: ImageOutputOptions -> JS.Promise<ImageTransformationResult>

[<AllowNullLiteral>]
[<Interface>]
type ImageTransformationOutputOptions =
    abstract member encoding: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type ImageTransformationResult =
    /// <summary>
    /// The image as a response, ready to store in cache or return to users
    /// </summary>
    abstract member response: unit -> Response
    /// <summary>
    /// The content type of the returned image
    /// </summary>
    abstract member contentType: unit -> string
    /// <summary>
    /// The bytes of the response
    /// </summary>
    abstract member image: ?options: ImageTransformationOutputOptions -> ReadableStream<JS.Uint8Array>

[<AllowNullLiteral>]
[<Interface>]
type ImagesError =
    inherit Exception
    abstract member code: float with get
    abstract member message: string with get
    abstract member stack: string option with get

[<AllowNullLiteral>]
[<Interface>]
type MediaBinding =
    /// <summary>
    /// Creates a media transformer from an input stream.
    /// </summary>
    /// <param name="media">
    /// The input media bytes
    /// </param>
    /// <returns>
    /// A MediaTransformer instance for applying transformations
    /// </returns>
    abstract member input: media: ReadableStream<JS.Uint8Array> -> MediaTransformer

[<AllowNullLiteral>]
[<Interface>]
type MediaTransformer =
    /// <summary>
    /// Applies transformation options to the media content.
    /// </summary>
    /// <param name="transform">
    /// Configuration for how the media should be transformed
    /// </param>
    /// <returns>
    /// A generator for producing the transformed media output
    /// </returns>
    abstract member transform: ?transform: MediaTransformationInputOptions -> MediaTransformationGenerator
    /// <summary>
    /// Generates the final media output with specified options.
    /// </summary>
    /// <param name="output">
    /// Configuration for the output format and parameters
    /// </param>
    /// <returns>
    /// The final transformation result containing the transformed media
    /// </returns>
    abstract member output: ?output: MediaTransformationOutputOptions -> MediaTransformationResult

[<AllowNullLiteral>]
[<Interface>]
type MediaTransformationGenerator =
    /// <summary>
    /// Generates the final media output with specified options.
    /// </summary>
    /// <param name="output">
    /// Configuration for the output format and parameters
    /// </param>
    /// <returns>
    /// The final transformation result containing the transformed media
    /// </returns>
    abstract member output: ?output: MediaTransformationOutputOptions -> MediaTransformationResult

[<AllowNullLiteral>]
[<Interface>]
type MediaTransformationResult =
    /// <summary>
    /// Returns the transformed media as a readable stream of bytes.
    /// </summary>
    /// <returns>
    /// A promise containing a readable stream with the transformed media
    /// </returns>
    abstract member media: unit -> JS.Promise<ReadableStream<JS.Uint8Array>>
    /// <summary>
    /// Returns the transformed media as an HTTP response object.
    /// </summary>
    /// <returns>
    /// The transformed media as a Promise<Response>, ready to store in cache or return to users
    /// </returns>
    abstract member response: unit -> JS.Promise<Response>
    /// <summary>
    /// Returns the MIME type of the transformed media.
    /// </summary>
    /// <returns>
    /// A promise containing the content type string (e.g., 'image/jpeg', 'video/mp4')
    /// </returns>
    abstract member contentType: unit -> JS.Promise<string>

[<AllowNullLiteral>]
[<Interface>]
type MediaTransformationInputOptions =
    /// <summary>
    /// How the media should be resized to fit the specified dimensions
    /// </summary>
    abstract member fit: MediaTransformationInputOptions.fit option with get, set
    /// <summary>
    /// Target width in pixels
    /// </summary>
    abstract member width: float option with get, set
    /// <summary>
    /// Target height in pixels
    /// </summary>
    abstract member height: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type MediaTransformationOutputOptions =
    /// <summary>
    /// Output mode determining the type of media to generate
    /// </summary>
    abstract member mode: MediaTransformationOutputOptions.mode option with get, set
    /// <summary>
    /// Whether to include audio in the output
    /// </summary>
    abstract member audio: bool option with get, set
    /// <summary>
    /// Starting timestamp for frame extraction or start time for clips. (e.g. '2s').
    /// </summary>
    abstract member time: string option with get, set
    /// <summary>
    /// Duration for video clips, audio extraction, and spritesheet generation (e.g. '5s').
    /// </summary>
    abstract member duration: string option with get, set
    /// <summary>
    /// Number of frames in the spritesheet.
    /// </summary>
    abstract member imageCount: float option with get, set
    /// <summary>
    /// Output format for the generated media.
    /// </summary>
    abstract member format: MediaTransformationOutputOptions.format option with get, set

[<AllowNullLiteral>]
[<Interface>]
type MediaError =
    inherit Exception
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/MediaError/code)
    /// </summary>
    abstract member code: float with get
    /// <summary>
    /// [MDN Reference](https://developer.mozilla.org/docs/Web/API/MediaError/message)
    /// </summary>
    abstract member message: string with get
    abstract member stack: string option with get

module cloudflare:node_ =

    [<AbstractClass>]
    [<Erase>]
    type Exports =
        [<Emit("$0.httpServerHandler($1...)")>]
        abstract member httpServerHandler: port: float -> ExportedHandler
        [<Emit("$0.httpServerHandler($1...)")>]
        abstract member httpServerHandler: options: Exports.httpServerHandler.options -> ExportedHandler
        [<Emit("$0.httpServerHandler($1...)")>]
        abstract member httpServerHandler: server: NodeStyleServer -> ExportedHandler

    [<AllowNullLiteral>]
    [<Interface>]
    type NodeStyleServer =
        abstract member listen: [<ParamArray>] args: obj [] -> NodeStyleServer
        abstract member address: unit -> NodeStyleServer.address

    module NodeStyleServer =

        [<Global>]
        [<AllowNullLiteral>]
        type address
            [<ParamObject; Emit("$0")>]
            (
                ?port: U2<float, obj> option
            ) =

            member val port : U2<float, obj> option option = nativeOnly with get, set

    module Exports =

        module httpServerHandler =

            [<Global>]
            [<AllowNullLiteral>]
            type options
                [<ParamObject; Emit("$0")>]
                (
                    port: float
                ) =

                member val port : float = nativeOnly with get, set

[<AllowNullLiteral>]
[<Interface>]
type Params =
    [<EmitIndexer>]
    abstract member Item: key: 'P -> U2<string, ResizeArray<string>> with get, set

[<AllowNullLiteral>]
[<Interface>]
type EventContext<'Env, 'Data> =
    abstract member request: Request<obj, IncomingRequestCfProperties<obj>> with get, set
    abstract member functionPath: string with get, set
    abstract member waitUntil: (JS.Promise<obj> -> unit) with get, set
    abstract member passThroughOnException: (unit -> unit) with get, set
    abstract member next: EventContext.next with get, set
    abstract member env: EventContext.env with get, set
    abstract member ``params``: Params<string> with get, set
    abstract member data: 'Data with get, set

[<AllowNullLiteral>]
[<Interface>]
type PagesFunction<'Env, 'Data when 'Data :> PagesFunction_1> =
    [<Emit("$0($1...)")>]
    abstract member Invoke: context: EventContext<'Env, string, 'Data> -> U2<Response, JS.Promise<Response>>
    [<EmitIndexer>]
    abstract member Item: key: string -> obj with get, set

[<AllowNullLiteral>]
[<Interface>]
type EventPluginContext<'Env, 'Data, 'PluginArgs> =
    abstract member request: Request<obj, IncomingRequestCfProperties<obj>> with get, set
    abstract member functionPath: string with get, set
    abstract member waitUntil: (JS.Promise<obj> -> unit) with get, set
    abstract member passThroughOnException: (unit -> unit) with get, set
    abstract member next: EventPluginContext.next with get, set
    abstract member env: EventPluginContext.env with get, set
    abstract member ``params``: Params<string> with get, set
    abstract member data: 'Data with get, set
    abstract member pluginArgs: 'PluginArgs with get, set

[<AllowNullLiteral>]
[<Interface>]
type PagesPluginFunction<'Env, 'Data, 'PluginArgs when 'Data :> PagesPluginFunction_1> =
    [<Emit("$0($1...)")>]
    abstract member Invoke: context: EventPluginContext<'Env, string, 'Data, 'PluginArgs> -> U2<Response, JS.Promise<Response>>
    [<EmitIndexer>]
    abstract member Item: key: string -> obj with get, set

module assets:*_ =

    [<AbstractClass>]
    [<Erase>]
    type Exports =
        [<Emit("$0.onRequest")>]
        abstract member onRequest: PagesFunction

module cloudflare:pipelines_ =

    [<AbstractClass>]
    [<Erase>]
    type Exports =
        [<Emit("new $0.PipelineTransformationEntrypoint($1...)")>]
        abstract member PipelineTransformationEntrypoint<'Env, 'I, 'O when 'I :> PipelineRecord and 'O :> PipelineRecord>: ctx: ExecutionContext * env: 'Env -> PipelineTransformationEntrypoint<'Env, 'I, 'O>

    [<AllowNullLiteral>]
    [<Interface>]
    type PipelineTransformationEntrypoint<'Env, 'I, 'O when 'I :> PipelineRecord and 'O :> PipelineRecord> =
        abstract member env: 'Env with get, set
        abstract member ctx: ExecutionContext with get, set
        /// <summary>
        /// run receives an array of PipelineRecord which can be
        /// transformed and returned to the pipeline
        /// </summary>
        /// <param name="records">
        /// Incoming records from the pipeline to be transformed
        /// </param>
        /// <param name="metadata">
        /// Information about the specific pipeline calling the transformation entrypoint
        /// </param>
        /// <returns>
        /// A promise containing the transformed PipelineRecord array
        /// </returns>
        abstract member run: records: ResizeArray<'I> * metadata: PipelineBatchMetadata -> JS.Promise<ResizeArray<'O>>

    type PipelineTransformationEntrypoint<'Env, 'I when 'I :> PipelineRecord> =
        PipelineTransformationEntrypoint<'Env, 'I, PipelineRecord>

    type PipelineTransformationEntrypoint<'Env> =
        PipelineTransformationEntrypoint<'Env, PipelineRecord, PipelineRecord>

    type PipelineTransformationEntrypoint =
        PipelineTransformationEntrypoint<obj, PipelineRecord, PipelineRecord>

    [<AllowNullLiteral>]
    [<Interface>]
    type PipelineRecord =
        [<EmitIndexer>]
        abstract member Item: key: string -> obj with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type PipelineBatchMetadata =
        abstract member pipelineId: string with get, set
        abstract member pipelineName: string with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type Pipeline<'T when 'T :> PipelineRecord> =
        /// <summary>
        /// The Pipeline interface represents the type of a binding to a Pipeline
        /// </summary>
        /// <param name="records">
        /// The records to send to the pipeline
        /// </param>
        abstract member send: records: ResizeArray<'T> -> JS.Promise<unit>

    type Pipeline =
        Pipeline<PipelineRecord>

[<AllowNullLiteral>]
[<Interface>]
type PubSubMessage =
    abstract member mid: float with get
    abstract member broker: string with get
    abstract member topic: string with get
    abstract member clientId: string with get
    abstract member jti: string option with get
    abstract member receivedAt: float with get
    abstract member contentType: string with get
    abstract member payloadFormatIndicator: float with get
    abstract member payload: U2<string, JS.Uint8Array> with get, set

[<AllowNullLiteral>]
[<Interface>]
type JsonWebKeyWithKid =
    inherit JsonWebKey
    abstract member kid: string with get

[<AllowNullLiteral>]
[<Interface>]
type RateLimitOptions =
    abstract member key: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type RateLimitOutcome =
    abstract member success: bool with get, set

[<AllowNullLiteral>]
[<Interface>]
type RateLimit =
    /// <summary>
    /// Rate limit a request based on the provided options.
    /// </summary>
    /// <returns>
    /// A promise that resolves with the outcome of the rate limit.
    /// </returns>
    abstract member limit: options: RateLimitOptions -> JS.Promise<RateLimitOutcome>

module Rpc_ =

    [<AbstractClass>]
    [<Erase>]
    type Exports =
        [<Emit("$0.__RPC_STUB_BRAND")>]
        abstract member __RPC_STUB_BRAND: string
        [<Emit("$0.__RPC_TARGET_BRAND")>]
        abstract member __RPC_TARGET_BRAND: string
        [<Emit("$0.__WORKER_ENTRYPOINT_BRAND")>]
        abstract member __WORKER_ENTRYPOINT_BRAND: string
        [<Emit("$0.__DURABLE_OBJECT_BRAND")>]
        abstract member __DURABLE_OBJECT_BRAND: string
        [<Emit("$0.__WORKFLOW_ENTRYPOINT_BRAND")>]
        abstract member __WORKFLOW_ENTRYPOINT_BRAND: string

    [<AllowNullLiteral>]
    [<Interface>]
    type RpcTargetBranded =
        abstract member [__RPC_TARGET_BRAND]: obj with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type WorkerEntrypointBranded =
        abstract member [__WORKER_ENTRYPOINT_BRAND]: obj with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type DurableObjectBranded =
        abstract member [__DURABLE_OBJECT_BRAND]: obj with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type WorkflowEntrypointBranded =
        abstract member [__WORKFLOW_ENTRYPOINT_BRAND]: obj with get, set

    type EntrypointBranded =
        U3<WorkerEntrypointBranded, DurableObjectBranded, WorkflowEntrypointBranded>

    type Stubable =
        U2<RpcTargetBranded, System.Delegate>

    type Serializable<'T> =
        U7<BaseType, Map<'T, 'T>, Set<'T>, ReadonlyArray<'T>, obj, Stub<Stubable>, Stubable>

    [<AllowNullLiteral>]
    [<Interface>]
    type StubBase<'T when 'T :> Stubable> =
        inherit Disposable
        abstract member [__RPC_STUB_BRAND]: 'T with get, set
        abstract member dup: unit -> StubBase<'T>

    [<AllowNullLiteral>]
    [<Interface>]
    type Stub<'T when 'T :> Stubable> =
        abstract member dup: unit -> StubBase<'T>
        abstract member [__RPC_STUB_BRAND]: 'T with get, set
        abstract member [Symbol_dispose]: unit -> unit

    type BaseType =
        U17<unit, obj, bool, float, obj, string, TypedArray, ArrayBuffer, DataView, JS.Date, Exception, RegExp, ReadableStream<JS.Uint8Array>, WritableStream<JS.Uint8Array>, Request, Response, Headers> option

    type Stubify<'T> =
        'T

    type Unstubify<'T> =
        'T

    [<AllowNullLiteral>]
    [<Interface>]
    type UnstubifyAll<'A when 'A :> ResizeArray<obj>> =
        interface end

    type MaybeProvider<'T> =
        'T

    type MaybeDisposable<'T> =
        'T

    type Result<'R> =
        'R

    type MethodOrProperty<'V> =
        'V

    type MaybeCallableProvider<'T> =
        'T

    [<AllowNullLiteral>]
    [<Interface>]
    type Provider =
        interface end

module Cloudflare_ =

    [<AllowNullLiteral>]
    [<Interface>]
    type Env =
        interface end

    [<AllowNullLiteral>]
    [<Interface>]
    type GlobalProps =
        interface end

    type GlobalProp<'Default> =
        'K

    type MainModule =
        GlobalProp<string, MainModule.GlobalProp>

    [<AllowNullLiteral>]
    [<Interface>]
    type Exports =
        interface end

    module MainModule =

        [<Global>]
        [<AllowNullLiteral>]
        type GlobalProp
            [<ParamObject; Emit("$0")>]
            (
            ) =

            class end

module CloudflareWorkersModule_ =

    [<AbstractClass>]
    [<Erase>]
    type Exports =
        [<Emit("$0.RpcStub")>]
        abstract member RpcStub: Exports.RpcStub
        [<Emit("$0.waitUntil($1...)")>]
        abstract member waitUntil: promise: JS.Promise<obj> -> unit
        [<Emit("$0.withEnv($1...)")>]
        abstract member withEnv: newEnv: obj * fn: (unit -> obj) -> obj
        [<Emit("$0.withExports($1...)")>]
        abstract member withExports: newExports: obj * fn: (unit -> obj) -> obj
        [<Emit("$0.withEnvAndExports($1...)")>]
        abstract member withEnvAndExports: newEnv: obj * newExports: obj * fn: (unit -> obj) -> obj
        [<Emit("$0.env")>]
        abstract member env: Cloudflare.Env
        [<Emit("$0.exports")>]
        abstract member exports: Cloudflare.Exports
        [<Emit("new $0.RpcTarget($1...)")>]
        abstract member RpcTarget: unit -> RpcTarget
        [<Emit("new $0.WorkerEntrypoint($1...)")>]
        abstract member WorkerEntrypoint<'Env, 'Props>: ctx: ExecutionContext * env: 'Env -> WorkerEntrypoint<'Env, 'Props>
        [<Emit("new $0.DurableObject($1...)")>]
        abstract member DurableObject<'Env, 'Props>: ctx: DurableObjectState * env: 'Env -> DurableObject<'Env, 'Props>
        [<Emit("new $0.WorkflowStep($1...)")>]
        abstract member WorkflowStep: unit -> WorkflowStep
        [<Emit("new $0.WorkflowEntrypoint($1...)")>]
        abstract member WorkflowEntrypoint<'Env>: ctx: ExecutionContext * env: 'Env -> WorkflowEntrypoint<'Env>

    type RpcStub<'T when 'T :> Rpc.Stubable> =
        Rpc.Stub<'T>

    [<AllowNullLiteral>]
    [<Interface>]
    type RpcTarget =
        inherit Rpc.RpcTargetBranded
        abstract member [Rpc___RPC_TARGET_BRAND]: obj with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type WorkerEntrypoint<'Env, 'Props> =
        inherit Rpc.WorkerEntrypointBranded
        abstract member [Rpc___WORKER_ENTRYPOINT_BRAND]: obj with get, set
        abstract member ctx: ExecutionContext<'Props> with get, set
        abstract member env: 'Env with get, set
        abstract member email: message: ForwardableEmailMessage -> U2<unit, JS.Promise<unit>>
        abstract member fetch: request: Request -> U2<Response, JS.Promise<Response>>
        abstract member queue: batch: MessageBatch<obj> -> U2<unit, JS.Promise<unit>>
        abstract member scheduled: controller: ScheduledController -> U2<unit, JS.Promise<unit>>
        abstract member tail: events: ResizeArray<TraceItem> -> U2<unit, JS.Promise<unit>>
        abstract member tailStream: event: TailStream.TailEvent<TailStream.Onset> -> U2<TailStream.TailEventHandlerType, JS.Promise<TailStream.TailEventHandlerType>>
        abstract member test: controller: TestController -> U2<unit, JS.Promise<unit>>
        abstract member trace: traces: ResizeArray<TraceItem> -> U2<unit, JS.Promise<unit>>

    type WorkerEntrypoint<'Env> =
        WorkerEntrypoint<'Env, WorkerEntrypoint>

    type WorkerEntrypoint =
        WorkerEntrypoint<Cloudflare.Env, WorkerEntrypoint>

    [<AllowNullLiteral>]
    [<Interface>]
    type DurableObject<'Env, 'Props> =
        inherit Rpc.DurableObjectBranded
        abstract member [Rpc___DURABLE_OBJECT_BRAND]: obj with get, set
        abstract member ctx: DurableObjectState<'Props> with get, set
        abstract member env: 'Env with get, set
        abstract member alarm: ?alarmInfo: AlarmInvocationInfo -> U2<unit, JS.Promise<unit>>
        abstract member fetch: request: Request -> U2<Response, JS.Promise<Response>>
        abstract member webSocketMessage: ws: WebSocket * message: U2<string, ArrayBuffer> -> U2<unit, JS.Promise<unit>>
        abstract member webSocketClose: ws: WebSocket * code: float * reason: string * wasClean: bool -> U2<unit, JS.Promise<unit>>
        abstract member webSocketError: ws: WebSocket * error: obj -> U2<unit, JS.Promise<unit>>

    type DurableObject<'Env> =
        DurableObject<'Env, DurableObject>

    type DurableObject =
        DurableObject<Cloudflare.Env, DurableObject>

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type WorkflowDurationLabel =
        | second
        | minute
        | hour
        | day
        | week
        | month
        | year

    type WorkflowSleepDuration =
        U2<string, float>

    type WorkflowDelayDuration =
        WorkflowSleepDuration

    type WorkflowTimeoutDuration =
        WorkflowSleepDuration

    type WorkflowRetentionDuration =
        WorkflowSleepDuration

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type WorkflowBackoff =
        | constant
        | linear
        | exponential

    [<AllowNullLiteral>]
    [<Interface>]
    type WorkflowStepConfig =
        abstract member retries: WorkflowStepConfig.retries option with get, set
        abstract member timeout: U2<WorkflowTimeoutDuration, float> option with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type WorkflowEvent<'T> =
        abstract member payload: WorkflowEvent.payload with get, set
        abstract member timestamp: JS.Date with get, set
        abstract member instanceId: string with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type WorkflowStepEvent<'T> =
        abstract member payload: WorkflowStepEvent.payload with get, set
        abstract member timestamp: JS.Date with get, set
        abstract member ``type``: string with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type WorkflowStepContext =
        abstract member attempt: float with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type WorkflowStep =
        abstract member ``do``: name: string * callback: (WorkflowStepContext -> JS.Promise<'T>) -> JS.Promise<'T>
        abstract member ``do``: name: string * config: WorkflowStepConfig * callback: (WorkflowStepContext -> JS.Promise<'T>) -> JS.Promise<'T>
        abstract member sleep: WorkflowStep.sleep with get, set
        abstract member sleepUntil: WorkflowStep.sleepUntil with get, set
        abstract member waitForEvent: name: string * options: WorkflowStep.waitForEvent.options -> JS.Promise<WorkflowStepEvent<'T>>

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type WorkflowInstanceStatus =
        | queued
        | running
        | paused
        | errored
        | terminated
        | complete
        | waiting
        | waitingForPause
        | unknown

    [<AllowNullLiteral>]
    [<Interface>]
    type WorkflowEntrypoint<'Env> =
        inherit Rpc.WorkflowEntrypointBranded
        abstract member [Rpc___WORKFLOW_ENTRYPOINT_BRAND]: obj with get, set
        abstract member ctx: ExecutionContext with get, set
        abstract member env: 'Env with get, set
        abstract member run: event: WorkflowEntrypoint.run.event * step: WorkflowStep -> JS.Promise<obj>

    type WorkflowEntrypoint =
        WorkflowEntrypoint<obj>

    [<Global>]
    [<AllowNullLiteral>]
    type WorkerEntrypoint
        [<ParamObject; Emit("$0")>]
        (
        ) =

        class end

    [<Global>]
    [<AllowNullLiteral>]
    type DurableObject
        [<ParamObject; Emit("$0")>]
        (
        ) =

        class end

    module WorkflowStepConfig =

        [<Global>]
        [<AllowNullLiteral>]
        type retries
            [<ParamObject; Emit("$0")>]
            (
                limit: float,
                delay: U2<WorkflowDelayDuration, float>,
                ?backoff: WorkflowBackoff
            ) =

            member val limit : float = nativeOnly with get, set
            member val delay : U2<WorkflowDelayDuration, float> = nativeOnly with get, set
            member val backoff : WorkflowBackoff option = nativeOnly with get, set

    module WorkflowEvent =

        [<AllowNullLiteral>]
        [<Interface>]
        type payload =
            interface end

    module WorkflowStepEvent =

        [<AllowNullLiteral>]
        [<Interface>]
        type payload =
            interface end

    module WorkflowStep =

        type sleep =
            delegate of name: string * duration: WorkflowSleepDuration -> JS.Promise<unit>

        type sleepUntil =
            delegate of name: string * timestamp: U2<JS.Date, float> -> JS.Promise<unit>

        module waitForEvent =

            [<Global>]
            [<AllowNullLiteral>]
            type options
                [<ParamObject; Emit("$0")>]
                (
                    ``type``: string,
                    ?timeout: U2<WorkflowTimeoutDuration, float>
                ) =

                member val ``type`` : string = nativeOnly with get, set
                member val timeout : U2<WorkflowTimeoutDuration, float> option = nativeOnly with get, set

    module WorkflowEntrypoint =

        module run =

            [<AllowNullLiteral>]
            [<Interface>]
            type event =
                abstract member payload: WorkflowEntrypoint.run.event.payload with get
                abstract member timestamp: JS.Date with get
                abstract member instanceId: string with get

            module event =

                [<AllowNullLiteral>]
                [<Interface>]
                type payload =
                    interface end

    module Exports =

        [<Global>]
        [<AllowNullLiteral>]
        type RpcStub
            [<ParamObject; Emit("$0")>]
            (
                Create: Rpc.Stub<'T>
            ) =

            member val Create : Rpc.Stub<'T> = nativeOnly

        [<Global>]
        [<AllowNullLiteral>]
        type WorkerEntrypoint
            [<ParamObject; Emit("$0")>]
            (
            ) =

            class end

        [<Global>]
        [<AllowNullLiteral>]
        type DurableObject
            [<ParamObject; Emit("$0")>]
            (
            ) =

            class end

module cloudflare:workers_ =


[<AllowNullLiteral>]
[<Interface>]
type SecretsStoreSecret =
    /// <summary>
    /// Get a secret from the Secrets Store, returning a string of the secret value
    /// if it exists, or throws an error if it does not exist
    /// </summary>
    abstract member get: unit -> JS.Promise<string>

module cloudflare:sockets_ =

    [<AbstractClass>]
    [<Erase>]
    type Exports =
        [<Emit("$0._connect($1...)")>]
        abstract member _connect: address: U2<string, SocketAddress> * ?options: SocketOptions -> Socket


[<AllowNullLiteral>]
[<Interface>]
type MarkdownDocument =
    abstract member name: string with get, set
    abstract member blob: Blob with get, set

[<AllowNullLiteral>]
[<Interface>]
type ConversionResponse =
    abstract member id: string with get, set
    abstract member name: string with get, set
    abstract member mimeType: string with get, set
    abstract member format: string with get, set
    abstract member tokens: float with get, set
    abstract member data: string with get, set
    abstract member id: string with get, set
    abstract member name: string with get, set
    abstract member mimeType: string with get, set
    abstract member format: string with get, set
    abstract member error: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type ImageConversionOptions =
    abstract member descriptionLanguage: ImageConversionOptions.descriptionLanguage option with get, set

[<AllowNullLiteral>]
[<Interface>]
type EmbeddedImageConversionOptions =
    abstract member descriptionLanguage: EmbeddedImageConversionOptions.descriptionLanguage option with get, set
    abstract member convert: bool option with get, set
    abstract member maxConvertedImages: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type ConversionOptions =
    abstract member html: ConversionOptions.html option with get, set
    abstract member docx: ConversionOptions.docx option with get, set
    abstract member image: ImageConversionOptions option with get, set
    abstract member pdf: ConversionOptions.pdf option with get, set

[<AllowNullLiteral>]
[<Interface>]
type ConversionRequestOptions =
    abstract member gateway: GatewayOptions option with get, set
    abstract member extraHeaders: obj option with get, set
    abstract member conversionOptions: ConversionOptions option with get, set

[<AllowNullLiteral>]
[<Interface>]
type SupportedFileFormat =
    abstract member mimeType: string with get, set
    abstract member extension: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type ToMarkdownService =
    abstract member transform: files: ResizeArray<MarkdownDocument> * ?options: ConversionRequestOptions -> JS.Promise<ResizeArray<ConversionResponse>>
    abstract member transform: files: MarkdownDocument * ?options: ConversionRequestOptions -> JS.Promise<ConversionResponse>
    abstract member supported: unit -> JS.Promise<ResizeArray<SupportedFileFormat>>

module TailStream_ =

    [<AllowNullLiteral>]
    [<Interface>]
    type Header =
        abstract member name: string with get
        abstract member value: string with get

    [<AllowNullLiteral>]
    [<Interface>]
    type FetchEventInfo =
        abstract member ``type``: string with get
        abstract member ``method``: string with get
        abstract member url: string with get
        abstract member cfJson: obj option with get
        abstract member headers: ResizeArray<Header> with get

    [<AllowNullLiteral>]
    [<Interface>]
    type JsRpcEventInfo =
        abstract member ``type``: string with get

    [<AllowNullLiteral>]
    [<Interface>]
    type ScheduledEventInfo =
        abstract member ``type``: string with get
        abstract member scheduledTime: JS.Date with get
        abstract member cron: string with get

    [<AllowNullLiteral>]
    [<Interface>]
    type AlarmEventInfo =
        abstract member ``type``: string with get
        abstract member scheduledTime: JS.Date with get

    [<AllowNullLiteral>]
    [<Interface>]
    type QueueEventInfo =
        abstract member ``type``: string with get
        abstract member queueName: string with get
        abstract member batchSize: float with get

    [<AllowNullLiteral>]
    [<Interface>]
    type EmailEventInfo =
        abstract member ``type``: string with get
        abstract member mailFrom: string with get
        abstract member rcptTo: string with get
        abstract member rawSize: float with get

    [<AllowNullLiteral>]
    [<Interface>]
    type TraceEventInfo =
        abstract member ``type``: string with get
        abstract member traces: ResizeArray<U2<string, obj>> with get

    [<AllowNullLiteral>]
    [<Interface>]
    type HibernatableWebSocketEventInfoMessage =
        abstract member ``type``: string with get

    [<AllowNullLiteral>]
    [<Interface>]
    type HibernatableWebSocketEventInfoError =
        abstract member ``type``: string with get

    [<AllowNullLiteral>]
    [<Interface>]
    type HibernatableWebSocketEventInfoClose =
        abstract member ``type``: string with get
        abstract member code: float with get
        abstract member wasClean: bool with get

    [<AllowNullLiteral>]
    [<Interface>]
    type HibernatableWebSocketEventInfo =
        abstract member ``type``: string with get
        abstract member info: U3<HibernatableWebSocketEventInfoClose, HibernatableWebSocketEventInfoError, HibernatableWebSocketEventInfoMessage> with get

    [<AllowNullLiteral>]
    [<Interface>]
    type CustomEventInfo =
        abstract member ``type``: string with get

    [<AllowNullLiteral>]
    [<Interface>]
    type FetchResponseInfo =
        abstract member ``type``: string with get
        abstract member statusCode: float with get

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type EventOutcome =
        | ok
        | canceled
        | ``exception``
        | unknown
        | killSwitch
        | daemonDown
        | exceededCpu
        | exceededMemory
        | loadShed
        | responseStreamDisconnected
        | scriptNotFound

    [<AllowNullLiteral>]
    [<Interface>]
    type ScriptVersion =
        abstract member id: string with get
        abstract member tag: string option with get
        abstract member message: string option with get

    [<AllowNullLiteral>]
    [<Interface>]
    type Onset =
        abstract member ``type``: string with get
        abstract member attributes: ResizeArray<Attribute> with get
        abstract member spanId: string with get
        abstract member dispatchNamespace: string option with get
        abstract member entrypoint: string option with get
        abstract member executionModel: string with get
        abstract member scriptName: string option with get
        abstract member scriptTags: ResizeArray<string> option with get
        abstract member scriptVersion: ScriptVersion option with get
        abstract member info: U9<FetchEventInfo, JsRpcEventInfo, ScheduledEventInfo, AlarmEventInfo, QueueEventInfo, EmailEventInfo, TraceEventInfo, HibernatableWebSocketEventInfo, CustomEventInfo> with get

    [<AllowNullLiteral>]
    [<Interface>]
    type Outcome =
        abstract member ``type``: string with get
        abstract member outcome: EventOutcome with get
        abstract member cpuTime: float with get
        abstract member wallTime: float with get

    [<AllowNullLiteral>]
    [<Interface>]
    type SpanOpen =
        abstract member ``type``: string with get
        abstract member name: string with get
        abstract member spanId: string with get
        abstract member info: U3<FetchEventInfo, JsRpcEventInfo, Attributes> option with get

    [<AllowNullLiteral>]
    [<Interface>]
    type SpanClose =
        abstract member ``type``: string with get
        abstract member outcome: EventOutcome with get

    [<AllowNullLiteral>]
    [<Interface>]
    type DiagnosticChannelEvent =
        abstract member ``type``: string with get
        abstract member channel: string with get
        abstract member message: obj with get

    [<AllowNullLiteral>]
    [<Interface>]
    type Exception =
        abstract member ``type``: string with get
        abstract member name: string with get
        abstract member message: string with get
        abstract member stack: string option with get

    [<AllowNullLiteral>]
    [<Interface>]
    type Log =
        abstract member ``type``: string with get
        abstract member level: Log.level with get
        abstract member message: obj with get

    [<AllowNullLiteral>]
    [<Interface>]
    type DroppedEventsDiagnostic =
        abstract member diagnosticsType: string with get
        abstract member count: float with get

    [<AllowNullLiteral>]
    [<Interface>]
    type StreamDiagnostic =
        abstract member ``type``: string with get
        abstract member diagnostic: DroppedEventsDiagnostic with get

    [<AllowNullLiteral>]
    [<Interface>]
    type Return =
        abstract member ``type``: string with get
        abstract member info: FetchResponseInfo option with get

    [<AllowNullLiteral>]
    [<Interface>]
    type Attribute =
        abstract member name: string with get
        abstract member value: U8<string, ResizeArray<string>, bool, ResizeArray<bool>, float, ResizeArray<float>, obj, ResizeArray<obj>> with get

    [<AllowNullLiteral>]
    [<Interface>]
    type Attributes =
        abstract member ``type``: string with get
        abstract member info: ResizeArray<Attribute> with get

    type EventType =
        U10<Onset, Outcome, SpanOpen, SpanClose, DiagnosticChannelEvent, Exception, Log, StreamDiagnostic, Return, Attributes>

    [<AllowNullLiteral>]
    [<Interface>]
    type SpanContext =
        abstract member traceId: string with get
        abstract member spanId: string option with get

    [<AllowNullLiteral>]
    [<Interface>]
    type TailEvent<'Event when 'Event :> EventType> =
        abstract member invocationId: string with get
        abstract member spanContext: SpanContext with get
        abstract member timestamp: JS.Date with get
        abstract member sequence: float with get
        abstract member event: 'Event with get

    [<AllowNullLiteral>]
    [<Interface>]
    type TailEventHandler<'Event when 'Event :> EventType> =
        [<Emit("$0($1...)")>]
        abstract member Invoke: event: TailEvent<'Event> -> U2<unit, JS.Promise<unit>>

    [<AllowNullLiteral>]
    [<Interface>]
    type TailEventHandlerObject =
        abstract member outcome: TailEventHandler<Outcome> option with get, set
        abstract member spanOpen: TailEventHandler<SpanOpen> option with get, set
        abstract member spanClose: TailEventHandler<SpanClose> option with get, set
        abstract member diagnosticChannel: TailEventHandler<DiagnosticChannelEvent> option with get, set
        abstract member ``exception``: TailEventHandler<Exception> option with get, set
        abstract member log: TailEventHandler<Log> option with get, set
        abstract member ``return``: TailEventHandler<Return> option with get, set
        abstract member attributes: TailEventHandler<Attributes> option with get, set

    type TailEventHandlerType =
        U2<TailEventHandler, TailEventHandlerObject>

    module Log =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type level =
            | debug
            | error
            | info
            | log
            | warn

/// <summary>
/// Data types supported for holding vector metadata.
/// </summary>
type VectorizeVectorMetadataValue =
    U4<string, float, bool, ResizeArray<string>>

/// <summary>
/// Additional information to associate with a vector.
/// </summary>
type VectorizeVectorMetadata =
    U2<VectorizeVectorMetadataValue, VectorizeVectorMetadata.U2.Case2>

type VectorFloatArray =
    U2<JS.Float32Array, JS.Float64Array>

[<AllowNullLiteral>]
[<Interface>]
type VectorizeError =
    abstract member code: float option with get, set
    abstract member error: string with get, set

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type VectorizeVectorMetadataFilterOp =
    | ``$eq``
    | ``$ne``
    | ``$lt``
    | ``$lte``
    | ``$gt``
    | ``$gte``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type VectorizeVectorMetadataFilterCollectionOp =
    | ``$in``
    | ``$nin``

[<AllowNullLiteral>]
[<Interface>]
type VectorizeVectorMetadataFilter =
    [<EmitIndexer>]
    abstract member Item: field: string -> U4<VectorizeVectorMetadataFilter.Item.U4.Case1, obj, obj, obj> with get, set

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type VectorizeDistanceMetric =
    | euclidean
    | cosine
    | ``dot-product``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type VectorizeMetadataRetrievalLevel =
    | all
    | indexed
    | none

[<AllowNullLiteral>]
[<Interface>]
type VectorizeQueryOptions =
    abstract member topK: float option with get, set
    abstract member ``namespace``: string option with get, set
    abstract member returnValues: bool option with get, set
    abstract member returnMetadata: U2<bool, VectorizeMetadataRetrievalLevel> option with get, set
    abstract member filter: VectorizeVectorMetadataFilter option with get, set

[<AllowNullLiteral>]
[<Interface>]
type VectorizeIndexConfig =
    abstract member dimensions: float with get, set
    abstract member metric: VectorizeDistanceMetric with get, set
    abstract member preset: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type VectorizeIndexDetails =
    /// <summary>
    /// The unique ID of the index
    /// </summary>
    abstract member id: string with get
    /// <summary>
    /// The name of the index.
    /// </summary>
    abstract member name: string with get, set
    /// <summary>
    /// (optional) A human readable description for the index.
    /// </summary>
    abstract member description: string option with get, set
    /// <summary>
    /// The index configuration, including the dimension size and distance metric.
    /// </summary>
    abstract member config: VectorizeIndexConfig with get, set
    /// <summary>
    /// The number of records containing vectors within the index.
    /// </summary>
    abstract member vectorsCount: float with get, set

[<AllowNullLiteral>]
[<Interface>]
type VectorizeIndexInfo =
    /// <summary>
    /// The number of records containing vectors within the index.
    /// </summary>
    abstract member vectorCount: float with get, set
    /// <summary>
    /// Number of dimensions the index has been configured for.
    /// </summary>
    abstract member dimensions: float with get, set
    /// <summary>
    /// ISO 8601 datetime of the last processed mutation on in the index. All changes before this mutation will be reflected in the index state.
    /// </summary>
    abstract member processedUpToDatetime: float with get, set
    /// <summary>
    /// UUIDv4 of the last mutation processed by the index. All changes before this mutation will be reflected in the index state.
    /// </summary>
    abstract member processedUpToMutation: float with get, set

[<AllowNullLiteral>]
[<Interface>]
type VectorizeVector =
    /// <summary>
    /// The ID for the vector. This can be user-defined, and must be unique. It should uniquely identify the object, and is best set based on the ID of what the vector represents.
    /// </summary>
    abstract member id: string with get, set
    /// <summary>
    /// The vector values
    /// </summary>
    abstract member values: U2<VectorFloatArray, ResizeArray<float>> with get, set
    /// <summary>
    /// The namespace this vector belongs to.
    /// </summary>
    abstract member ``namespace``: string option with get, set
    /// <summary>
    /// Metadata associated with the vector. Includes the values of other fields and potentially additional details.
    /// </summary>
    abstract member metadata: VectorizeVector.metadata option with get, set

[<AllowNullLiteral>]
[<Interface>]
type VectorizeMatch =
    /// <summary>
    /// The vector values
    /// </summary>
    abstract member values: U2<VectorFloatArray, ResizeArray<float>> with get, set
    /// <summary>
    /// The ID for the vector. This can be user-defined, and must be unique. It should uniquely identify the object, and is best set based on the ID of what the vector represents.
    /// </summary>
    abstract member id: string with get, set
    /// <summary>
    /// The namespace this vector belongs to.
    /// </summary>
    abstract member ``namespace``: string option with get, set
    /// <summary>
    /// Metadata associated with the vector. Includes the values of other fields and potentially additional details.
    /// </summary>
    abstract member metadata: VectorizeMatch.metadata option with get, set
    /// <summary>
    /// The score or rank for similarity, when returned as a result
    /// </summary>
    abstract member score: float with get, set

[<AllowNullLiteral>]
[<Interface>]
type VectorizeMatches =
    abstract member matches: ResizeArray<VectorizeMatch> with get, set
    abstract member count: float with get, set

[<AllowNullLiteral>]
[<Interface>]
type VectorizeVectorMutation =
    abstract member ids: ResizeArray<string> with get, set
    abstract member count: float with get, set

[<AllowNullLiteral>]
[<Interface>]
type VectorizeAsyncMutation =
    /// <summary>
    /// The unique identifier for the async mutation operation containing the changeset.
    /// </summary>
    abstract member mutationId: string with get, set

/// <summary>
/// A Vectorize Vector Search Index for querying vectors/embeddings.
///
/// This type is exclusively for the Vectorize **beta** and will be deprecated once Vectorize RC is released.
/// See <see href="Vectorize">Vectorize</see> for its new implementation.
/// </summary>
[<AllowNullLiteral>]
[<Interface>]
type VectorizeIndex =
    /// <summary>
    /// Get information about the currently bound index.
    /// </summary>
    /// <returns>
    /// A promise that resolves with information about the current index.
    /// </returns>
    abstract member describe: unit -> JS.Promise<VectorizeIndexDetails>
    /// <summary>
    /// Use the provided vector to perform a similarity search across the index.
    /// </summary>
    /// <param name="vector">
    /// Input vector that will be used to drive the similarity search.
    /// </param>
    /// <param name="options">
    /// Configuration options to massage the returned data.
    /// </param>
    /// <returns>
    /// A promise that resolves with matched and scored vectors.
    /// </returns>
    abstract member query: vector: U2<VectorFloatArray, ResizeArray<float>> * ?options: VectorizeQueryOptions -> JS.Promise<VectorizeMatches>
    /// <summary>
    /// Insert a list of vectors into the index dataset. If a provided id exists, an error will be thrown.
    /// </summary>
    /// <param name="vectors">
    /// List of vectors that will be inserted.
    /// </param>
    /// <returns>
    /// A promise that resolves with the ids & count of records that were successfully processed.
    /// </returns>
    abstract member insert: vectors: ResizeArray<VectorizeVector> -> JS.Promise<VectorizeVectorMutation>
    /// <summary>
    /// Upsert a list of vectors into the index dataset. If a provided id exists, it will be replaced with the new values.
    /// </summary>
    /// <param name="vectors">
    /// List of vectors that will be upserted.
    /// </param>
    /// <returns>
    /// A promise that resolves with the ids & count of records that were successfully processed.
    /// </returns>
    abstract member upsert: vectors: ResizeArray<VectorizeVector> -> JS.Promise<VectorizeVectorMutation>
    /// <summary>
    /// Delete a list of vectors with a matching id.
    /// </summary>
    /// <param name="ids">
    /// List of vector ids that should be deleted.
    /// </param>
    /// <returns>
    /// A promise that resolves with the ids & count of records that were successfully processed (and thus deleted).
    /// </returns>
    abstract member deleteByIds: ids: ResizeArray<string> -> JS.Promise<VectorizeVectorMutation>
    /// <summary>
    /// Get a list of vectors with a matching id.
    /// </summary>
    /// <param name="ids">
    /// List of vector ids that should be returned.
    /// </param>
    /// <returns>
    /// A promise that resolves with the raw unscored vectors matching the id set.
    /// </returns>
    abstract member getByIds: ids: ResizeArray<string> -> JS.Promise<ResizeArray<VectorizeVector>>

/// <summary>
/// A Vectorize Vector Search Index for querying vectors/embeddings.
///
/// Mutations in this version are async, returning a mutation id.
/// </summary>
[<AllowNullLiteral>]
[<Interface>]
type Vectorize =
    /// <summary>
    /// Get information about the currently bound index.
    /// </summary>
    /// <returns>
    /// A promise that resolves with information about the current index.
    /// </returns>
    abstract member describe: unit -> JS.Promise<VectorizeIndexInfo>
    /// <summary>
    /// Use the provided vector to perform a similarity search across the index.
    /// </summary>
    /// <param name="vector">
    /// Input vector that will be used to drive the similarity search.
    /// </param>
    /// <param name="options">
    /// Configuration options to massage the returned data.
    /// </param>
    /// <returns>
    /// A promise that resolves with matched and scored vectors.
    /// </returns>
    abstract member query: vector: U2<VectorFloatArray, ResizeArray<float>> * ?options: VectorizeQueryOptions -> JS.Promise<VectorizeMatches>
    /// <summary>
    /// Use the provided vector-id to perform a similarity search across the index.
    /// </summary>
    /// <param name="vectorId">
    /// Id for a vector in the index against which the index should be queried.
    /// </param>
    /// <param name="options">
    /// Configuration options to massage the returned data.
    /// </param>
    /// <returns>
    /// A promise that resolves with matched and scored vectors.
    /// </returns>
    abstract member queryById: vectorId: string * ?options: VectorizeQueryOptions -> JS.Promise<VectorizeMatches>
    /// <summary>
    /// Insert a list of vectors into the index dataset. If a provided id exists, an error will be thrown.
    /// </summary>
    /// <param name="vectors">
    /// List of vectors that will be inserted.
    /// </param>
    /// <returns>
    /// A promise that resolves with a unique identifier of a mutation containing the insert changeset.
    /// </returns>
    abstract member insert: vectors: ResizeArray<VectorizeVector> -> JS.Promise<VectorizeAsyncMutation>
    /// <summary>
    /// Upsert a list of vectors into the index dataset. If a provided id exists, it will be replaced with the new values.
    /// </summary>
    /// <param name="vectors">
    /// List of vectors that will be upserted.
    /// </param>
    /// <returns>
    /// A promise that resolves with a unique identifier of a mutation containing the upsert changeset.
    /// </returns>
    abstract member upsert: vectors: ResizeArray<VectorizeVector> -> JS.Promise<VectorizeAsyncMutation>
    /// <summary>
    /// Delete a list of vectors with a matching id.
    /// </summary>
    /// <param name="ids">
    /// List of vector ids that should be deleted.
    /// </param>
    /// <returns>
    /// A promise that resolves with a unique identifier of a mutation containing the delete changeset.
    /// </returns>
    abstract member deleteByIds: ids: ResizeArray<string> -> JS.Promise<VectorizeAsyncMutation>
    /// <summary>
    /// Get a list of vectors with a matching id.
    /// </summary>
    /// <param name="ids">
    /// List of vector ids that should be returned.
    /// </param>
    /// <returns>
    /// A promise that resolves with the raw unscored vectors matching the id set.
    /// </returns>
    abstract member getByIds: ids: ResizeArray<string> -> JS.Promise<ResizeArray<VectorizeVector>>

[<AllowNullLiteral>]
[<Interface>]
type WorkerVersionMetadata =
    /// <summary>
    /// The ID of the Worker Version using this binding
    /// </summary>
    abstract member id: string with get, set
    /// <summary>
    /// The tag of the Worker Version using this binding
    /// </summary>
    abstract member tag: string with get, set
    /// <summary>
    /// The timestamp of when the Worker Version was uploaded
    /// </summary>
    abstract member timestamp: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type DynamicDispatchLimits =
    /// <summary>
    /// Limit CPU time in milliseconds.
    /// </summary>
    abstract member cpuMs: float option with get, set
    /// <summary>
    /// Limit number of subrequests.
    /// </summary>
    abstract member subRequests: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type DynamicDispatchOptions =
    /// <summary>
    /// Limit resources of invoked Worker script.
    /// </summary>
    abstract member limits: DynamicDispatchLimits option with get, set
    /// <summary>
    /// Arguments for outbound Worker script, if configured.
    /// </summary>
    abstract member outbound: DynamicDispatchOptions.outbound option with get, set

[<AllowNullLiteral>]
[<Interface>]
type DispatchNamespace =
    abstract member get: name: string * ?args: DispatchNamespace.get.args * ?options: DynamicDispatchOptions -> Fetcher

module cloudflare:workflows_ =

    [<AbstractClass>]
    [<Erase>]
    type Exports =
        [<Emit("new $0.NonRetryableError($1...)")>]
        abstract member NonRetryableError: message: string * ?name: string -> NonRetryableError

    /// <summary>
    /// NonRetryableError allows for a user to throw a fatal error
    /// that makes a Workflow instance fail immediately without triggering a retry
    /// </summary>
    [<AllowNullLiteral>]
    [<AbstractClass>]
    type NonRetryableError =
        inherit Exception

[<AllowNullLiteral>]
[<Interface>]
type Workflow<'PARAMS> =
    /// <summary>
    /// Get a handle to an existing instance of the Workflow.
    /// </summary>
    /// <param name="id">
    /// Id for the instance of this Workflow
    /// </param>
    /// <returns>
    /// A promise that resolves with a handle for the Instance
    /// </returns>
    abstract member get: id: string -> JS.Promise<WorkflowInstance>
    /// <summary>
    /// Create a new instance and return a handle to it. If a provided id exists, an error will be thrown.
    /// </summary>
    /// <param name="options">
    /// Options when creating an instance including id and params
    /// </param>
    /// <returns>
    /// A promise that resolves with a handle for the Instance
    /// </returns>
    abstract member create: ?options: WorkflowInstanceCreateOptions<'PARAMS> -> JS.Promise<WorkflowInstance>
    /// <summary>
    /// Create a batch of instances and return handle for all of them. If a provided id exists, an error will be thrown.
    /// <c>createBatch</c> is limited at 100 instances at a time or when the RPC limit for the batch (1MiB) is reached.
    /// </summary>
    /// <param name="batch">
    /// List of Options when creating an instance including name and params
    /// </param>
    /// <returns>
    /// A promise that resolves with a list of handles for the created instances.
    /// </returns>
    abstract member createBatch: batch: ResizeArray<WorkflowInstanceCreateOptions<'PARAMS>> -> JS.Promise<ResizeArray<WorkflowInstance>>

type Workflow =
    Workflow<obj>

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type WorkflowDurationLabel =
    | second
    | minute
    | hour
    | day
    | week
    | month
    | year

type WorkflowSleepDuration =
    U2<string, float>

type WorkflowRetentionDuration =
    WorkflowSleepDuration

[<AllowNullLiteral>]
[<Interface>]
type WorkflowInstanceCreateOptions<'PARAMS> =
    /// <summary>
    /// An id for your Workflow instance. Must be unique within the Workflow.
    /// </summary>
    abstract member id: string option with get, set
    /// <summary>
    /// The event payload the Workflow instance is triggered with
    /// </summary>
    abstract member ``params``: 'PARAMS option with get, set
    /// <summary>
    /// The retention policy for Workflow instance.
    /// Defaults to the maximum retention period available for the owner's account.
    /// </summary>
    abstract member retention: WorkflowInstanceCreateOptions.retention option with get, set

[<AllowNullLiteral>]
[<Interface>]
type InstanceStatus =
    abstract member status: InstanceStatus.status with get, set
    abstract member error: InstanceStatus.error option with get, set
    abstract member output: obj option with get, set

[<AllowNullLiteral>]
[<Interface>]
type WorkflowError =
    abstract member code: float option with get, set
    abstract member message: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type WorkflowInstance =
    abstract member id: string with get, set
    /// <summary>
    /// Pause the instance.
    /// </summary>
    abstract member pause: unit -> JS.Promise<unit>
    /// <summary>
    /// Resume the instance. If it is already running, an error will be thrown.
    /// </summary>
    abstract member resume: unit -> JS.Promise<unit>
    /// <summary>
    /// Terminate the instance. If it is errored, terminated or complete, an error will be thrown.
    /// </summary>
    abstract member terminate: unit -> JS.Promise<unit>
    /// <summary>
    /// Restart the instance.
    /// </summary>
    abstract member restart: unit -> JS.Promise<unit>
    /// <summary>
    /// Returns the current status of the instance.
    /// </summary>
    abstract member status: unit -> JS.Promise<InstanceStatus>
    /// <summary>
    /// Send an event to this instance.
    /// </summary>
    abstract member sendEvent: arg0: WorkflowInstance.sendEvent.arg0 -> JS.Promise<unit>

type ExecutionContext =
    ExecutionContext<obj>

type ExportedHandler<'Env, 'QueueHandlerMessage> =
    ExportedHandler<'Env, 'QueueHandlerMessage, obj>

type ExportedHandler<'Env> =
    ExportedHandler<'Env, obj, obj>

type ExportedHandler =
    ExportedHandler<obj, obj, obj>

type DurableObjectClass =
    DurableObjectClass<obj>

type DurableObjectState =
    DurableObjectState<obj>

type EventListenerObject =
    EventListenerObject<Event>

[<AllowNullLiteral>]
[<Interface>]
type EventTarget_1 =
    [<EmitIndexer>]
    abstract member Item: key: string -> Event with get, set

type Request<'CfHostMetadata> =
    Request<'CfHostMetadata, CfProperties<'CfHostMetadata>>

type Request =
    Request<obj, CfProperties<'CfHostMetadata>>

type RequestInit =
    RequestInit<CfProperties>

type Queue =
    Queue<obj>

type MessageSendRequest =
    MessageSendRequest<obj>

type Message =
    Message<obj>

type QueueEvent =
    QueueEvent<obj>

type MessageBatch =
    MessageBatch<obj>

type QueuingStrategy =
    QueuingStrategy<obj>

type UnderlyingSink =
    UnderlyingSink<obj>

type UnderlyingSource =
    UnderlyingSource<obj>

type Transformer<'I> =
    Transformer<'I, obj>

type Transformer =
    Transformer<obj, obj>

type ReadableStream =
    ReadableStream<obj>

type ReadableStreamDefaultController =
    ReadableStreamDefaultController<obj>

type TransformStreamDefaultController =
    TransformStreamDefaultController<obj>

type ReadableWritablePair<'R> =
    ReadableWritablePair<'R, obj>

type ReadableWritablePair =
    ReadableWritablePair<obj, obj>

[<Global>]
[<AllowNullLiteral>]
type AiImageClassificationOutput
    [<ParamObject; Emit("$0")>]
    (
        ?score: float,
        ?label: string
    ) =

    member val score : float option = nativeOnly with get, set
    member val label : string option = nativeOnly with get, set

[<Global>]
[<AllowNullLiteral>]
type AiObjectDetectionOutput
    [<ParamObject; Emit("$0")>]
    (
        ?score: float,
        ?label: string
    ) =

    member val score : float option = nativeOnly with get, set
    member val label : string option = nativeOnly with get, set

[<Global>]
[<AllowNullLiteral>]
type AiTextClassificationOutput
    [<ParamObject; Emit("$0")>]
    (
        ?score: float,
        ?label: string
    ) =

    member val score : float option = nativeOnly with get, set
    member val label : string option = nativeOnly with get, set

[<Global>]
[<AllowNullLiteral>]
type AutoRagListResponse
    [<ParamObject; Emit("$0")>]
    (
        id: string,
        enable: bool,
        ``type``: string,
        source: string,
        vectorize_name: string,
        paused: bool,
        status: string
    ) =

    member val id : string = nativeOnly with get, set
    member val enable : bool = nativeOnly with get, set
    member val ``type`` : string = nativeOnly with get, set
    member val source : string = nativeOnly with get, set
    member val vectorize_name : string = nativeOnly with get, set
    member val paused : bool = nativeOnly with get, set
    member val status : string = nativeOnly with get, set

[<AllowNullLiteral>]
[<Interface>]
type PagesFunction_1 =
    [<EmitIndexer>]
    abstract member Item: key: string -> obj with get, set

[<AllowNullLiteral>]
[<Interface>]
type PagesPluginFunction_1 =
    [<EmitIndexer>]
    abstract member Item: key: string -> obj with get, set

type WorkflowInstanceCreateOptions =
    WorkflowInstanceCreateOptions<obj>

module WorkerGlobalScope =

    [<Global>]
    [<AllowNullLiteral>]
    type EventTarget
        [<ParamObject; Emit("$0")>]
        (
            prototype: EventTarget,
            Create: EventTarget
        ) =

        member val prototype : EventTarget = nativeOnly with get, set
        member val Create : EventTarget = nativeOnly

module ServiceWorkerGlobalScope =

    [<Global>]
    [<AllowNullLiteral>]
    type DOMException
        [<ParamObject; Emit("$0")>]
        (
            prototype: DOMException,
            Create: DOMException,
            INDEX_SIZE_ERR: int,
            DOMSTRING_SIZE_ERR: int,
            HIERARCHY_REQUEST_ERR: int,
            WRONG_DOCUMENT_ERR: int,
            INVALID_CHARACTER_ERR: int,
            NO_DATA_ALLOWED_ERR: int,
            NO_MODIFICATION_ALLOWED_ERR: int,
            NOT_FOUND_ERR: int,
            NOT_SUPPORTED_ERR: int,
            INUSE_ATTRIBUTE_ERR: int,
            INVALID_STATE_ERR: int,
            SYNTAX_ERR: int,
            INVALID_MODIFICATION_ERR: int,
            NAMESPACE_ERR: int,
            INVALID_ACCESS_ERR: int,
            VALIDATION_ERR: int,
            TYPE_MISMATCH_ERR: int,
            SECURITY_ERR: int,
            NETWORK_ERR: int,
            ABORT_ERR: int,
            URL_MISMATCH_ERR: int,
            QUOTA_EXCEEDED_ERR: int,
            TIMEOUT_ERR: int,
            INVALID_NODE_TYPE_ERR: int,
            DATA_CLONE_ERR: int
        ) =

        member val prototype : DOMException = nativeOnly with get, set
        member val Create : DOMException = nativeOnly
        member val INDEX_SIZE_ERR : int = nativeOnly with get
        member val DOMSTRING_SIZE_ERR : int = nativeOnly with get
        member val HIERARCHY_REQUEST_ERR : int = nativeOnly with get
        member val WRONG_DOCUMENT_ERR : int = nativeOnly with get
        member val INVALID_CHARACTER_ERR : int = nativeOnly with get
        member val NO_DATA_ALLOWED_ERR : int = nativeOnly with get
        member val NO_MODIFICATION_ALLOWED_ERR : int = nativeOnly with get
        member val NOT_FOUND_ERR : int = nativeOnly with get
        member val NOT_SUPPORTED_ERR : int = nativeOnly with get
        member val INUSE_ATTRIBUTE_ERR : int = nativeOnly with get
        member val INVALID_STATE_ERR : int = nativeOnly with get
        member val SYNTAX_ERR : int = nativeOnly with get
        member val INVALID_MODIFICATION_ERR : int = nativeOnly with get
        member val NAMESPACE_ERR : int = nativeOnly with get
        member val INVALID_ACCESS_ERR : int = nativeOnly with get
        member val VALIDATION_ERR : int = nativeOnly with get
        member val TYPE_MISMATCH_ERR : int = nativeOnly with get
        member val SECURITY_ERR : int = nativeOnly with get
        member val NETWORK_ERR : int = nativeOnly with get
        member val ABORT_ERR : int = nativeOnly with get
        member val URL_MISMATCH_ERR : int = nativeOnly with get
        member val QUOTA_EXCEEDED_ERR : int = nativeOnly with get
        member val TIMEOUT_ERR : int = nativeOnly with get
        member val INVALID_NODE_TYPE_ERR : int = nativeOnly with get
        member val DATA_CLONE_ERR : int = nativeOnly with get

    [<Global>]
    [<AllowNullLiteral>]
    type Event
        [<ParamObject; Emit("$0")>]
        (
            prototype: Event,
            Create: Event,
            NONE: int,
            CAPTURING_PHASE: int,
            AT_TARGET: int,
            BUBBLING_PHASE: int
        ) =

        member val prototype : Event = nativeOnly with get, set
        member val Create : Event = nativeOnly
        member val NONE : int = nativeOnly with get
        member val CAPTURING_PHASE : int = nativeOnly with get
        member val AT_TARGET : int = nativeOnly with get
        member val BUBBLING_PHASE : int = nativeOnly with get

    [<Global>]
    [<AllowNullLiteral>]
    type CustomEvent
        [<ParamObject; Emit("$0")>]
        (
            prototype: CustomEvent,
            Create: CustomEvent<'T>
        ) =

        member val prototype : CustomEvent = nativeOnly with get, set
        member val Create : CustomEvent<'T> = nativeOnly

    [<Global>]
    [<AllowNullLiteral>]
    type PromiseRejectionEvent
        [<ParamObject; Emit("$0")>]
        (
            prototype: PromiseRejectionEvent,
            Create: PromiseRejectionEvent
        ) =

        member val prototype : PromiseRejectionEvent = nativeOnly with get, set
        member val Create : PromiseRejectionEvent = nativeOnly

    [<Global>]
    [<AllowNullLiteral>]
    type MessageEvent
        [<ParamObject; Emit("$0")>]
        (
            prototype: MessageEvent,
            Create: MessageEvent<'T>
        ) =

        member val prototype : MessageEvent = nativeOnly with get, set
        member val Create : MessageEvent<'T> = nativeOnly

    [<Global>]
    [<AllowNullLiteral>]
    type CloseEvent
        [<ParamObject; Emit("$0")>]
        (
            prototype: CloseEvent,
            Create: CloseEvent
        ) =

        member val prototype : CloseEvent = nativeOnly with get, set
        member val Create : CloseEvent = nativeOnly

    [<Global>]
    [<AllowNullLiteral>]
    type ReadableStreamDefaultReader
        [<ParamObject; Emit("$0")>]
        (
            prototype: ReadableStreamDefaultReader,
            Create: ReadableStreamDefaultReader<'R>
        ) =

        member val prototype : ReadableStreamDefaultReader = nativeOnly with get, set
        member val Create : ReadableStreamDefaultReader<'R> = nativeOnly

    [<Global>]
    [<AllowNullLiteral>]
    type ReadableStreamBYOBReader
        [<ParamObject; Emit("$0")>]
        (
            prototype: ReadableStreamBYOBReader,
            Create: ReadableStreamBYOBReader
        ) =

        member val prototype : ReadableStreamBYOBReader = nativeOnly with get, set
        member val Create : ReadableStreamBYOBReader = nativeOnly

    [<Global>]
    [<AllowNullLiteral>]
    type ReadableStream
        [<ParamObject; Emit("$0")>]
        (
            prototype: ReadableStream,
            Create: ReadableStream<JS.Uint8Array>,
            Create: ReadableStream<'R>,
            Create: ReadableStream<'R>
        ) =

        member val prototype : ReadableStream = nativeOnly with get, set
        member val Create : ReadableStream<JS.Uint8Array> = nativeOnly
        member val Create : ReadableStream<'R> = nativeOnly
        member val Create : ReadableStream<'R> = nativeOnly

    [<Global>]
    [<AllowNullLiteral>]
    type WritableStream
        [<ParamObject; Emit("$0")>]
        (
            prototype: WritableStream,
            Create: WritableStream<'W>
        ) =

        member val prototype : WritableStream = nativeOnly with get, set
        member val Create : WritableStream<'W> = nativeOnly

    [<Global>]
    [<AllowNullLiteral>]
    type WritableStreamDefaultWriter
        [<ParamObject; Emit("$0")>]
        (
            prototype: WritableStreamDefaultWriter,
            Create: WritableStreamDefaultWriter<'W>
        ) =

        member val prototype : WritableStreamDefaultWriter = nativeOnly with get, set
        member val Create : WritableStreamDefaultWriter<'W> = nativeOnly

    [<Global>]
    [<AllowNullLiteral>]
    type TransformStream
        [<ParamObject; Emit("$0")>]
        (
            prototype: TransformStream,
            Create: TransformStream<'I, 'O>
        ) =

        member val prototype : TransformStream = nativeOnly with get, set
        member val Create : TransformStream<'I, 'O> = nativeOnly

    [<Global>]
    [<AllowNullLiteral>]
    type ByteLengthQueuingStrategy
        [<ParamObject; Emit("$0")>]
        (
            prototype: ByteLengthQueuingStrategy,
            Create: ByteLengthQueuingStrategy
        ) =

        member val prototype : ByteLengthQueuingStrategy = nativeOnly with get, set
        member val Create : ByteLengthQueuingStrategy = nativeOnly

    [<Global>]
    [<AllowNullLiteral>]
    type CountQueuingStrategy
        [<ParamObject; Emit("$0")>]
        (
            prototype: CountQueuingStrategy,
            Create: CountQueuingStrategy
        ) =

        member val prototype : CountQueuingStrategy = nativeOnly with get, set
        member val Create : CountQueuingStrategy = nativeOnly

    [<Global>]
    [<AllowNullLiteral>]
    type ErrorEvent
        [<ParamObject; Emit("$0")>]
        (
            prototype: ErrorEvent,
            Create: ErrorEvent
        ) =

        member val prototype : ErrorEvent = nativeOnly with get, set
        member val Create : ErrorEvent = nativeOnly

    [<Global>]
    [<AllowNullLiteral>]
    type EventSource
        [<ParamObject; Emit("$0")>]
        (
            prototype: EventSource,
            Create: EventSource,
            CONNECTING: int,
            OPEN: int,
            CLOSED: int
        ) =

        member val prototype : EventSource = nativeOnly with get, set
        member val Create : EventSource = nativeOnly
        member val CONNECTING : int = nativeOnly with get
        member val OPEN : int = nativeOnly with get
        member val CLOSED : int = nativeOnly with get

    [<Global>]
    [<AllowNullLiteral>]
    type CompressionStream
        [<ParamObject; Emit("$0")>]
        (
            prototype: CompressionStream,
            Create: CompressionStream
        ) =

        member val prototype : CompressionStream = nativeOnly with get, set
        member val Create : CompressionStream = nativeOnly

    [<Global>]
    [<AllowNullLiteral>]
    type DecompressionStream
        [<ParamObject; Emit("$0")>]
        (
            prototype: DecompressionStream,
            Create: DecompressionStream
        ) =

        member val prototype : DecompressionStream = nativeOnly with get, set
        member val Create : DecompressionStream = nativeOnly

    [<Global>]
    [<AllowNullLiteral>]
    type TextEncoderStream
        [<ParamObject; Emit("$0")>]
        (
            prototype: TextEncoderStream,
            Create: TextEncoderStream
        ) =

        member val prototype : TextEncoderStream = nativeOnly with get, set
        member val Create : TextEncoderStream = nativeOnly

    [<Global>]
    [<AllowNullLiteral>]
    type TextDecoderStream
        [<ParamObject; Emit("$0")>]
        (
            prototype: TextDecoderStream,
            Create: TextDecoderStream
        ) =

        member val prototype : TextDecoderStream = nativeOnly with get, set
        member val Create : TextDecoderStream = nativeOnly

    [<Global>]
    [<AllowNullLiteral>]
    type Headers
        [<ParamObject; Emit("$0")>]
        (
            prototype: Headers,
            Create: Headers
        ) =

        member val prototype : Headers = nativeOnly with get, set
        member val Create : Headers = nativeOnly

    [<Global>]
    [<AllowNullLiteral>]
    type Request
        [<ParamObject; Emit("$0")>]
        (
            prototype: Request,
            Create: Request
        ) =

        member val prototype : Request = nativeOnly with get, set
        member val Create : Request = nativeOnly

    [<Global>]
    [<AllowNullLiteral>]
    type Response
        [<ParamObject; Emit("$0")>]
        (
            prototype: Response,
            Create: Response,
            error: Response,
            json: Response,
            redirect: Response
        ) =

        member val prototype : Response = nativeOnly with get, set
        member val Create : Response = nativeOnly
        member val error : Response = nativeOnly
        member val json : Response = nativeOnly
        member val redirect : Response = nativeOnly

    [<Global>]
    [<AllowNullLiteral>]
    type WebSocket
        [<ParamObject; Emit("$0")>]
        (
            prototype: WebSocket,
            Create: WebSocket,
            CONNECTING: int,
            OPEN: int,
            CLOSING: int,
            CLOSED: int
        ) =

        member val prototype : WebSocket = nativeOnly with get, set
        member val Create : WebSocket = nativeOnly
        member val CONNECTING : int = nativeOnly with get
        member val OPEN : int = nativeOnly with get
        member val CLOSING : int = nativeOnly with get
        member val CLOSED : int = nativeOnly with get

    [<Global>]
    [<AllowNullLiteral>]
    type WebSocketPair
        [<ParamObject; Emit("$0")>]
        (
            Create: ServiceWorkerGlobalScope.WebSocketPair.Create
        ) =

        member val Create : ServiceWorkerGlobalScope.WebSocketPair.Create = nativeOnly

    [<Global>]
    [<AllowNullLiteral>]
    type AbortController
        [<ParamObject; Emit("$0")>]
        (
            prototype: AbortController,
            Create: AbortController
        ) =

        member val prototype : AbortController = nativeOnly with get, set
        member val Create : AbortController = nativeOnly

    [<Global>]
    [<AllowNullLiteral>]
    type AbortSignal
        [<ParamObject; Emit("$0")>]
        (
            prototype: AbortSignal,
            Create: AbortSignal,
            abort: AbortSignal,
            timeout: AbortSignal
        ) =

        member val prototype : AbortSignal = nativeOnly with get, set
        member val Create : AbortSignal = nativeOnly
        member val abort : AbortSignal = nativeOnly
        member val timeout : AbortSignal = nativeOnly

    [<Global>]
    [<AllowNullLiteral>]
    type TextDecoder
        [<ParamObject; Emit("$0")>]
        (
            prototype: TextDecoder,
            Create: TextDecoder
        ) =

        member val prototype : TextDecoder = nativeOnly with get, set
        member val Create : TextDecoder = nativeOnly

    [<Global>]
    [<AllowNullLiteral>]
    type TextEncoder
        [<ParamObject; Emit("$0")>]
        (
            prototype: TextEncoder,
            Create: TextEncoder
        ) =

        member val prototype : TextEncoder = nativeOnly with get, set
        member val Create : TextEncoder = nativeOnly

    [<Global>]
    [<AllowNullLiteral>]
    type URL
        [<ParamObject; Emit("$0")>]
        (
            prototype: URL,
            Create: URL,
            canParse: bool,
            createObjectURL: string,
            revokeObjectURL: unit
        ) =

        member val prototype : URL = nativeOnly with get, set
        member val Create : URL = nativeOnly
        member val canParse : bool = nativeOnly
        member val createObjectURL : string = nativeOnly
        member val revokeObjectURL : unit = nativeOnly

    [<Global>]
    [<AllowNullLiteral>]
    type URLSearchParams
        [<ParamObject; Emit("$0")>]
        (
            prototype: URLSearchParams,
            Create: URLSearchParams
        ) =

        member val prototype : URLSearchParams = nativeOnly with get, set
        member val Create : URLSearchParams = nativeOnly

    [<Global>]
    [<AllowNullLiteral>]
    type Blob
        [<ParamObject; Emit("$0")>]
        (
            prototype: Blob,
            Create: Blob
        ) =

        member val prototype : Blob = nativeOnly with get, set
        member val Create : Blob = nativeOnly

    [<Global>]
    [<AllowNullLiteral>]
    type File
        [<ParamObject; Emit("$0")>]
        (
            prototype: File,
            Create: File
        ) =

        member val prototype : File = nativeOnly with get, set
        member val Create : File = nativeOnly

    [<Global>]
    [<AllowNullLiteral>]
    type FormData
        [<ParamObject; Emit("$0")>]
        (
            prototype: FormData,
            Create: FormData
        ) =

        member val prototype : FormData = nativeOnly with get, set
        member val Create : FormData = nativeOnly

    [<Global>]
    [<AllowNullLiteral>]
    type Crypto
        [<ParamObject; Emit("$0")>]
        (
            prototype: Crypto,
            Create: Crypto
        ) =

        member val prototype : Crypto = nativeOnly with get, set
        member val Create : Crypto = nativeOnly

    [<Global>]
    [<AllowNullLiteral>]
    type SubtleCrypto
        [<ParamObject; Emit("$0")>]
        (
            prototype: SubtleCrypto,
            Create: SubtleCrypto
        ) =

        member val prototype : SubtleCrypto = nativeOnly with get, set
        member val Create : SubtleCrypto = nativeOnly

    [<Global>]
    [<AllowNullLiteral>]
    type CryptoKey
        [<ParamObject; Emit("$0")>]
        (
            prototype: CryptoKey,
            Create: CryptoKey
        ) =

        member val prototype : CryptoKey = nativeOnly with get, set
        member val Create : CryptoKey = nativeOnly

    [<Global>]
    [<AllowNullLiteral>]
    type CacheStorage
        [<ParamObject; Emit("$0")>]
        (
            prototype: CacheStorage,
            Create: CacheStorage
        ) =

        member val prototype : CacheStorage = nativeOnly with get, set
        member val Create : CacheStorage = nativeOnly

    [<Global>]
    [<AllowNullLiteral>]
    type Cache
        [<ParamObject; Emit("$0")>]
        (
            prototype: Cache,
            Create: Cache
        ) =

        member val prototype : Cache = nativeOnly with get, set
        member val Create : Cache = nativeOnly

    module WebSocketPair =

        [<Global>]
        [<AllowNullLiteral>]
        type Create
            [<ParamObject; Emit("$0")>]
            (
                ``0``: WebSocket,
                ``1``: WebSocket
            ) =

            member val ``0`` : WebSocket = nativeOnly with get, set
            member val ``1`` : WebSocket = nativeOnly with get, set

module Cloudflare =

    [<AllowNullLiteral>]
    [<Interface>]
    type compatibilityFlags =
        [<EmitIndexer>]
        abstract member Item: key: string -> bool with get, set

module DurableObjectTransaction =

    module put =

        [<AllowNullLiteral>]
        [<Interface>]
        type entries =
            [<EmitIndexer>]
            abstract member Item: key: string -> 'T with get, set

module DurableObjectStorage =

    module put =

        [<AllowNullLiteral>]
        [<Interface>]
        type entries =
            [<EmitIndexer>]
            abstract member Item: key: string -> 'T with get, set

module FormData =

    module forEach =

        type callback =
            delegate of value: string * key: string * parent: FormData -> unit

module HeadersInit =

    module U3 =

        [<AllowNullLiteral>]
        [<Interface>]
        type Case3 =
            [<EmitIndexer>]
            abstract member Item: key: string -> string with get, set

module Headers =

    module forEach =

        type callback =
            delegate of value: string * key: string * parent: Headers -> unit

module Response =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type ``type`` =
        | ``default``
        | error

module ResponseInit =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type encodeBody =
        | automatic
        | manual

module RequestInit =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type encodeResponseBody =
        | automatic
        | manual

module KVNamespace =

    module get =

        [<AllowNullLiteral>]
        [<Interface>]
        type options =
            abstract member ``type``: 'Type option with get, set
            abstract member cacheTtl: float option with get, set
            abstract member ``type``: 'Type option with get, set
            abstract member cacheTtl: float option with get, set

    module getWithMetadata =

        [<AllowNullLiteral>]
        [<Interface>]
        type options =
            abstract member ``type``: 'Type option with get, set
            abstract member cacheTtl: float option with get, set
            abstract member ``type``: 'Type option with get, set
            abstract member cacheTtl: float option with get, set

module R2Object =

    [<AllowNullLiteral>]
    [<Interface>]
    type customMetadata =
        [<EmitIndexer>]
        abstract member Item: key: string -> string with get, set

module R2PutOptions =

    [<AllowNullLiteral>]
    [<Interface>]
    type customMetadata =
        [<EmitIndexer>]
        abstract member Item: key: string -> string with get, set

module R2MultipartOptions =

    [<AllowNullLiteral>]
    [<Interface>]
    type customMetadata =
        [<EmitIndexer>]
        abstract member Item: key: string -> string with get, set

module UnderlyingSink =

    type write<'W> =
        delegate of chunk: 'W * controller: WritableStreamDefaultController -> U2<unit, JS.Promise<unit>>

module Transformer =

    type transform<'I> =
        delegate of chunk: 'I * controller: TransformStreamDefaultController<'O> -> U2<unit, JS.Promise<unit>>

module TraceItemFetchEventInfoRequest =

    [<AllowNullLiteral>]
    [<Interface>]
    type headers =
        [<EmitIndexer>]
        abstract member Item: key: string -> string with get, set

module URLSearchParams =

    module forEach =

        type callback =
            delegate of value: string * key: string * parent: URLSearchParams -> unit

module URLPatternComponentResult =

    [<AllowNullLiteral>]
    [<Interface>]
    type groups =
        [<EmitIndexer>]
        abstract member Item: key: string -> string with get, set

module WebSocket =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type binaryType =
        | blob
        | arraybuffer

module SqlStorageCursor =

    [<AllowNullLiteral>]
    [<Interface>]
    type next =
        abstract member ``done``: bool option with get, set
        abstract member value: 'T with get, set
        abstract member ``done``: bool with get, set
        abstract member value: obj option with get, set

module Socket =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type secureTransport =
        | on
        | off
        | starttls

module ContainerStartupOptions =

    [<AllowNullLiteral>]
    [<Interface>]
    type env =
        [<EmitIndexer>]
        abstract member Item: key: string -> string with get, set

module WorkerLoaderWorkerCode =

    [<AllowNullLiteral>]
    [<Interface>]
    type modules =
        [<EmitIndexer>]
        abstract member Item: key: string -> U2<WorkerLoaderModule, string> with get, set

module AiSearchSearchRequest =

    [<Global>]
    [<AllowNullLiteral>]
    type messages
        [<ParamObject; Emit("$0")>]
        (
            role: AiSearchSearchRequest.messages.role,
            content: U2<string, obj>
        ) =

        member val role : AiSearchSearchRequest.messages.role = nativeOnly with get, set
        member val content : U2<string, obj> = nativeOnly with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type ai_search_options =
        abstract member retrieval: AiSearchSearchRequest.ai_search_options.retrieval option with get, set
        abstract member query_rewrite: AiSearchSearchRequest.ai_search_options.query_rewrite option with get, set
        abstract member reranking: AiSearchSearchRequest.ai_search_options.reranking option with get, set
        [<EmitIndexer>]
        abstract member Item: key: string -> obj with get, set

    module messages =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type role =
            | system
            | developer
            | user
            | assistant
            | tool

    module ai_search_options =

        [<AllowNullLiteral>]
        [<Interface>]
        type retrieval =
            abstract member retrieval_type: AiSearchSearchRequest.ai_search_options.retrieval.retrieval_type option with get, set
            /// <summary>
            /// Match threshold (0-1, default 0.4)
            /// </summary>
            abstract member match_threshold: float option with get, set
            /// <summary>
            /// Maximum number of results (1-50, default 10)
            /// </summary>
            abstract member max_num_results: float option with get, set
            abstract member filters: VectorizeVectorMetadataFilter option with get, set
            /// <summary>
            /// Context expansion (0-3, default 0)
            /// </summary>
            abstract member context_expansion: float option with get, set
            [<EmitIndexer>]
            abstract member Item: key: string -> obj with get, set

        [<AllowNullLiteral>]
        [<Interface>]
        type query_rewrite =
            abstract member enabled: bool option with get, set
            abstract member model: string option with get, set
            abstract member rewrite_prompt: string option with get, set
            [<EmitIndexer>]
            abstract member Item: key: string -> obj with get, set

        [<AllowNullLiteral>]
        [<Interface>]
        type reranking =
            /// <summary>
            /// Enable reranking (default false)
            /// </summary>
            abstract member enabled: bool option with get, set
            abstract member model: AiSearchSearchRequest.ai_search_options.reranking.model option with get, set
            /// <summary>
            /// Match threshold (0-1, default 0.4)
            /// </summary>
            abstract member match_threshold: float option with get, set
            [<EmitIndexer>]
            abstract member Item: key: string -> obj with get, set

        module retrieval =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type retrieval_type =
                | vector
                | keyword
                | hybrid

        module reranking =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type model =
                | [<CompiledName("@cf/baai/bge-reranker-base")>] ``_AT_cf/baai/bge-reranker-base``
                | [<CompiledName("")>] _EMPTY_

module AiSearchChatCompletionsRequest =

    [<Global>]
    [<AllowNullLiteral>]
    type messages
        [<ParamObject; Emit("$0")>]
        (
            role: AiSearchChatCompletionsRequest.messages.role,
            content: U2<string, obj>
        ) =

        member val role : AiSearchChatCompletionsRequest.messages.role = nativeOnly with get, set
        member val content : U2<string, obj> = nativeOnly with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type ai_search_options =
        abstract member retrieval: AiSearchChatCompletionsRequest.ai_search_options.retrieval option with get, set
        abstract member query_rewrite: AiSearchChatCompletionsRequest.ai_search_options.query_rewrite option with get, set
        abstract member reranking: AiSearchChatCompletionsRequest.ai_search_options.reranking option with get, set
        [<EmitIndexer>]
        abstract member Item: key: string -> obj with get, set

    module messages =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type role =
            | system
            | developer
            | user
            | assistant
            | tool

    module ai_search_options =

        [<AllowNullLiteral>]
        [<Interface>]
        type retrieval =
            abstract member retrieval_type: AiSearchChatCompletionsRequest.ai_search_options.retrieval.retrieval_type option with get, set
            abstract member match_threshold: float option with get, set
            abstract member max_num_results: float option with get, set
            abstract member filters: VectorizeVectorMetadataFilter option with get, set
            abstract member context_expansion: float option with get, set
            [<EmitIndexer>]
            abstract member Item: key: string -> obj with get, set

        [<AllowNullLiteral>]
        [<Interface>]
        type query_rewrite =
            abstract member enabled: bool option with get, set
            abstract member model: string option with get, set
            abstract member rewrite_prompt: string option with get, set
            [<EmitIndexer>]
            abstract member Item: key: string -> obj with get, set

        [<AllowNullLiteral>]
        [<Interface>]
        type reranking =
            abstract member enabled: bool option with get, set
            abstract member model: AiSearchChatCompletionsRequest.ai_search_options.reranking.model option with get, set
            abstract member match_threshold: float option with get, set
            [<EmitIndexer>]
            abstract member Item: key: string -> obj with get, set

        module retrieval =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type retrieval_type =
                | vector
                | keyword
                | hybrid

        module reranking =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type model =
                | [<CompiledName("@cf/baai/bge-reranker-base")>] ``_AT_cf/baai/bge-reranker-base``
                | [<CompiledName("")>] _EMPTY_

module AiSearchSearchResponse =

    [<Global>]
    [<AllowNullLiteral>]
    type chunks
        [<ParamObject; Emit("$0")>]
        (
            id: string,
            ``type``: string,
            score: float,
            text: string,
            item: AiSearchSearchResponse.chunks.item,
            ?scoring_details: AiSearchSearchResponse.chunks.scoring_details
        ) =

        member val id : string = nativeOnly with get, set
        member val ``type`` : string = nativeOnly with get, set
        member val score : float = nativeOnly with get, set
        member val text : string = nativeOnly with get, set
        member val item : AiSearchSearchResponse.chunks.item = nativeOnly with get, set
        member val scoring_details : AiSearchSearchResponse.chunks.scoring_details option = nativeOnly with get, set

    module chunks =

        [<Global>]
        [<AllowNullLiteral>]
        type item
            [<ParamObject; Emit("$0")>]
            (
                key: string,
                ?timestamp: float,
                ?metadata: AiSearchSearchResponse.chunks.item.metadata
            ) =

            member val key : string = nativeOnly with get, set
            member val timestamp : float option = nativeOnly with get, set
            member val metadata : AiSearchSearchResponse.chunks.item.metadata option = nativeOnly with get, set

        [<Global>]
        [<AllowNullLiteral>]
        type scoring_details
            [<ParamObject; Emit("$0")>]
            (
                ?keyword_score: float,
                ?vector_score: float
            ) =

            member val keyword_score : float option = nativeOnly with get, set
            member val vector_score : float option = nativeOnly with get, set

        module item =

            [<AllowNullLiteral>]
            [<Interface>]
            type metadata =
                [<EmitIndexer>]
                abstract member Item: key: string -> obj with get, set

module AiSearchListResponse =

    [<AllowNullLiteral>]
    [<Interface>]
    type ResizeArray =
        abstract member id: string with get, set
        abstract member internal_id: string option with get, set
        abstract member account_id: string option with get, set
        abstract member account_tag: string option with get, set
        /// <summary>
        /// Whether the instance is enabled (default true)
        /// </summary>
        abstract member enable: bool option with get, set
        abstract member ``type``: AiSearchListResponse.ResizeArray.``type`` option with get, set
        abstract member source: string option with get, set
        [<EmitIndexer>]
        abstract member Item: key: string -> obj with get, set

    module ResizeArray =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type ``type`` =
            | r2
            | ``web-crawler``

module AiSearchConfig =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type ``type`` =
        | r2
        | ``web-crawler``

module AiSearchInstance =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type ``type`` =
        | r2
        | ``web-crawler``

module AiAutomaticSpeechRecognitionOutput =

    [<Global>]
    [<AllowNullLiteral>]
    type words
        [<ParamObject; Emit("$0")>]
        (
            word: string,
            start: float,
            ``end``: float
        ) =

        member val word : string = nativeOnly with get, set
        member val start : float = nativeOnly with get, set
        member val ``end`` : float = nativeOnly with get, set

module RoleScopedChatInput =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type role =
        | user
        | assistant
        | system
        | tool

module AiTextGenerationToolLegacyInput =

    [<Global>]
    [<AllowNullLiteral>]
    type parameters
        [<ParamObject; Emit("$0")>]
        (
            ``type``: AiTextGenerationToolLegacyInput.parameters.``type``,
            properties: AiTextGenerationToolLegacyInput.parameters.properties,
            required: ResizeArray<string>
        ) =

        member val ``type`` : AiTextGenerationToolLegacyInput.parameters.``type`` = nativeOnly with get, set
        member val properties : AiTextGenerationToolLegacyInput.parameters.properties = nativeOnly with get, set
        member val required : ResizeArray<string> = nativeOnly with get, set

    module parameters =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type ``type`` =
            | ``object``

        [<AllowNullLiteral>]
        [<Interface>]
        type properties =
            [<EmitIndexer>]
            abstract member Item: key: string -> AiTextGenerationToolLegacyInput.parameters.properties.Item with get, set

        module properties =

            [<Global>]
            [<AllowNullLiteral>]
            type Item
                [<ParamObject; Emit("$0")>]
                (
                    ``type``: string,
                    ?description: string
                ) =

                member val ``type`` : string = nativeOnly with get, set
                member val description : string option = nativeOnly with get, set

module AiTextGenerationToolInput =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type ``type`` =
        | ``function``

    [<Global>]
    [<AllowNullLiteral>]
    type ``function``
        [<ParamObject; Emit("$0")>]
        (
            name: string,
            description: string,
            ?parameters: AiTextGenerationToolInput.``function``.parameters
        ) =

        member val name : string = nativeOnly with get, set
        member val description : string = nativeOnly with get, set
        member val parameters : AiTextGenerationToolInput.``function``.parameters option = nativeOnly with get, set

    module ``function`` =

        [<Global>]
        [<AllowNullLiteral>]
        type parameters
            [<ParamObject; Emit("$0")>]
            (
                ``type``: AiTextGenerationToolInput.``function``.parameters.``type``,
                properties: AiTextGenerationToolInput.``function``.parameters.properties,
                required: ResizeArray<string>
            ) =

            member val ``type`` : AiTextGenerationToolInput.``function``.parameters.``type`` = nativeOnly with get, set
            member val properties : AiTextGenerationToolInput.``function``.parameters.properties = nativeOnly with get, set
            member val required : ResizeArray<string> = nativeOnly with get, set

        module parameters =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type ``type`` =
                | ``object``

            [<AllowNullLiteral>]
            [<Interface>]
            type properties =
                [<EmitIndexer>]
                abstract member Item: key: string -> AiTextGenerationToolInput.``function``.parameters.properties.Item with get, set

            module properties =

                [<Global>]
                [<AllowNullLiteral>]
                type Item
                    [<ParamObject; Emit("$0")>]
                    (
                        ``type``: string,
                        ?description: string
                    ) =

                    member val ``type`` : string = nativeOnly with get, set
                    member val description : string option = nativeOnly with get, set

module AiTextGenerationToolOutput =

    [<Global>]
    [<AllowNullLiteral>]
    type ``function``
        [<ParamObject; Emit("$0")>]
        (
            name: string,
            arguments: string
        ) =

        member val name : string = nativeOnly with get, set
        member val arguments : string = nativeOnly with get, set

module AiTextToSpeechOutput =

    module U2 =

        [<Global>]
        [<AllowNullLiteral>]
        type Case2
            [<ParamObject; Emit("$0")>]
            (
                audio: string
            ) =

            member val audio : string = nativeOnly with get, set

module EasyInputMessage =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type role =
        | user
        | assistant
        | system
        | developer

module ResponsesFunctionTool =

    module parameters =

        module U2 =

            [<AllowNullLiteral>]
            [<Interface>]
            type Case1 =
                [<EmitIndexer>]
                abstract member Item: key: string -> obj with get, set

module ResponseIncompleteDetails =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type reason =
        | max_output_tokens
        | content_filter

module ResponsePrompt =

    module variables =

        module U2 =

            [<AllowNullLiteral>]
            [<Interface>]
            type Case1 =
                [<EmitIndexer>]
                abstract member Item: key: string -> U3<string, ResponseInputText, ResponseInputImage> with get, set

module ResponseError =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type code =
        | server_error
        | rate_limit_exceeded
        | invalid_prompt
        | vector_store_timeout
        | invalid_image
        | invalid_image_format
        | invalid_base64_image
        | invalid_image_url
        | image_too_large
        | image_too_small
        | image_parse_error
        | image_content_policy_violation
        | invalid_image_mode
        | image_file_too_large
        | unsupported_image_media_type
        | empty_image_file
        | failed_to_download_image
        | image_file_not_found

module ResponseFormatTextJSONSchemaConfig =

    [<AllowNullLiteral>]
    [<Interface>]
    type schema =
        [<EmitIndexer>]
        abstract member Item: key: string -> obj with get, set

module ResponseFunctionToolCall =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type status =
        | in_progress
        | completed
        | incomplete

module ResponseFunctionToolCallOutputItem =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type status =
        | in_progress
        | completed
        | incomplete

module ResponseInputImage =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type detail =
        | low
        | high
        | auto

module ResponseInputItemMessage =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type role =
        | user
        | system
        | developer

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type status =
        | in_progress
        | completed
        | incomplete

module ResponseInputMessageItem =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type role =
        | user
        | system
        | developer

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type status =
        | in_progress
        | completed
        | incomplete

module ResponseOutputMessage =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type status =
        | in_progress
        | completed
        | incomplete

module ResponseReasoningItem =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type status =
        | in_progress
        | completed
        | incomplete

module Ai_Cf_Baai_Bge_Base_En_V1_5_Input =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type pooling =
        | mean
        | cls

    [<Global>]
    [<AllowNullLiteral>]
    type requests
        [<ParamObject; Emit("$0")>]
        (
            text: U2<string, ResizeArray<string>>,
            ?pooling: Ai_Cf_Baai_Bge_Base_En_V1_5_Input.requests.pooling
        ) =

        member val text : U2<string, ResizeArray<string>> = nativeOnly with get, set
        member val pooling : Ai_Cf_Baai_Bge_Base_En_V1_5_Input.requests.pooling option = nativeOnly with get, set

    module requests =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type pooling =
            | mean
            | cls

module Ai_Cf_Baai_Bge_Base_En_V1_5_Output =

    module U2 =

        [<Global>]
        [<AllowNullLiteral>]
        type Case1
            [<ParamObject; Emit("$0")>]
            (
                ?shape: ResizeArray<float>,
                ?data: ResizeArray<ResizeArray<float>>,
                ?pooling: Ai_Cf_Baai_Bge_Base_En_V1_5_Output.U2.Case1.pooling
            ) =

            member val shape : ResizeArray<float> option = nativeOnly with get, set
            member val data : ResizeArray<ResizeArray<float>> option = nativeOnly with get, set
            member val pooling : Ai_Cf_Baai_Bge_Base_En_V1_5_Output.U2.Case1.pooling option = nativeOnly with get, set

        module Case1 =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type pooling =
                | mean
                | cls

module Ai_Cf_Openai_Whisper_Input =

    module U2 =

        [<Global>]
        [<AllowNullLiteral>]
        type Case2
            [<ParamObject; Emit("$0")>]
            (
                audio: ResizeArray<float>
            ) =

            member val audio : ResizeArray<float> = nativeOnly with get, set

module Ai_Cf_Openai_Whisper_Output =

    [<Global>]
    [<AllowNullLiteral>]
    type words
        [<ParamObject; Emit("$0")>]
        (
            ?word: string,
            ?start: float,
            ?``end``: float
        ) =

        member val word : string option = nativeOnly with get, set
        member val start : float option = nativeOnly with get, set
        member val ``end`` : float option = nativeOnly with get, set

module Ai_Cf_Meta_M2M100_1_2B_Input =

    [<Global>]
    [<AllowNullLiteral>]
    type requests
        [<ParamObject; Emit("$0")>]
        (
            text: string,
            target_lang: string,
            ?source_lang: string
        ) =

        member val text : string = nativeOnly with get, set
        member val target_lang : string = nativeOnly with get, set
        member val source_lang : string option = nativeOnly with get, set

module Ai_Cf_Meta_M2M100_1_2B_Output =

    module U2 =

        [<Global>]
        [<AllowNullLiteral>]
        type Case1
            [<ParamObject; Emit("$0")>]
            (
                ?translated_text: string
            ) =

            member val translated_text : string option = nativeOnly with get, set

module Ai_Cf_Baai_Bge_Small_En_V1_5_Input =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type pooling =
        | mean
        | cls

    [<Global>]
    [<AllowNullLiteral>]
    type requests
        [<ParamObject; Emit("$0")>]
        (
            text: U2<string, ResizeArray<string>>,
            ?pooling: Ai_Cf_Baai_Bge_Small_En_V1_5_Input.requests.pooling
        ) =

        member val text : U2<string, ResizeArray<string>> = nativeOnly with get, set
        member val pooling : Ai_Cf_Baai_Bge_Small_En_V1_5_Input.requests.pooling option = nativeOnly with get, set

    module requests =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type pooling =
            | mean
            | cls

module Ai_Cf_Baai_Bge_Small_En_V1_5_Output =

    module U2 =

        [<Global>]
        [<AllowNullLiteral>]
        type Case1
            [<ParamObject; Emit("$0")>]
            (
                ?shape: ResizeArray<float>,
                ?data: ResizeArray<ResizeArray<float>>,
                ?pooling: Ai_Cf_Baai_Bge_Small_En_V1_5_Output.U2.Case1.pooling
            ) =

            member val shape : ResizeArray<float> option = nativeOnly with get, set
            member val data : ResizeArray<ResizeArray<float>> option = nativeOnly with get, set
            member val pooling : Ai_Cf_Baai_Bge_Small_En_V1_5_Output.U2.Case1.pooling option = nativeOnly with get, set

        module Case1 =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type pooling =
                | mean
                | cls

module Ai_Cf_Baai_Bge_Large_En_V1_5_Input =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type pooling =
        | mean
        | cls

    [<Global>]
    [<AllowNullLiteral>]
    type requests
        [<ParamObject; Emit("$0")>]
        (
            text: U2<string, ResizeArray<string>>,
            ?pooling: Ai_Cf_Baai_Bge_Large_En_V1_5_Input.requests.pooling
        ) =

        member val text : U2<string, ResizeArray<string>> = nativeOnly with get, set
        member val pooling : Ai_Cf_Baai_Bge_Large_En_V1_5_Input.requests.pooling option = nativeOnly with get, set

    module requests =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type pooling =
            | mean
            | cls

module Ai_Cf_Baai_Bge_Large_En_V1_5_Output =

    module U2 =

        [<Global>]
        [<AllowNullLiteral>]
        type Case1
            [<ParamObject; Emit("$0")>]
            (
                ?shape: ResizeArray<float>,
                ?data: ResizeArray<ResizeArray<float>>,
                ?pooling: Ai_Cf_Baai_Bge_Large_En_V1_5_Output.U2.Case1.pooling
            ) =

            member val shape : ResizeArray<float> option = nativeOnly with get, set
            member val data : ResizeArray<ResizeArray<float>> option = nativeOnly with get, set
            member val pooling : Ai_Cf_Baai_Bge_Large_En_V1_5_Output.U2.Case1.pooling option = nativeOnly with get, set

        module Case1 =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type pooling =
                | mean
                | cls

module Ai_Cf_Unum_Uform_Gen2_Qwen_500M_Input =

    module U2 =

        [<Global>]
        [<AllowNullLiteral>]
        type Case2
            [<ParamObject; Emit("$0")>]
            (
                image: U2<ResizeArray<float>, obj>,
                ?prompt: string,
                ?raw: bool,
                ?top_p: float,
                ?top_k: float,
                ?seed: float,
                ?repetition_penalty: float,
                ?frequency_penalty: float,
                ?presence_penalty: float,
                ?max_tokens: float
            ) =

            member val image : U2<ResizeArray<float>, obj> = nativeOnly with get, set
            member val prompt : string option = nativeOnly with get, set
            member val raw : bool option = nativeOnly with get, set
            member val top_p : float option = nativeOnly with get, set
            member val top_k : float option = nativeOnly with get, set
            member val seed : float option = nativeOnly with get, set
            member val repetition_penalty : float option = nativeOnly with get, set
            member val frequency_penalty : float option = nativeOnly with get, set
            member val presence_penalty : float option = nativeOnly with get, set
            member val max_tokens : float option = nativeOnly with get, set

module Ai_Cf_Openai_Whisper_Tiny_En_Input =

    module U2 =

        [<Global>]
        [<AllowNullLiteral>]
        type Case2
            [<ParamObject; Emit("$0")>]
            (
                audio: ResizeArray<float>
            ) =

            member val audio : ResizeArray<float> = nativeOnly with get, set

module Ai_Cf_Openai_Whisper_Tiny_En_Output =

    [<Global>]
    [<AllowNullLiteral>]
    type words
        [<ParamObject; Emit("$0")>]
        (
            ?word: string,
            ?start: float,
            ?``end``: float
        ) =

        member val word : string option = nativeOnly with get, set
        member val start : float option = nativeOnly with get, set
        member val ``end`` : float option = nativeOnly with get, set

module Ai_Cf_Openai_Whisper_Large_V3_Turbo_Output =

    [<Global>]
    [<AllowNullLiteral>]
    type transcription_info
        [<ParamObject; Emit("$0")>]
        (
            ?language: string,
            ?language_probability: float,
            ?duration: float,
            ?duration_after_vad: float
        ) =

        member val language : string option = nativeOnly with get, set
        member val language_probability : float option = nativeOnly with get, set
        member val duration : float option = nativeOnly with get, set
        member val duration_after_vad : float option = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type segments
        [<ParamObject; Emit("$0")>]
        (
            ?start: float,
            ?``end``: float,
            ?text: string,
            ?temperature: float,
            ?avg_logprob: float,
            ?compression_ratio: float,
            ?no_speech_prob: float,
            ?words: ResizeArray<Ai_Cf_Openai_Whisper_Large_V3_Turbo_Output.segments.words>
        ) =

        member val start : float option = nativeOnly with get, set
        member val ``end`` : float option = nativeOnly with get, set
        member val text : string option = nativeOnly with get, set
        member val temperature : float option = nativeOnly with get, set
        member val avg_logprob : float option = nativeOnly with get, set
        member val compression_ratio : float option = nativeOnly with get, set
        member val no_speech_prob : float option = nativeOnly with get, set
        member val words : ResizeArray<Ai_Cf_Openai_Whisper_Large_V3_Turbo_Output.segments.words> option = nativeOnly with get, set

    module segments =

        [<Global>]
        [<AllowNullLiteral>]
        type words
            [<ParamObject; Emit("$0")>]
            (
                ?word: string,
                ?start: float,
                ?``end``: float
            ) =

            member val word : string option = nativeOnly with get, set
            member val start : float option = nativeOnly with get, set
            member val ``end`` : float option = nativeOnly with get, set

module Ai_Cf_Baai_Bge_M3_Input =

    module U3 =

        [<Global>]
        [<AllowNullLiteral>]
        type Case3
            [<ParamObject; Emit("$0")>]
            (
                requests: ResizeArray<U2<Ai_Cf_Baai_Bge_M3_Input_QueryAnd_Contexts_1, Ai_Cf_Baai_Bge_M3_Input_Embedding_1>>
            ) =

            member val requests : ResizeArray<U2<Ai_Cf_Baai_Bge_M3_Input_QueryAnd_Contexts_1, Ai_Cf_Baai_Bge_M3_Input_Embedding_1>> = nativeOnly with get, set

module Ai_Cf_Baai_Bge_M3_Input_QueryAnd_Contexts =

    [<Global>]
    [<AllowNullLiteral>]
    type contexts
        [<ParamObject; Emit("$0")>]
        (
            ?text: string
        ) =

        member val text : string option = nativeOnly with get, set

module Ai_Cf_Baai_Bge_M3_Input_QueryAnd_Contexts_1 =

    [<Global>]
    [<AllowNullLiteral>]
    type contexts
        [<ParamObject; Emit("$0")>]
        (
            ?text: string
        ) =

        member val text : string option = nativeOnly with get, set

module Ai_Cf_Baai_Bge_M3_Ouput_Query =

    [<Global>]
    [<AllowNullLiteral>]
    type response
        [<ParamObject; Emit("$0")>]
        (
            ?id: float,
            ?score: float
        ) =

        member val id : float option = nativeOnly with get, set
        member val score : float option = nativeOnly with get, set

module Ai_Cf_Baai_Bge_M3_Output_EmbeddingFor_Contexts =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type pooling =
        | mean
        | cls

module Ai_Cf_Baai_Bge_M3_Ouput_Embedding =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type pooling =
        | mean
        | cls

module Ai_Cf_Meta_Llama_3_2_11B_Vision_Instruct_Messages =

    [<Global>]
    [<AllowNullLiteral>]
    type messages
        [<ParamObject; Emit("$0")>]
        (
            ?role: string,
            ?tool_call_id: string,
            ?content: U3<string, ResizeArray<Ai_Cf_Meta_Llama_3_2_11B_Vision_Instruct_Messages.messages.content.U3.Case2>, Ai_Cf_Meta_Llama_3_2_11B_Vision_Instruct_Messages.messages.content.U3.Case3>
        ) =

        member val role : string option = nativeOnly with get, set
        member val tool_call_id : string option = nativeOnly with get, set
        member val content : U3<string, ResizeArray<Ai_Cf_Meta_Llama_3_2_11B_Vision_Instruct_Messages.messages.content.U3.Case2>, Ai_Cf_Meta_Llama_3_2_11B_Vision_Instruct_Messages.messages.content.U3.Case3> option = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type functions
        [<ParamObject; Emit("$0")>]
        (
            name: string,
            code: string
        ) =

        member val name : string = nativeOnly with get, set
        member val code : string = nativeOnly with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type tools =
        /// <summary>
        /// The name of the tool. More descriptive the better.
        /// </summary>
        abstract member name: string with get, set
        /// <summary>
        /// A brief description of what the tool does.
        /// </summary>
        abstract member description: string with get, set
        /// <summary>
        /// Schema defining the parameters accepted by the tool.
        /// </summary>
        abstract member parameters: Ai_Cf_Meta_Llama_3_2_11B_Vision_Instruct_Messages.tools.parameters with get, set
        /// <summary>
        /// Specifies the type of tool (e.g., 'function').
        /// </summary>
        abstract member ``type``: string with get, set
        /// <summary>
        /// Details of the function tool.
        /// </summary>
        abstract member ``function``: Ai_Cf_Meta_Llama_3_2_11B_Vision_Instruct_Messages.tools.``function`` with get, set

    module messages =

        module content =

            module U3 =

                [<Global>]
                [<AllowNullLiteral>]
                type Case2
                    [<ParamObject; Emit("$0")>]
                    (
                        ?``type``: string,
                        ?text: string,
                        ?image_url: Ai_Cf_Meta_Llama_3_2_11B_Vision_Instruct_Messages.messages.content.U3.Case2.image_url
                    ) =

                    member val ``type`` : string option = nativeOnly with get, set
                    member val text : string option = nativeOnly with get, set
                    member val image_url : Ai_Cf_Meta_Llama_3_2_11B_Vision_Instruct_Messages.messages.content.U3.Case2.image_url option = nativeOnly with get, set

                [<Global>]
                [<AllowNullLiteral>]
                type Case3
                    [<ParamObject; Emit("$0")>]
                    (
                        ?``type``: string,
                        ?text: string,
                        ?image_url: Ai_Cf_Meta_Llama_3_2_11B_Vision_Instruct_Messages.messages.content.U3.Case3.image_url
                    ) =

                    member val ``type`` : string option = nativeOnly with get, set
                    member val text : string option = nativeOnly with get, set
                    member val image_url : Ai_Cf_Meta_Llama_3_2_11B_Vision_Instruct_Messages.messages.content.U3.Case3.image_url option = nativeOnly with get, set

                module Case2 =

                    [<Global>]
                    [<AllowNullLiteral>]
                    type image_url
                        [<ParamObject; Emit("$0")>]
                        (
                            ?url: string
                        ) =

                        member val url : string option = nativeOnly with get, set

                module Case3 =

                    [<Global>]
                    [<AllowNullLiteral>]
                    type image_url
                        [<ParamObject; Emit("$0")>]
                        (
                            ?url: string
                        ) =

                        member val url : string option = nativeOnly with get, set

    module tools =

        [<Global>]
        [<AllowNullLiteral>]
        type parameters
            [<ParamObject; Emit("$0")>]
            (
                ``type``: string,
                properties: Ai_Cf_Meta_Llama_3_2_11B_Vision_Instruct_Messages.tools.parameters.properties,
                ?required: ResizeArray<string>
            ) =

            member val ``type`` : string = nativeOnly with get, set
            member val properties : Ai_Cf_Meta_Llama_3_2_11B_Vision_Instruct_Messages.tools.parameters.properties = nativeOnly with get, set
            member val required : ResizeArray<string> option = nativeOnly with get, set

        [<Global>]
        [<AllowNullLiteral>]
        type ``function``
            [<ParamObject; Emit("$0")>]
            (
                name: string,
                description: string,
                parameters: Ai_Cf_Meta_Llama_3_2_11B_Vision_Instruct_Messages.tools.``function``.parameters
            ) =

            member val name : string = nativeOnly with get, set
            member val description : string = nativeOnly with get, set
            member val parameters : Ai_Cf_Meta_Llama_3_2_11B_Vision_Instruct_Messages.tools.``function``.parameters = nativeOnly with get, set

        module parameters =

            [<AllowNullLiteral>]
            [<Interface>]
            type properties =
                [<EmitIndexer>]
                abstract member Item: k: string -> Ai_Cf_Meta_Llama_3_2_11B_Vision_Instruct_Messages.tools.parameters.properties.Item with get, set

            module properties =

                [<Global>]
                [<AllowNullLiteral>]
                type Item
                    [<ParamObject; Emit("$0")>]
                    (
                        ``type``: string,
                        description: string
                    ) =

                    member val ``type`` : string = nativeOnly with get, set
                    member val description : string = nativeOnly with get, set

        module ``function`` =

            [<Global>]
            [<AllowNullLiteral>]
            type parameters
                [<ParamObject; Emit("$0")>]
                (
                    ``type``: string,
                    properties: Ai_Cf_Meta_Llama_3_2_11B_Vision_Instruct_Messages.tools.``function``.parameters.properties,
                    ?required: ResizeArray<string>
                ) =

                member val ``type`` : string = nativeOnly with get, set
                member val properties : Ai_Cf_Meta_Llama_3_2_11B_Vision_Instruct_Messages.tools.``function``.parameters.properties = nativeOnly with get, set
                member val required : ResizeArray<string> option = nativeOnly with get, set

            module parameters =

                [<AllowNullLiteral>]
                [<Interface>]
                type properties =
                    [<EmitIndexer>]
                    abstract member Item: k: string -> Ai_Cf_Meta_Llama_3_2_11B_Vision_Instruct_Messages.tools.``function``.parameters.properties.Item with get, set

                module properties =

                    [<Global>]
                    [<AllowNullLiteral>]
                    type Item
                        [<ParamObject; Emit("$0")>]
                        (
                            ``type``: string,
                            description: string
                        ) =

                        member val ``type`` : string = nativeOnly with get, set
                        member val description : string = nativeOnly with get, set

module Ai_Cf_Meta_Llama_3_2_11B_Vision_Instruct_Output =

    [<Global>]
    [<AllowNullLiteral>]
    type tool_calls
        [<ParamObject; Emit("$0")>]
        (
            ?arguments: obj,
            ?name: string
        ) =

        member val arguments : obj option = nativeOnly with get, set
        member val name : string option = nativeOnly with get, set

module Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_JSON_Mode =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type ``type`` =
        | json_object
        | json_schema

module Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_Messages =

    [<Global>]
    [<AllowNullLiteral>]
    type messages
        [<ParamObject; Emit("$0")>]
        (
            role: string,
            content: string
        ) =

        member val role : string = nativeOnly with get, set
        member val content : string = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type functions
        [<ParamObject; Emit("$0")>]
        (
            name: string,
            code: string
        ) =

        member val name : string = nativeOnly with get, set
        member val code : string = nativeOnly with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type tools =
        /// <summary>
        /// The name of the tool. More descriptive the better.
        /// </summary>
        abstract member name: string with get, set
        /// <summary>
        /// A brief description of what the tool does.
        /// </summary>
        abstract member description: string with get, set
        /// <summary>
        /// Schema defining the parameters accepted by the tool.
        /// </summary>
        abstract member parameters: Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_Messages.tools.parameters with get, set
        /// <summary>
        /// Specifies the type of tool (e.g., 'function').
        /// </summary>
        abstract member ``type``: string with get, set
        /// <summary>
        /// Details of the function tool.
        /// </summary>
        abstract member ``function``: Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_Messages.tools.``function`` with get, set

    module tools =

        [<Global>]
        [<AllowNullLiteral>]
        type parameters
            [<ParamObject; Emit("$0")>]
            (
                ``type``: string,
                properties: Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_Messages.tools.parameters.properties,
                ?required: ResizeArray<string>
            ) =

            member val ``type`` : string = nativeOnly with get, set
            member val properties : Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_Messages.tools.parameters.properties = nativeOnly with get, set
            member val required : ResizeArray<string> option = nativeOnly with get, set

        [<Global>]
        [<AllowNullLiteral>]
        type ``function``
            [<ParamObject; Emit("$0")>]
            (
                name: string,
                description: string,
                parameters: Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_Messages.tools.``function``.parameters
            ) =

            member val name : string = nativeOnly with get, set
            member val description : string = nativeOnly with get, set
            member val parameters : Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_Messages.tools.``function``.parameters = nativeOnly with get, set

        module parameters =

            [<AllowNullLiteral>]
            [<Interface>]
            type properties =
                [<EmitIndexer>]
                abstract member Item: k: string -> Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_Messages.tools.parameters.properties.Item with get, set

            module properties =

                [<Global>]
                [<AllowNullLiteral>]
                type Item
                    [<ParamObject; Emit("$0")>]
                    (
                        ``type``: string,
                        description: string
                    ) =

                    member val ``type`` : string = nativeOnly with get, set
                    member val description : string = nativeOnly with get, set

        module ``function`` =

            [<Global>]
            [<AllowNullLiteral>]
            type parameters
                [<ParamObject; Emit("$0")>]
                (
                    ``type``: string,
                    properties: Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_Messages.tools.``function``.parameters.properties,
                    ?required: ResizeArray<string>
                ) =

                member val ``type`` : string = nativeOnly with get, set
                member val properties : Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_Messages.tools.``function``.parameters.properties = nativeOnly with get, set
                member val required : ResizeArray<string> option = nativeOnly with get, set

            module parameters =

                [<AllowNullLiteral>]
                [<Interface>]
                type properties =
                    [<EmitIndexer>]
                    abstract member Item: k: string -> Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_Messages.tools.``function``.parameters.properties.Item with get, set

                module properties =

                    [<Global>]
                    [<AllowNullLiteral>]
                    type Item
                        [<ParamObject; Emit("$0")>]
                        (
                            ``type``: string,
                            description: string
                        ) =

                        member val ``type`` : string = nativeOnly with get, set
                        member val description : string = nativeOnly with get, set

module Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_JSON_Mode_1 =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type ``type`` =
        | json_object
        | json_schema

module Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_Async_Batch =

    [<Global>]
    [<AllowNullLiteral>]
    type requests
        [<ParamObject; Emit("$0")>]
        (
            ?external_reference: string,
            ?prompt: string,
            ?stream: bool,
            ?max_tokens: float,
            ?temperature: float,
            ?top_p: float,
            ?seed: float,
            ?repetition_penalty: float,
            ?frequency_penalty: float,
            ?presence_penalty: float,
            ?response_format: Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_JSON_Mode_2
        ) =

        member val external_reference : string option = nativeOnly with get, set
        member val prompt : string option = nativeOnly with get, set
        member val stream : bool option = nativeOnly with get, set
        member val max_tokens : float option = nativeOnly with get, set
        member val temperature : float option = nativeOnly with get, set
        member val top_p : float option = nativeOnly with get, set
        member val seed : float option = nativeOnly with get, set
        member val repetition_penalty : float option = nativeOnly with get, set
        member val frequency_penalty : float option = nativeOnly with get, set
        member val presence_penalty : float option = nativeOnly with get, set
        member val response_format : Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_JSON_Mode_2 option = nativeOnly with get, set

module Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_JSON_Mode_2 =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type ``type`` =
        | json_object
        | json_schema

module Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_Output =

    module U3 =

        [<Global>]
        [<AllowNullLiteral>]
        type Case1
            [<ParamObject; Emit("$0")>]
            (
                response: string,
                ?usage: Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_Output.U3.Case1.usage,
                ?tool_calls: ResizeArray<Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_Output.U3.Case1.tool_calls>
            ) =

            member val response : string = nativeOnly with get, set
            member val usage : Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_Output.U3.Case1.usage option = nativeOnly with get, set
            member val tool_calls : ResizeArray<Ai_Cf_Meta_Llama_3_3_70B_Instruct_Fp8_Fast_Output.U3.Case1.tool_calls> option = nativeOnly with get, set

        module Case1 =

            [<Global>]
            [<AllowNullLiteral>]
            type usage
                [<ParamObject; Emit("$0")>]
                (
                    ?prompt_tokens: float,
                    ?completion_tokens: float,
                    ?total_tokens: float
                ) =

                member val prompt_tokens : float option = nativeOnly with get, set
                member val completion_tokens : float option = nativeOnly with get, set
                member val total_tokens : float option = nativeOnly with get, set

            [<Global>]
            [<AllowNullLiteral>]
            type tool_calls
                [<ParamObject; Emit("$0")>]
                (
                    ?arguments: obj,
                    ?name: string
                ) =

                member val arguments : obj option = nativeOnly with get, set
                member val name : string option = nativeOnly with get, set

module Ai_Cf_Meta_Llama_Guard_3_8B_Input =

    [<Global>]
    [<AllowNullLiteral>]
    type messages
        [<ParamObject; Emit("$0")>]
        (
            role: Ai_Cf_Meta_Llama_Guard_3_8B_Input.messages.role,
            content: string
        ) =

        member val role : Ai_Cf_Meta_Llama_Guard_3_8B_Input.messages.role = nativeOnly with get, set
        member val content : string = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type response_format
        [<ParamObject; Emit("$0")>]
        (
            ?``type``: string
        ) =

        member val ``type`` : string option = nativeOnly with get, set

    module messages =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type role =
            | user
            | assistant

module Ai_Cf_Meta_Llama_Guard_3_8B_Output =

    [<Global>]
    [<AllowNullLiteral>]
    type usage
        [<ParamObject; Emit("$0")>]
        (
            ?prompt_tokens: float,
            ?completion_tokens: float,
            ?total_tokens: float
        ) =

        member val prompt_tokens : float option = nativeOnly with get, set
        member val completion_tokens : float option = nativeOnly with get, set
        member val total_tokens : float option = nativeOnly with get, set

    module response =

        module U2 =

            [<Global>]
            [<AllowNullLiteral>]
            type Case2
                [<ParamObject; Emit("$0")>]
                (
                    ?safe: bool,
                    ?categories: ResizeArray<string>
                ) =

                member val safe : bool option = nativeOnly with get, set
                member val categories : ResizeArray<string> option = nativeOnly with get, set

module Ai_Cf_Baai_Bge_Reranker_Base_Input =

    [<Global>]
    [<AllowNullLiteral>]
    type contexts
        [<ParamObject; Emit("$0")>]
        (
            ?text: string
        ) =

        member val text : string option = nativeOnly with get, set

module Ai_Cf_Baai_Bge_Reranker_Base_Output =

    [<Global>]
    [<AllowNullLiteral>]
    type response
        [<ParamObject; Emit("$0")>]
        (
            ?id: float,
            ?score: float
        ) =

        member val id : float option = nativeOnly with get, set
        member val score : float option = nativeOnly with get, set

module Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct_JSON_Mode =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type ``type`` =
        | json_object
        | json_schema

module Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct_Messages =

    [<Global>]
    [<AllowNullLiteral>]
    type messages
        [<ParamObject; Emit("$0")>]
        (
            role: string,
            content: string
        ) =

        member val role : string = nativeOnly with get, set
        member val content : string = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type functions
        [<ParamObject; Emit("$0")>]
        (
            name: string,
            code: string
        ) =

        member val name : string = nativeOnly with get, set
        member val code : string = nativeOnly with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type tools =
        /// <summary>
        /// The name of the tool. More descriptive the better.
        /// </summary>
        abstract member name: string with get, set
        /// <summary>
        /// A brief description of what the tool does.
        /// </summary>
        abstract member description: string with get, set
        /// <summary>
        /// Schema defining the parameters accepted by the tool.
        /// </summary>
        abstract member parameters: Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct_Messages.tools.parameters with get, set
        /// <summary>
        /// Specifies the type of tool (e.g., 'function').
        /// </summary>
        abstract member ``type``: string with get, set
        /// <summary>
        /// Details of the function tool.
        /// </summary>
        abstract member ``function``: Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct_Messages.tools.``function`` with get, set

    module tools =

        [<Global>]
        [<AllowNullLiteral>]
        type parameters
            [<ParamObject; Emit("$0")>]
            (
                ``type``: string,
                properties: Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct_Messages.tools.parameters.properties,
                ?required: ResizeArray<string>
            ) =

            member val ``type`` : string = nativeOnly with get, set
            member val properties : Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct_Messages.tools.parameters.properties = nativeOnly with get, set
            member val required : ResizeArray<string> option = nativeOnly with get, set

        [<Global>]
        [<AllowNullLiteral>]
        type ``function``
            [<ParamObject; Emit("$0")>]
            (
                name: string,
                description: string,
                parameters: Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct_Messages.tools.``function``.parameters
            ) =

            member val name : string = nativeOnly with get, set
            member val description : string = nativeOnly with get, set
            member val parameters : Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct_Messages.tools.``function``.parameters = nativeOnly with get, set

        module parameters =

            [<AllowNullLiteral>]
            [<Interface>]
            type properties =
                [<EmitIndexer>]
                abstract member Item: k: string -> Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct_Messages.tools.parameters.properties.Item with get, set

            module properties =

                [<Global>]
                [<AllowNullLiteral>]
                type Item
                    [<ParamObject; Emit("$0")>]
                    (
                        ``type``: string,
                        description: string
                    ) =

                    member val ``type`` : string = nativeOnly with get, set
                    member val description : string = nativeOnly with get, set

        module ``function`` =

            [<Global>]
            [<AllowNullLiteral>]
            type parameters
                [<ParamObject; Emit("$0")>]
                (
                    ``type``: string,
                    properties: Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct_Messages.tools.``function``.parameters.properties,
                    ?required: ResizeArray<string>
                ) =

                member val ``type`` : string = nativeOnly with get, set
                member val properties : Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct_Messages.tools.``function``.parameters.properties = nativeOnly with get, set
                member val required : ResizeArray<string> option = nativeOnly with get, set

            module parameters =

                [<AllowNullLiteral>]
                [<Interface>]
                type properties =
                    [<EmitIndexer>]
                    abstract member Item: k: string -> Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct_Messages.tools.``function``.parameters.properties.Item with get, set

                module properties =

                    [<Global>]
                    [<AllowNullLiteral>]
                    type Item
                        [<ParamObject; Emit("$0")>]
                        (
                            ``type``: string,
                            description: string
                        ) =

                        member val ``type`` : string = nativeOnly with get, set
                        member val description : string = nativeOnly with get, set

module Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct_JSON_Mode_1 =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type ``type`` =
        | json_object
        | json_schema

module Ai_Cf_Qwen_Qwen2_5_Coder_32B_Instruct_Output =

    [<Global>]
    [<AllowNullLiteral>]
    type usage
        [<ParamObject; Emit("$0")>]
        (
            ?prompt_tokens: float,
            ?completion_tokens: float,
            ?total_tokens: float
        ) =

        member val prompt_tokens : float option = nativeOnly with get, set
        member val completion_tokens : float option = nativeOnly with get, set
        member val total_tokens : float option = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type tool_calls
        [<ParamObject; Emit("$0")>]
        (
            ?arguments: obj,
            ?name: string
        ) =

        member val arguments : obj option = nativeOnly with get, set
        member val name : string option = nativeOnly with get, set

module Ai_Cf_Qwen_Qwq_32B_Messages =

    [<Global>]
    [<AllowNullLiteral>]
    type messages
        [<ParamObject; Emit("$0")>]
        (
            ?role: string,
            ?tool_call_id: string,
            ?content: U3<string, ResizeArray<Ai_Cf_Qwen_Qwq_32B_Messages.messages.content.U3.Case2>, Ai_Cf_Qwen_Qwq_32B_Messages.messages.content.U3.Case3>
        ) =

        member val role : string option = nativeOnly with get, set
        member val tool_call_id : string option = nativeOnly with get, set
        member val content : U3<string, ResizeArray<Ai_Cf_Qwen_Qwq_32B_Messages.messages.content.U3.Case2>, Ai_Cf_Qwen_Qwq_32B_Messages.messages.content.U3.Case3> option = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type functions
        [<ParamObject; Emit("$0")>]
        (
            name: string,
            code: string
        ) =

        member val name : string = nativeOnly with get, set
        member val code : string = nativeOnly with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type tools =
        /// <summary>
        /// The name of the tool. More descriptive the better.
        /// </summary>
        abstract member name: string with get, set
        /// <summary>
        /// A brief description of what the tool does.
        /// </summary>
        abstract member description: string with get, set
        /// <summary>
        /// Schema defining the parameters accepted by the tool.
        /// </summary>
        abstract member parameters: Ai_Cf_Qwen_Qwq_32B_Messages.tools.parameters with get, set
        /// <summary>
        /// Specifies the type of tool (e.g., 'function').
        /// </summary>
        abstract member ``type``: string with get, set
        /// <summary>
        /// Details of the function tool.
        /// </summary>
        abstract member ``function``: Ai_Cf_Qwen_Qwq_32B_Messages.tools.``function`` with get, set

    module messages =

        module content =

            module U3 =

                [<Global>]
                [<AllowNullLiteral>]
                type Case2
                    [<ParamObject; Emit("$0")>]
                    (
                        ?``type``: string,
                        ?text: string,
                        ?image_url: Ai_Cf_Qwen_Qwq_32B_Messages.messages.content.U3.Case2.image_url
                    ) =

                    member val ``type`` : string option = nativeOnly with get, set
                    member val text : string option = nativeOnly with get, set
                    member val image_url : Ai_Cf_Qwen_Qwq_32B_Messages.messages.content.U3.Case2.image_url option = nativeOnly with get, set

                [<Global>]
                [<AllowNullLiteral>]
                type Case3
                    [<ParamObject; Emit("$0")>]
                    (
                        ?``type``: string,
                        ?text: string,
                        ?image_url: Ai_Cf_Qwen_Qwq_32B_Messages.messages.content.U3.Case3.image_url
                    ) =

                    member val ``type`` : string option = nativeOnly with get, set
                    member val text : string option = nativeOnly with get, set
                    member val image_url : Ai_Cf_Qwen_Qwq_32B_Messages.messages.content.U3.Case3.image_url option = nativeOnly with get, set

                module Case2 =

                    [<Global>]
                    [<AllowNullLiteral>]
                    type image_url
                        [<ParamObject; Emit("$0")>]
                        (
                            ?url: string
                        ) =

                        member val url : string option = nativeOnly with get, set

                module Case3 =

                    [<Global>]
                    [<AllowNullLiteral>]
                    type image_url
                        [<ParamObject; Emit("$0")>]
                        (
                            ?url: string
                        ) =

                        member val url : string option = nativeOnly with get, set

    module tools =

        [<Global>]
        [<AllowNullLiteral>]
        type parameters
            [<ParamObject; Emit("$0")>]
            (
                ``type``: string,
                properties: Ai_Cf_Qwen_Qwq_32B_Messages.tools.parameters.properties,
                ?required: ResizeArray<string>
            ) =

            member val ``type`` : string = nativeOnly with get, set
            member val properties : Ai_Cf_Qwen_Qwq_32B_Messages.tools.parameters.properties = nativeOnly with get, set
            member val required : ResizeArray<string> option = nativeOnly with get, set

        [<Global>]
        [<AllowNullLiteral>]
        type ``function``
            [<ParamObject; Emit("$0")>]
            (
                name: string,
                description: string,
                parameters: Ai_Cf_Qwen_Qwq_32B_Messages.tools.``function``.parameters
            ) =

            member val name : string = nativeOnly with get, set
            member val description : string = nativeOnly with get, set
            member val parameters : Ai_Cf_Qwen_Qwq_32B_Messages.tools.``function``.parameters = nativeOnly with get, set

        module parameters =

            [<AllowNullLiteral>]
            [<Interface>]
            type properties =
                [<EmitIndexer>]
                abstract member Item: k: string -> Ai_Cf_Qwen_Qwq_32B_Messages.tools.parameters.properties.Item with get, set

            module properties =

                [<Global>]
                [<AllowNullLiteral>]
                type Item
                    [<ParamObject; Emit("$0")>]
                    (
                        ``type``: string,
                        description: string
                    ) =

                    member val ``type`` : string = nativeOnly with get, set
                    member val description : string = nativeOnly with get, set

        module ``function`` =

            [<Global>]
            [<AllowNullLiteral>]
            type parameters
                [<ParamObject; Emit("$0")>]
                (
                    ``type``: string,
                    properties: Ai_Cf_Qwen_Qwq_32B_Messages.tools.``function``.parameters.properties,
                    ?required: ResizeArray<string>
                ) =

                member val ``type`` : string = nativeOnly with get, set
                member val properties : Ai_Cf_Qwen_Qwq_32B_Messages.tools.``function``.parameters.properties = nativeOnly with get, set
                member val required : ResizeArray<string> option = nativeOnly with get, set

            module parameters =

                [<AllowNullLiteral>]
                [<Interface>]
                type properties =
                    [<EmitIndexer>]
                    abstract member Item: k: string -> Ai_Cf_Qwen_Qwq_32B_Messages.tools.``function``.parameters.properties.Item with get, set

                module properties =

                    [<Global>]
                    [<AllowNullLiteral>]
                    type Item
                        [<ParamObject; Emit("$0")>]
                        (
                            ``type``: string,
                            description: string
                        ) =

                        member val ``type`` : string = nativeOnly with get, set
                        member val description : string = nativeOnly with get, set

module Ai_Cf_Qwen_Qwq_32B_Output =

    [<Global>]
    [<AllowNullLiteral>]
    type usage
        [<ParamObject; Emit("$0")>]
        (
            ?prompt_tokens: float,
            ?completion_tokens: float,
            ?total_tokens: float
        ) =

        member val prompt_tokens : float option = nativeOnly with get, set
        member val completion_tokens : float option = nativeOnly with get, set
        member val total_tokens : float option = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type tool_calls
        [<ParamObject; Emit("$0")>]
        (
            ?arguments: obj,
            ?name: string
        ) =

        member val arguments : obj option = nativeOnly with get, set
        member val name : string option = nativeOnly with get, set

module Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct_Messages =

    [<Global>]
    [<AllowNullLiteral>]
    type messages
        [<ParamObject; Emit("$0")>]
        (
            ?role: string,
            ?tool_call_id: string,
            ?content: U3<string, ResizeArray<Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct_Messages.messages.content.U3.Case2>, Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct_Messages.messages.content.U3.Case3>
        ) =

        member val role : string option = nativeOnly with get, set
        member val tool_call_id : string option = nativeOnly with get, set
        member val content : U3<string, ResizeArray<Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct_Messages.messages.content.U3.Case2>, Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct_Messages.messages.content.U3.Case3> option = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type functions
        [<ParamObject; Emit("$0")>]
        (
            name: string,
            code: string
        ) =

        member val name : string = nativeOnly with get, set
        member val code : string = nativeOnly with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type tools =
        /// <summary>
        /// The name of the tool. More descriptive the better.
        /// </summary>
        abstract member name: string with get, set
        /// <summary>
        /// A brief description of what the tool does.
        /// </summary>
        abstract member description: string with get, set
        /// <summary>
        /// Schema defining the parameters accepted by the tool.
        /// </summary>
        abstract member parameters: Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct_Messages.tools.parameters with get, set
        /// <summary>
        /// Specifies the type of tool (e.g., 'function').
        /// </summary>
        abstract member ``type``: string with get, set
        /// <summary>
        /// Details of the function tool.
        /// </summary>
        abstract member ``function``: Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct_Messages.tools.``function`` with get, set

    module messages =

        module content =

            module U3 =

                [<Global>]
                [<AllowNullLiteral>]
                type Case2
                    [<ParamObject; Emit("$0")>]
                    (
                        ?``type``: string,
                        ?text: string,
                        ?image_url: Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct_Messages.messages.content.U3.Case2.image_url
                    ) =

                    member val ``type`` : string option = nativeOnly with get, set
                    member val text : string option = nativeOnly with get, set
                    member val image_url : Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct_Messages.messages.content.U3.Case2.image_url option = nativeOnly with get, set

                [<Global>]
                [<AllowNullLiteral>]
                type Case3
                    [<ParamObject; Emit("$0")>]
                    (
                        ?``type``: string,
                        ?text: string,
                        ?image_url: Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct_Messages.messages.content.U3.Case3.image_url
                    ) =

                    member val ``type`` : string option = nativeOnly with get, set
                    member val text : string option = nativeOnly with get, set
                    member val image_url : Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct_Messages.messages.content.U3.Case3.image_url option = nativeOnly with get, set

                module Case2 =

                    [<Global>]
                    [<AllowNullLiteral>]
                    type image_url
                        [<ParamObject; Emit("$0")>]
                        (
                            ?url: string
                        ) =

                        member val url : string option = nativeOnly with get, set

                module Case3 =

                    [<Global>]
                    [<AllowNullLiteral>]
                    type image_url
                        [<ParamObject; Emit("$0")>]
                        (
                            ?url: string
                        ) =

                        member val url : string option = nativeOnly with get, set

    module tools =

        [<Global>]
        [<AllowNullLiteral>]
        type parameters
            [<ParamObject; Emit("$0")>]
            (
                ``type``: string,
                properties: Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct_Messages.tools.parameters.properties,
                ?required: ResizeArray<string>
            ) =

            member val ``type`` : string = nativeOnly with get, set
            member val properties : Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct_Messages.tools.parameters.properties = nativeOnly with get, set
            member val required : ResizeArray<string> option = nativeOnly with get, set

        [<Global>]
        [<AllowNullLiteral>]
        type ``function``
            [<ParamObject; Emit("$0")>]
            (
                name: string,
                description: string,
                parameters: Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct_Messages.tools.``function``.parameters
            ) =

            member val name : string = nativeOnly with get, set
            member val description : string = nativeOnly with get, set
            member val parameters : Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct_Messages.tools.``function``.parameters = nativeOnly with get, set

        module parameters =

            [<AllowNullLiteral>]
            [<Interface>]
            type properties =
                [<EmitIndexer>]
                abstract member Item: k: string -> Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct_Messages.tools.parameters.properties.Item with get, set

            module properties =

                [<Global>]
                [<AllowNullLiteral>]
                type Item
                    [<ParamObject; Emit("$0")>]
                    (
                        ``type``: string,
                        description: string
                    ) =

                    member val ``type`` : string = nativeOnly with get, set
                    member val description : string = nativeOnly with get, set

        module ``function`` =

            [<Global>]
            [<AllowNullLiteral>]
            type parameters
                [<ParamObject; Emit("$0")>]
                (
                    ``type``: string,
                    properties: Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct_Messages.tools.``function``.parameters.properties,
                    ?required: ResizeArray<string>
                ) =

                member val ``type`` : string = nativeOnly with get, set
                member val properties : Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct_Messages.tools.``function``.parameters.properties = nativeOnly with get, set
                member val required : ResizeArray<string> option = nativeOnly with get, set

            module parameters =

                [<AllowNullLiteral>]
                [<Interface>]
                type properties =
                    [<EmitIndexer>]
                    abstract member Item: k: string -> Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct_Messages.tools.``function``.parameters.properties.Item with get, set

                module properties =

                    [<Global>]
                    [<AllowNullLiteral>]
                    type Item
                        [<ParamObject; Emit("$0")>]
                        (
                            ``type``: string,
                            description: string
                        ) =

                        member val ``type`` : string = nativeOnly with get, set
                        member val description : string = nativeOnly with get, set

module Ai_Cf_Mistralai_Mistral_Small_3_1_24B_Instruct_Output =

    [<Global>]
    [<AllowNullLiteral>]
    type usage
        [<ParamObject; Emit("$0")>]
        (
            ?prompt_tokens: float,
            ?completion_tokens: float,
            ?total_tokens: float
        ) =

        member val prompt_tokens : float option = nativeOnly with get, set
        member val completion_tokens : float option = nativeOnly with get, set
        member val total_tokens : float option = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type tool_calls
        [<ParamObject; Emit("$0")>]
        (
            ?arguments: obj,
            ?name: string
        ) =

        member val arguments : obj option = nativeOnly with get, set
        member val name : string option = nativeOnly with get, set

module Ai_Cf_Google_Gemma_3_12B_It_Messages =

    [<Global>]
    [<AllowNullLiteral>]
    type messages
        [<ParamObject; Emit("$0")>]
        (
            ?role: string,
            ?content: U2<string, ResizeArray<Ai_Cf_Google_Gemma_3_12B_It_Messages.messages.content.U2.Case2>>
        ) =

        member val role : string option = nativeOnly with get, set
        member val content : U2<string, ResizeArray<Ai_Cf_Google_Gemma_3_12B_It_Messages.messages.content.U2.Case2>> option = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type functions
        [<ParamObject; Emit("$0")>]
        (
            name: string,
            code: string
        ) =

        member val name : string = nativeOnly with get, set
        member val code : string = nativeOnly with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type tools =
        /// <summary>
        /// The name of the tool. More descriptive the better.
        /// </summary>
        abstract member name: string with get, set
        /// <summary>
        /// A brief description of what the tool does.
        /// </summary>
        abstract member description: string with get, set
        /// <summary>
        /// Schema defining the parameters accepted by the tool.
        /// </summary>
        abstract member parameters: Ai_Cf_Google_Gemma_3_12B_It_Messages.tools.parameters with get, set
        /// <summary>
        /// Specifies the type of tool (e.g., 'function').
        /// </summary>
        abstract member ``type``: string with get, set
        /// <summary>
        /// Details of the function tool.
        /// </summary>
        abstract member ``function``: Ai_Cf_Google_Gemma_3_12B_It_Messages.tools.``function`` with get, set

    module messages =

        module content =

            module U2 =

                [<Global>]
                [<AllowNullLiteral>]
                type Case2
                    [<ParamObject; Emit("$0")>]
                    (
                        ?``type``: string,
                        ?text: string,
                        ?image_url: Ai_Cf_Google_Gemma_3_12B_It_Messages.messages.content.U2.Case2.image_url
                    ) =

                    member val ``type`` : string option = nativeOnly with get, set
                    member val text : string option = nativeOnly with get, set
                    member val image_url : Ai_Cf_Google_Gemma_3_12B_It_Messages.messages.content.U2.Case2.image_url option = nativeOnly with get, set

                module Case2 =

                    [<Global>]
                    [<AllowNullLiteral>]
                    type image_url
                        [<ParamObject; Emit("$0")>]
                        (
                            ?url: string
                        ) =

                        member val url : string option = nativeOnly with get, set

    module tools =

        [<Global>]
        [<AllowNullLiteral>]
        type parameters
            [<ParamObject; Emit("$0")>]
            (
                ``type``: string,
                properties: Ai_Cf_Google_Gemma_3_12B_It_Messages.tools.parameters.properties,
                ?required: ResizeArray<string>
            ) =

            member val ``type`` : string = nativeOnly with get, set
            member val properties : Ai_Cf_Google_Gemma_3_12B_It_Messages.tools.parameters.properties = nativeOnly with get, set
            member val required : ResizeArray<string> option = nativeOnly with get, set

        [<Global>]
        [<AllowNullLiteral>]
        type ``function``
            [<ParamObject; Emit("$0")>]
            (
                name: string,
                description: string,
                parameters: Ai_Cf_Google_Gemma_3_12B_It_Messages.tools.``function``.parameters
            ) =

            member val name : string = nativeOnly with get, set
            member val description : string = nativeOnly with get, set
            member val parameters : Ai_Cf_Google_Gemma_3_12B_It_Messages.tools.``function``.parameters = nativeOnly with get, set

        module parameters =

            [<AllowNullLiteral>]
            [<Interface>]
            type properties =
                [<EmitIndexer>]
                abstract member Item: k: string -> Ai_Cf_Google_Gemma_3_12B_It_Messages.tools.parameters.properties.Item with get, set

            module properties =

                [<Global>]
                [<AllowNullLiteral>]
                type Item
                    [<ParamObject; Emit("$0")>]
                    (
                        ``type``: string,
                        description: string
                    ) =

                    member val ``type`` : string = nativeOnly with get, set
                    member val description : string = nativeOnly with get, set

        module ``function`` =

            [<Global>]
            [<AllowNullLiteral>]
            type parameters
                [<ParamObject; Emit("$0")>]
                (
                    ``type``: string,
                    properties: Ai_Cf_Google_Gemma_3_12B_It_Messages.tools.``function``.parameters.properties,
                    ?required: ResizeArray<string>
                ) =

                member val ``type`` : string = nativeOnly with get, set
                member val properties : Ai_Cf_Google_Gemma_3_12B_It_Messages.tools.``function``.parameters.properties = nativeOnly with get, set
                member val required : ResizeArray<string> option = nativeOnly with get, set

            module parameters =

                [<AllowNullLiteral>]
                [<Interface>]
                type properties =
                    [<EmitIndexer>]
                    abstract member Item: k: string -> Ai_Cf_Google_Gemma_3_12B_It_Messages.tools.``function``.parameters.properties.Item with get, set

                module properties =

                    [<Global>]
                    [<AllowNullLiteral>]
                    type Item
                        [<ParamObject; Emit("$0")>]
                        (
                            ``type``: string,
                            description: string
                        ) =

                        member val ``type`` : string = nativeOnly with get, set
                        member val description : string = nativeOnly with get, set

module Ai_Cf_Google_Gemma_3_12B_It_Output =

    [<Global>]
    [<AllowNullLiteral>]
    type usage
        [<ParamObject; Emit("$0")>]
        (
            ?prompt_tokens: float,
            ?completion_tokens: float,
            ?total_tokens: float
        ) =

        member val prompt_tokens : float option = nativeOnly with get, set
        member val completion_tokens : float option = nativeOnly with get, set
        member val total_tokens : float option = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type tool_calls
        [<ParamObject; Emit("$0")>]
        (
            ?arguments: obj,
            ?name: string
        ) =

        member val arguments : obj option = nativeOnly with get, set
        member val name : string option = nativeOnly with get, set

module Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_JSON_Mode =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type ``type`` =
        | json_object
        | json_schema

module Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages =

    [<Global>]
    [<AllowNullLiteral>]
    type messages
        [<ParamObject; Emit("$0")>]
        (
            ?role: string,
            ?tool_call_id: string,
            ?content: U3<string, ResizeArray<Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages.messages.content.U3.Case2>, Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages.messages.content.U3.Case3>
        ) =

        member val role : string option = nativeOnly with get, set
        member val tool_call_id : string option = nativeOnly with get, set
        member val content : U3<string, ResizeArray<Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages.messages.content.U3.Case2>, Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages.messages.content.U3.Case3> option = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type functions
        [<ParamObject; Emit("$0")>]
        (
            name: string,
            code: string
        ) =

        member val name : string = nativeOnly with get, set
        member val code : string = nativeOnly with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type tools =
        /// <summary>
        /// The name of the tool. More descriptive the better.
        /// </summary>
        abstract member name: string with get, set
        /// <summary>
        /// A brief description of what the tool does.
        /// </summary>
        abstract member description: string with get, set
        /// <summary>
        /// Schema defining the parameters accepted by the tool.
        /// </summary>
        abstract member parameters: Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages.tools.parameters with get, set
        /// <summary>
        /// Specifies the type of tool (e.g., 'function').
        /// </summary>
        abstract member ``type``: string with get, set
        /// <summary>
        /// Details of the function tool.
        /// </summary>
        abstract member ``function``: Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages.tools.``function`` with get, set

    module messages =

        module content =

            module U3 =

                [<Global>]
                [<AllowNullLiteral>]
                type Case2
                    [<ParamObject; Emit("$0")>]
                    (
                        ?``type``: string,
                        ?text: string,
                        ?image_url: Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages.messages.content.U3.Case2.image_url
                    ) =

                    member val ``type`` : string option = nativeOnly with get, set
                    member val text : string option = nativeOnly with get, set
                    member val image_url : Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages.messages.content.U3.Case2.image_url option = nativeOnly with get, set

                [<Global>]
                [<AllowNullLiteral>]
                type Case3
                    [<ParamObject; Emit("$0")>]
                    (
                        ?``type``: string,
                        ?text: string,
                        ?image_url: Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages.messages.content.U3.Case3.image_url
                    ) =

                    member val ``type`` : string option = nativeOnly with get, set
                    member val text : string option = nativeOnly with get, set
                    member val image_url : Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages.messages.content.U3.Case3.image_url option = nativeOnly with get, set

                module Case2 =

                    [<Global>]
                    [<AllowNullLiteral>]
                    type image_url
                        [<ParamObject; Emit("$0")>]
                        (
                            ?url: string
                        ) =

                        member val url : string option = nativeOnly with get, set

                module Case3 =

                    [<Global>]
                    [<AllowNullLiteral>]
                    type image_url
                        [<ParamObject; Emit("$0")>]
                        (
                            ?url: string
                        ) =

                        member val url : string option = nativeOnly with get, set

    module tools =

        [<Global>]
        [<AllowNullLiteral>]
        type parameters
            [<ParamObject; Emit("$0")>]
            (
                ``type``: string,
                properties: Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages.tools.parameters.properties,
                ?required: ResizeArray<string>
            ) =

            member val ``type`` : string = nativeOnly with get, set
            member val properties : Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages.tools.parameters.properties = nativeOnly with get, set
            member val required : ResizeArray<string> option = nativeOnly with get, set

        [<Global>]
        [<AllowNullLiteral>]
        type ``function``
            [<ParamObject; Emit("$0")>]
            (
                name: string,
                description: string,
                parameters: Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages.tools.``function``.parameters
            ) =

            member val name : string = nativeOnly with get, set
            member val description : string = nativeOnly with get, set
            member val parameters : Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages.tools.``function``.parameters = nativeOnly with get, set

        module parameters =

            [<AllowNullLiteral>]
            [<Interface>]
            type properties =
                [<EmitIndexer>]
                abstract member Item: k: string -> Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages.tools.parameters.properties.Item with get, set

            module properties =

                [<Global>]
                [<AllowNullLiteral>]
                type Item
                    [<ParamObject; Emit("$0")>]
                    (
                        ``type``: string,
                        description: string
                    ) =

                    member val ``type`` : string = nativeOnly with get, set
                    member val description : string = nativeOnly with get, set

        module ``function`` =

            [<Global>]
            [<AllowNullLiteral>]
            type parameters
                [<ParamObject; Emit("$0")>]
                (
                    ``type``: string,
                    properties: Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages.tools.``function``.parameters.properties,
                    ?required: ResizeArray<string>
                ) =

                member val ``type`` : string = nativeOnly with get, set
                member val properties : Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages.tools.``function``.parameters.properties = nativeOnly with get, set
                member val required : ResizeArray<string> option = nativeOnly with get, set

            module parameters =

                [<AllowNullLiteral>]
                [<Interface>]
                type properties =
                    [<EmitIndexer>]
                    abstract member Item: k: string -> Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages.tools.``function``.parameters.properties.Item with get, set

                module properties =

                    [<Global>]
                    [<AllowNullLiteral>]
                    type Item
                        [<ParamObject; Emit("$0")>]
                        (
                            ``type``: string,
                            description: string
                        ) =

                        member val ``type`` : string = nativeOnly with get, set
                        member val description : string = nativeOnly with get, set

module Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages_Inner =

    [<Global>]
    [<AllowNullLiteral>]
    type messages
        [<ParamObject; Emit("$0")>]
        (
            ?role: string,
            ?tool_call_id: string,
            ?content: U3<string, ResizeArray<Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages_Inner.messages.content.U3.Case2>, Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages_Inner.messages.content.U3.Case3>
        ) =

        member val role : string option = nativeOnly with get, set
        member val tool_call_id : string option = nativeOnly with get, set
        member val content : U3<string, ResizeArray<Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages_Inner.messages.content.U3.Case2>, Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages_Inner.messages.content.U3.Case3> option = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type functions
        [<ParamObject; Emit("$0")>]
        (
            name: string,
            code: string
        ) =

        member val name : string = nativeOnly with get, set
        member val code : string = nativeOnly with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type tools =
        /// <summary>
        /// The name of the tool. More descriptive the better.
        /// </summary>
        abstract member name: string with get, set
        /// <summary>
        /// A brief description of what the tool does.
        /// </summary>
        abstract member description: string with get, set
        /// <summary>
        /// Schema defining the parameters accepted by the tool.
        /// </summary>
        abstract member parameters: Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages_Inner.tools.parameters with get, set
        /// <summary>
        /// Specifies the type of tool (e.g., 'function').
        /// </summary>
        abstract member ``type``: string with get, set
        /// <summary>
        /// Details of the function tool.
        /// </summary>
        abstract member ``function``: Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages_Inner.tools.``function`` with get, set

    module messages =

        module content =

            module U3 =

                [<Global>]
                [<AllowNullLiteral>]
                type Case2
                    [<ParamObject; Emit("$0")>]
                    (
                        ?``type``: string,
                        ?text: string,
                        ?image_url: Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages_Inner.messages.content.U3.Case2.image_url
                    ) =

                    member val ``type`` : string option = nativeOnly with get, set
                    member val text : string option = nativeOnly with get, set
                    member val image_url : Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages_Inner.messages.content.U3.Case2.image_url option = nativeOnly with get, set

                [<Global>]
                [<AllowNullLiteral>]
                type Case3
                    [<ParamObject; Emit("$0")>]
                    (
                        ?``type``: string,
                        ?text: string,
                        ?image_url: Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages_Inner.messages.content.U3.Case3.image_url
                    ) =

                    member val ``type`` : string option = nativeOnly with get, set
                    member val text : string option = nativeOnly with get, set
                    member val image_url : Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages_Inner.messages.content.U3.Case3.image_url option = nativeOnly with get, set

                module Case2 =

                    [<Global>]
                    [<AllowNullLiteral>]
                    type image_url
                        [<ParamObject; Emit("$0")>]
                        (
                            ?url: string
                        ) =

                        member val url : string option = nativeOnly with get, set

                module Case3 =

                    [<Global>]
                    [<AllowNullLiteral>]
                    type image_url
                        [<ParamObject; Emit("$0")>]
                        (
                            ?url: string
                        ) =

                        member val url : string option = nativeOnly with get, set

    module tools =

        [<Global>]
        [<AllowNullLiteral>]
        type parameters
            [<ParamObject; Emit("$0")>]
            (
                ``type``: string,
                properties: Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages_Inner.tools.parameters.properties,
                ?required: ResizeArray<string>
            ) =

            member val ``type`` : string = nativeOnly with get, set
            member val properties : Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages_Inner.tools.parameters.properties = nativeOnly with get, set
            member val required : ResizeArray<string> option = nativeOnly with get, set

        [<Global>]
        [<AllowNullLiteral>]
        type ``function``
            [<ParamObject; Emit("$0")>]
            (
                name: string,
                description: string,
                parameters: Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages_Inner.tools.``function``.parameters
            ) =

            member val name : string = nativeOnly with get, set
            member val description : string = nativeOnly with get, set
            member val parameters : Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages_Inner.tools.``function``.parameters = nativeOnly with get, set

        module parameters =

            [<AllowNullLiteral>]
            [<Interface>]
            type properties =
                [<EmitIndexer>]
                abstract member Item: k: string -> Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages_Inner.tools.parameters.properties.Item with get, set

            module properties =

                [<Global>]
                [<AllowNullLiteral>]
                type Item
                    [<ParamObject; Emit("$0")>]
                    (
                        ``type``: string,
                        description: string
                    ) =

                    member val ``type`` : string = nativeOnly with get, set
                    member val description : string = nativeOnly with get, set

        module ``function`` =

            [<Global>]
            [<AllowNullLiteral>]
            type parameters
                [<ParamObject; Emit("$0")>]
                (
                    ``type``: string,
                    properties: Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages_Inner.tools.``function``.parameters.properties,
                    ?required: ResizeArray<string>
                ) =

                member val ``type`` : string = nativeOnly with get, set
                member val properties : Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages_Inner.tools.``function``.parameters.properties = nativeOnly with get, set
                member val required : ResizeArray<string> option = nativeOnly with get, set

            module parameters =

                [<AllowNullLiteral>]
                [<Interface>]
                type properties =
                    [<EmitIndexer>]
                    abstract member Item: k: string -> Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Messages_Inner.tools.``function``.parameters.properties.Item with get, set

                module properties =

                    [<Global>]
                    [<AllowNullLiteral>]
                    type Item
                        [<ParamObject; Emit("$0")>]
                        (
                            ``type``: string,
                            description: string
                        ) =

                        member val ``type`` : string = nativeOnly with get, set
                        member val description : string = nativeOnly with get, set

module Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Output =

    [<Global>]
    [<AllowNullLiteral>]
    type usage
        [<ParamObject; Emit("$0")>]
        (
            ?prompt_tokens: float,
            ?completion_tokens: float,
            ?total_tokens: float
        ) =

        member val prompt_tokens : float option = nativeOnly with get, set
        member val completion_tokens : float option = nativeOnly with get, set
        member val total_tokens : float option = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type tool_calls
        [<ParamObject; Emit("$0")>]
        (
            ?id: string,
            ?``type``: string,
            ?``function``: Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Output.tool_calls.``function``
        ) =

        member val id : string option = nativeOnly with get, set
        member val ``type`` : string option = nativeOnly with get, set
        member val ``function`` : Ai_Cf_Meta_Llama_4_Scout_17B_16E_Instruct_Output.tool_calls.``function`` option = nativeOnly with get, set

    module tool_calls =

        [<Global>]
        [<AllowNullLiteral>]
        type ``function``
            [<ParamObject; Emit("$0")>]
            (
                ?name: string,
                ?arguments: obj
            ) =

            member val name : string option = nativeOnly with get, set
            member val arguments : obj option = nativeOnly with get, set

module Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_JSON_Mode =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type ``type`` =
        | json_object
        | json_schema

module Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Messages =

    [<Global>]
    [<AllowNullLiteral>]
    type messages
        [<ParamObject; Emit("$0")>]
        (
            role: string,
            content: string
        ) =

        member val role : string = nativeOnly with get, set
        member val content : string = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type functions
        [<ParamObject; Emit("$0")>]
        (
            name: string,
            code: string
        ) =

        member val name : string = nativeOnly with get, set
        member val code : string = nativeOnly with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type tools =
        /// <summary>
        /// The name of the tool. More descriptive the better.
        /// </summary>
        abstract member name: string with get, set
        /// <summary>
        /// A brief description of what the tool does.
        /// </summary>
        abstract member description: string with get, set
        /// <summary>
        /// Schema defining the parameters accepted by the tool.
        /// </summary>
        abstract member parameters: Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Messages.tools.parameters with get, set
        /// <summary>
        /// Specifies the type of tool (e.g., 'function').
        /// </summary>
        abstract member ``type``: string with get, set
        /// <summary>
        /// Details of the function tool.
        /// </summary>
        abstract member ``function``: Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Messages.tools.``function`` with get, set

    module tools =

        [<Global>]
        [<AllowNullLiteral>]
        type parameters
            [<ParamObject; Emit("$0")>]
            (
                ``type``: string,
                properties: Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Messages.tools.parameters.properties,
                ?required: ResizeArray<string>
            ) =

            member val ``type`` : string = nativeOnly with get, set
            member val properties : Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Messages.tools.parameters.properties = nativeOnly with get, set
            member val required : ResizeArray<string> option = nativeOnly with get, set

        [<Global>]
        [<AllowNullLiteral>]
        type ``function``
            [<ParamObject; Emit("$0")>]
            (
                name: string,
                description: string,
                parameters: Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Messages.tools.``function``.parameters
            ) =

            member val name : string = nativeOnly with get, set
            member val description : string = nativeOnly with get, set
            member val parameters : Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Messages.tools.``function``.parameters = nativeOnly with get, set

        module parameters =

            [<AllowNullLiteral>]
            [<Interface>]
            type properties =
                [<EmitIndexer>]
                abstract member Item: k: string -> Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Messages.tools.parameters.properties.Item with get, set

            module properties =

                [<Global>]
                [<AllowNullLiteral>]
                type Item
                    [<ParamObject; Emit("$0")>]
                    (
                        ``type``: string,
                        description: string
                    ) =

                    member val ``type`` : string = nativeOnly with get, set
                    member val description : string = nativeOnly with get, set

        module ``function`` =

            [<Global>]
            [<AllowNullLiteral>]
            type parameters
                [<ParamObject; Emit("$0")>]
                (
                    ``type``: string,
                    properties: Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Messages.tools.``function``.parameters.properties,
                    ?required: ResizeArray<string>
                ) =

                member val ``type`` : string = nativeOnly with get, set
                member val properties : Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Messages.tools.``function``.parameters.properties = nativeOnly with get, set
                member val required : ResizeArray<string> option = nativeOnly with get, set

            module parameters =

                [<AllowNullLiteral>]
                [<Interface>]
                type properties =
                    [<EmitIndexer>]
                    abstract member Item: k: string -> Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Messages.tools.``function``.parameters.properties.Item with get, set

                module properties =

                    [<Global>]
                    [<AllowNullLiteral>]
                    type Item
                        [<ParamObject; Emit("$0")>]
                        (
                            ``type``: string,
                            description: string
                        ) =

                        member val ``type`` : string = nativeOnly with get, set
                        member val description : string = nativeOnly with get, set

module Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_JSON_Mode_1 =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type ``type`` =
        | json_object
        | json_schema

module Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_JSON_Mode_2 =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type ``type`` =
        | json_object
        | json_schema

module Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Messages_1 =

    [<Global>]
    [<AllowNullLiteral>]
    type messages
        [<ParamObject; Emit("$0")>]
        (
            role: string,
            content: string
        ) =

        member val role : string = nativeOnly with get, set
        member val content : string = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type functions
        [<ParamObject; Emit("$0")>]
        (
            name: string,
            code: string
        ) =

        member val name : string = nativeOnly with get, set
        member val code : string = nativeOnly with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type tools =
        /// <summary>
        /// The name of the tool. More descriptive the better.
        /// </summary>
        abstract member name: string with get, set
        /// <summary>
        /// A brief description of what the tool does.
        /// </summary>
        abstract member description: string with get, set
        /// <summary>
        /// Schema defining the parameters accepted by the tool.
        /// </summary>
        abstract member parameters: Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Messages_1.tools.parameters with get, set
        /// <summary>
        /// Specifies the type of tool (e.g., 'function').
        /// </summary>
        abstract member ``type``: string with get, set
        /// <summary>
        /// Details of the function tool.
        /// </summary>
        abstract member ``function``: Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Messages_1.tools.``function`` with get, set

    module tools =

        [<Global>]
        [<AllowNullLiteral>]
        type parameters
            [<ParamObject; Emit("$0")>]
            (
                ``type``: string,
                properties: Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Messages_1.tools.parameters.properties,
                ?required: ResizeArray<string>
            ) =

            member val ``type`` : string = nativeOnly with get, set
            member val properties : Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Messages_1.tools.parameters.properties = nativeOnly with get, set
            member val required : ResizeArray<string> option = nativeOnly with get, set

        [<Global>]
        [<AllowNullLiteral>]
        type ``function``
            [<ParamObject; Emit("$0")>]
            (
                name: string,
                description: string,
                parameters: Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Messages_1.tools.``function``.parameters
            ) =

            member val name : string = nativeOnly with get, set
            member val description : string = nativeOnly with get, set
            member val parameters : Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Messages_1.tools.``function``.parameters = nativeOnly with get, set

        module parameters =

            [<AllowNullLiteral>]
            [<Interface>]
            type properties =
                [<EmitIndexer>]
                abstract member Item: k: string -> Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Messages_1.tools.parameters.properties.Item with get, set

            module properties =

                [<Global>]
                [<AllowNullLiteral>]
                type Item
                    [<ParamObject; Emit("$0")>]
                    (
                        ``type``: string,
                        description: string
                    ) =

                    member val ``type`` : string = nativeOnly with get, set
                    member val description : string = nativeOnly with get, set

        module ``function`` =

            [<Global>]
            [<AllowNullLiteral>]
            type parameters
                [<ParamObject; Emit("$0")>]
                (
                    ``type``: string,
                    properties: Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Messages_1.tools.``function``.parameters.properties,
                    ?required: ResizeArray<string>
                ) =

                member val ``type`` : string = nativeOnly with get, set
                member val properties : Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Messages_1.tools.``function``.parameters.properties = nativeOnly with get, set
                member val required : ResizeArray<string> option = nativeOnly with get, set

            module parameters =

                [<AllowNullLiteral>]
                [<Interface>]
                type properties =
                    [<EmitIndexer>]
                    abstract member Item: k: string -> Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Messages_1.tools.``function``.parameters.properties.Item with get, set

                module properties =

                    [<Global>]
                    [<AllowNullLiteral>]
                    type Item
                        [<ParamObject; Emit("$0")>]
                        (
                            ``type``: string,
                            description: string
                        ) =

                        member val ``type`` : string = nativeOnly with get, set
                        member val description : string = nativeOnly with get, set

module Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_JSON_Mode_3 =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type ``type`` =
        | json_object
        | json_schema

module Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Chat_Completion_Response =

    [<Global>]
    [<AllowNullLiteral>]
    type choices
        [<ParamObject; Emit("$0")>]
        (
            ?index: float,
            ?message: Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Chat_Completion_Response.choices.message,
            ?finish_reason: string,
            ?stop_reason: U2<string, obj>,
            ?logprobs: U2<Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Chat_Completion_Response.choices.logprobs.U2.Case1, obj>
        ) =

        member val index : float option = nativeOnly with get, set
        member val message : Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Chat_Completion_Response.choices.message option = nativeOnly with get, set
        member val finish_reason : string option = nativeOnly with get, set
        member val stop_reason : U2<string, obj> option = nativeOnly with get, set
        member val logprobs : U2<Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Chat_Completion_Response.choices.logprobs.U2.Case1, obj> option = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type usage
        [<ParamObject; Emit("$0")>]
        (
            ?prompt_tokens: float,
            ?completion_tokens: float,
            ?total_tokens: float
        ) =

        member val prompt_tokens : float option = nativeOnly with get, set
        member val completion_tokens : float option = nativeOnly with get, set
        member val total_tokens : float option = nativeOnly with get, set

    module choices =

        [<Global>]
        [<AllowNullLiteral>]
        type message
            [<ParamObject; Emit("$0")>]
            (
                role: string,
                content: string,
                ?reasoning_content: string,
                ?tool_calls: ResizeArray<Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Chat_Completion_Response.choices.message.tool_calls>
            ) =

            member val role : string = nativeOnly with get, set
            member val content : string = nativeOnly with get, set
            member val reasoning_content : string option = nativeOnly with get, set
            member val tool_calls : ResizeArray<Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Chat_Completion_Response.choices.message.tool_calls> option = nativeOnly with get, set

        module message =

            [<Global>]
            [<AllowNullLiteral>]
            type tool_calls
                [<ParamObject; Emit("$0")>]
                (
                    id: string,
                    ``type``: string,
                    ``function``: Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Chat_Completion_Response.choices.message.tool_calls.``function``
                ) =

                member val id : string = nativeOnly with get, set
                member val ``type`` : string = nativeOnly with get, set
                member val ``function`` : Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Chat_Completion_Response.choices.message.tool_calls.``function`` = nativeOnly with get, set

            module tool_calls =

                [<Global>]
                [<AllowNullLiteral>]
                type ``function``
                    [<ParamObject; Emit("$0")>]
                    (
                        name: string,
                        arguments: string
                    ) =

                    member val name : string = nativeOnly with get, set
                    member val arguments : string = nativeOnly with get, set

        module logprobs =

            module U2 =

                [<Global>]
                [<AllowNullLiteral>]
                type Case1
                    [<ParamObject; Emit("$0")>]
                    (
                    ) =

                    class end

    module prompt_logprobs =

        module U2 =

            [<Global>]
            [<AllowNullLiteral>]
            type Case1
                [<ParamObject; Emit("$0")>]
                (
                ) =

                class end

module Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Text_Completion_Response =

    [<Global>]
    [<AllowNullLiteral>]
    type choices
        [<ParamObject; Emit("$0")>]
        (
            index: float,
            text: string,
            finish_reason: string,
            ?stop_reason: U2<string, obj>,
            ?logprobs: U2<Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Text_Completion_Response.choices.logprobs.U2.Case1, obj>,
            ?prompt_logprobs: U2<Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Text_Completion_Response.choices.prompt_logprobs.U2.Case1, obj>
        ) =

        member val index : float = nativeOnly with get, set
        member val text : string = nativeOnly with get, set
        member val finish_reason : string = nativeOnly with get, set
        member val stop_reason : U2<string, obj> option = nativeOnly with get, set
        member val logprobs : U2<Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Text_Completion_Response.choices.logprobs.U2.Case1, obj> option = nativeOnly with get, set
        member val prompt_logprobs : U2<Ai_Cf_Qwen_Qwen3_30B_A3B_Fp8_Text_Completion_Response.choices.prompt_logprobs.U2.Case1, obj> option = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type usage
        [<ParamObject; Emit("$0")>]
        (
            ?prompt_tokens: float,
            ?completion_tokens: float,
            ?total_tokens: float
        ) =

        member val prompt_tokens : float option = nativeOnly with get, set
        member val completion_tokens : float option = nativeOnly with get, set
        member val total_tokens : float option = nativeOnly with get, set

    module choices =

        module logprobs =

            module U2 =

                [<Global>]
                [<AllowNullLiteral>]
                type Case1
                    [<ParamObject; Emit("$0")>]
                    (
                    ) =

                    class end

        module prompt_logprobs =

            module U2 =

                [<Global>]
                [<AllowNullLiteral>]
                type Case1
                    [<ParamObject; Emit("$0")>]
                    (
                    ) =

                    class end

module Ai_Cf_Deepgram_Nova_3_Input =

    [<Global>]
    [<AllowNullLiteral>]
    type audio
        [<ParamObject; Emit("$0")>]
        (
            body: obj,
            contentType: string
        ) =

        member val body : obj = nativeOnly with get, set
        member val contentType : string = nativeOnly with get, set

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type custom_topic_mode =
        | extended
        | strict

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type custom_intent_mode =
        | extended
        | strict

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type encoding =
        | linear16
        | flac
        | mulaw
        | ``amr-nb``
        | ``amr-wb``
        | opus
        | speex
        | g729

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type mode =
        | general
        | medical
        | finance

module Ai_Cf_Deepgram_Nova_3_Output =

    [<Global>]
    [<AllowNullLiteral>]
    type results
        [<ParamObject; Emit("$0")>]
        (
            ?channels: ResizeArray<Ai_Cf_Deepgram_Nova_3_Output.results.channels>,
            ?summary: Ai_Cf_Deepgram_Nova_3_Output.results.summary,
            ?sentiments: Ai_Cf_Deepgram_Nova_3_Output.results.sentiments
        ) =

        member val channels : ResizeArray<Ai_Cf_Deepgram_Nova_3_Output.results.channels> option = nativeOnly with get, set
        member val summary : Ai_Cf_Deepgram_Nova_3_Output.results.summary option = nativeOnly with get, set
        member val sentiments : Ai_Cf_Deepgram_Nova_3_Output.results.sentiments option = nativeOnly with get, set

    module results =

        [<Global>]
        [<AllowNullLiteral>]
        type channels
            [<ParamObject; Emit("$0")>]
            (
                ?alternatives: ResizeArray<Ai_Cf_Deepgram_Nova_3_Output.results.channels.alternatives>
            ) =

            member val alternatives : ResizeArray<Ai_Cf_Deepgram_Nova_3_Output.results.channels.alternatives> option = nativeOnly with get, set

        [<Global>]
        [<AllowNullLiteral>]
        type summary
            [<ParamObject; Emit("$0")>]
            (
                ?result: string,
                ?short: string
            ) =

            member val result : string option = nativeOnly with get, set
            member val short : string option = nativeOnly with get, set

        [<Global>]
        [<AllowNullLiteral>]
        type sentiments
            [<ParamObject; Emit("$0")>]
            (
                ?segments: ResizeArray<Ai_Cf_Deepgram_Nova_3_Output.results.sentiments.segments>,
                ?average: Ai_Cf_Deepgram_Nova_3_Output.results.sentiments.average
            ) =

            member val segments : ResizeArray<Ai_Cf_Deepgram_Nova_3_Output.results.sentiments.segments> option = nativeOnly with get, set
            member val average : Ai_Cf_Deepgram_Nova_3_Output.results.sentiments.average option = nativeOnly with get, set

        module channels =

            [<Global>]
            [<AllowNullLiteral>]
            type alternatives
                [<ParamObject; Emit("$0")>]
                (
                    ?confidence: float,
                    ?transcript: string,
                    ?words: ResizeArray<Ai_Cf_Deepgram_Nova_3_Output.results.channels.alternatives.words>
                ) =

                member val confidence : float option = nativeOnly with get, set
                member val transcript : string option = nativeOnly with get, set
                member val words : ResizeArray<Ai_Cf_Deepgram_Nova_3_Output.results.channels.alternatives.words> option = nativeOnly with get, set

            module alternatives =

                [<Global>]
                [<AllowNullLiteral>]
                type words
                    [<ParamObject; Emit("$0")>]
                    (
                        ?confidence: float,
                        ?``end``: float,
                        ?start: float,
                        ?word: string
                    ) =

                    member val confidence : float option = nativeOnly with get, set
                    member val ``end`` : float option = nativeOnly with get, set
                    member val start : float option = nativeOnly with get, set
                    member val word : string option = nativeOnly with get, set

        module sentiments =

            [<Global>]
            [<AllowNullLiteral>]
            type segments
                [<ParamObject; Emit("$0")>]
                (
                    ?text: string,
                    ?start_word: float,
                    ?end_word: float,
                    ?sentiment: string,
                    ?sentiment_score: float
                ) =

                member val text : string option = nativeOnly with get, set
                member val start_word : float option = nativeOnly with get, set
                member val end_word : float option = nativeOnly with get, set
                member val sentiment : string option = nativeOnly with get, set
                member val sentiment_score : float option = nativeOnly with get, set

            [<Global>]
            [<AllowNullLiteral>]
            type average
                [<ParamObject; Emit("$0")>]
                (
                    ?sentiment: string,
                    ?sentiment_score: float
                ) =

                member val sentiment : string option = nativeOnly with get, set
                member val sentiment_score : float option = nativeOnly with get, set

module Ai_Cf_Pipecat_Ai_Smart_Turn_V2_Input =

    [<Global>]
    [<AllowNullLiteral>]
    type audio
        [<ParamObject; Emit("$0")>]
        (
            body: obj,
            contentType: string
        ) =

        member val body : obj = nativeOnly with get, set
        member val contentType : string = nativeOnly with get, set

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type dtype =
        | uint8
        | float32
        | float64

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type dtype =
        | uint8
        | float32
        | float64

module Ai_Cf_Deepgram_Aura_1_Input =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type speaker =
        | angus
        | asteria
        | arcas
        | orion
        | orpheus
        | athena
        | luna
        | zeus
        | perseus
        | helios
        | hera
        | stella

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type encoding =
        | linear16
        | flac
        | mulaw
        | alaw
        | mp3
        | opus
        | aac

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type container =
        | none
        | wav
        | ogg

module Ai_Cf_Ai4Bharat_Indictrans2_En_Indic_1B_Input =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type target_language =
        | asm_Beng
        | awa_Deva
        | ben_Beng
        | bho_Deva
        | brx_Deva
        | doi_Deva
        | eng_Latn
        | gom_Deva
        | gon_Deva
        | guj_Gujr
        | hin_Deva
        | hne_Deva
        | kan_Knda
        | kas_Arab
        | kas_Deva
        | kha_Latn
        | lus_Latn
        | mag_Deva
        | mai_Deva
        | mal_Mlym
        | mar_Deva
        | mni_Beng
        | mni_Mtei
        | npi_Deva
        | ory_Orya
        | pan_Guru
        | san_Deva
        | sat_Olck
        | snd_Arab
        | snd_Deva
        | tam_Taml
        | tel_Telu
        | urd_Arab
        | unr_Deva

module Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_JSON_Mode =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type ``type`` =
        | json_object
        | json_schema

module Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Messages =

    [<Global>]
    [<AllowNullLiteral>]
    type messages
        [<ParamObject; Emit("$0")>]
        (
            role: string,
            content: string
        ) =

        member val role : string = nativeOnly with get, set
        member val content : string = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type functions
        [<ParamObject; Emit("$0")>]
        (
            name: string,
            code: string
        ) =

        member val name : string = nativeOnly with get, set
        member val code : string = nativeOnly with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type tools =
        /// <summary>
        /// The name of the tool. More descriptive the better.
        /// </summary>
        abstract member name: string with get, set
        /// <summary>
        /// A brief description of what the tool does.
        /// </summary>
        abstract member description: string with get, set
        /// <summary>
        /// Schema defining the parameters accepted by the tool.
        /// </summary>
        abstract member parameters: Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Messages.tools.parameters with get, set
        /// <summary>
        /// Specifies the type of tool (e.g., 'function').
        /// </summary>
        abstract member ``type``: string with get, set
        /// <summary>
        /// Details of the function tool.
        /// </summary>
        abstract member ``function``: Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Messages.tools.``function`` with get, set

    module tools =

        [<Global>]
        [<AllowNullLiteral>]
        type parameters
            [<ParamObject; Emit("$0")>]
            (
                ``type``: string,
                properties: Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Messages.tools.parameters.properties,
                ?required: ResizeArray<string>
            ) =

            member val ``type`` : string = nativeOnly with get, set
            member val properties : Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Messages.tools.parameters.properties = nativeOnly with get, set
            member val required : ResizeArray<string> option = nativeOnly with get, set

        [<Global>]
        [<AllowNullLiteral>]
        type ``function``
            [<ParamObject; Emit("$0")>]
            (
                name: string,
                description: string,
                parameters: Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Messages.tools.``function``.parameters
            ) =

            member val name : string = nativeOnly with get, set
            member val description : string = nativeOnly with get, set
            member val parameters : Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Messages.tools.``function``.parameters = nativeOnly with get, set

        module parameters =

            [<AllowNullLiteral>]
            [<Interface>]
            type properties =
                [<EmitIndexer>]
                abstract member Item: k: string -> Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Messages.tools.parameters.properties.Item with get, set

            module properties =

                [<Global>]
                [<AllowNullLiteral>]
                type Item
                    [<ParamObject; Emit("$0")>]
                    (
                        ``type``: string,
                        description: string
                    ) =

                    member val ``type`` : string = nativeOnly with get, set
                    member val description : string = nativeOnly with get, set

        module ``function`` =

            [<Global>]
            [<AllowNullLiteral>]
            type parameters
                [<ParamObject; Emit("$0")>]
                (
                    ``type``: string,
                    properties: Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Messages.tools.``function``.parameters.properties,
                    ?required: ResizeArray<string>
                ) =

                member val ``type`` : string = nativeOnly with get, set
                member val properties : Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Messages.tools.``function``.parameters.properties = nativeOnly with get, set
                member val required : ResizeArray<string> option = nativeOnly with get, set

            module parameters =

                [<AllowNullLiteral>]
                [<Interface>]
                type properties =
                    [<EmitIndexer>]
                    abstract member Item: k: string -> Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Messages.tools.``function``.parameters.properties.Item with get, set

                module properties =

                    [<Global>]
                    [<AllowNullLiteral>]
                    type Item
                        [<ParamObject; Emit("$0")>]
                        (
                            ``type``: string,
                            description: string
                        ) =

                        member val ``type`` : string = nativeOnly with get, set
                        member val description : string = nativeOnly with get, set

module Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_JSON_Mode_1 =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type ``type`` =
        | json_object
        | json_schema

module Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_JSON_Mode_2 =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type ``type`` =
        | json_object
        | json_schema

module Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Messages_1 =

    [<Global>]
    [<AllowNullLiteral>]
    type messages
        [<ParamObject; Emit("$0")>]
        (
            role: string,
            content: string
        ) =

        member val role : string = nativeOnly with get, set
        member val content : string = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type functions
        [<ParamObject; Emit("$0")>]
        (
            name: string,
            code: string
        ) =

        member val name : string = nativeOnly with get, set
        member val code : string = nativeOnly with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type tools =
        /// <summary>
        /// The name of the tool. More descriptive the better.
        /// </summary>
        abstract member name: string with get, set
        /// <summary>
        /// A brief description of what the tool does.
        /// </summary>
        abstract member description: string with get, set
        /// <summary>
        /// Schema defining the parameters accepted by the tool.
        /// </summary>
        abstract member parameters: Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Messages_1.tools.parameters with get, set
        /// <summary>
        /// Specifies the type of tool (e.g., 'function').
        /// </summary>
        abstract member ``type``: string with get, set
        /// <summary>
        /// Details of the function tool.
        /// </summary>
        abstract member ``function``: Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Messages_1.tools.``function`` with get, set

    module tools =

        [<Global>]
        [<AllowNullLiteral>]
        type parameters
            [<ParamObject; Emit("$0")>]
            (
                ``type``: string,
                properties: Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Messages_1.tools.parameters.properties,
                ?required: ResizeArray<string>
            ) =

            member val ``type`` : string = nativeOnly with get, set
            member val properties : Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Messages_1.tools.parameters.properties = nativeOnly with get, set
            member val required : ResizeArray<string> option = nativeOnly with get, set

        [<Global>]
        [<AllowNullLiteral>]
        type ``function``
            [<ParamObject; Emit("$0")>]
            (
                name: string,
                description: string,
                parameters: Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Messages_1.tools.``function``.parameters
            ) =

            member val name : string = nativeOnly with get, set
            member val description : string = nativeOnly with get, set
            member val parameters : Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Messages_1.tools.``function``.parameters = nativeOnly with get, set

        module parameters =

            [<AllowNullLiteral>]
            [<Interface>]
            type properties =
                [<EmitIndexer>]
                abstract member Item: k: string -> Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Messages_1.tools.parameters.properties.Item with get, set

            module properties =

                [<Global>]
                [<AllowNullLiteral>]
                type Item
                    [<ParamObject; Emit("$0")>]
                    (
                        ``type``: string,
                        description: string
                    ) =

                    member val ``type`` : string = nativeOnly with get, set
                    member val description : string = nativeOnly with get, set

        module ``function`` =

            [<Global>]
            [<AllowNullLiteral>]
            type parameters
                [<ParamObject; Emit("$0")>]
                (
                    ``type``: string,
                    properties: Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Messages_1.tools.``function``.parameters.properties,
                    ?required: ResizeArray<string>
                ) =

                member val ``type`` : string = nativeOnly with get, set
                member val properties : Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Messages_1.tools.``function``.parameters.properties = nativeOnly with get, set
                member val required : ResizeArray<string> option = nativeOnly with get, set

            module parameters =

                [<AllowNullLiteral>]
                [<Interface>]
                type properties =
                    [<EmitIndexer>]
                    abstract member Item: k: string -> Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Messages_1.tools.``function``.parameters.properties.Item with get, set

                module properties =

                    [<Global>]
                    [<AllowNullLiteral>]
                    type Item
                        [<ParamObject; Emit("$0")>]
                        (
                            ``type``: string,
                            description: string
                        ) =

                        member val ``type`` : string = nativeOnly with get, set
                        member val description : string = nativeOnly with get, set

module Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_JSON_Mode_3 =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type ``type`` =
        | json_object
        | json_schema

module Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Chat_Completion_Response =

    [<Global>]
    [<AllowNullLiteral>]
    type choices
        [<ParamObject; Emit("$0")>]
        (
            ?index: float,
            ?message: Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Chat_Completion_Response.choices.message,
            ?finish_reason: string,
            ?stop_reason: U2<string, obj>,
            ?logprobs: U2<Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Chat_Completion_Response.choices.logprobs.U2.Case1, obj>
        ) =

        member val index : float option = nativeOnly with get, set
        member val message : Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Chat_Completion_Response.choices.message option = nativeOnly with get, set
        member val finish_reason : string option = nativeOnly with get, set
        member val stop_reason : U2<string, obj> option = nativeOnly with get, set
        member val logprobs : U2<Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Chat_Completion_Response.choices.logprobs.U2.Case1, obj> option = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type usage
        [<ParamObject; Emit("$0")>]
        (
            ?prompt_tokens: float,
            ?completion_tokens: float,
            ?total_tokens: float
        ) =

        member val prompt_tokens : float option = nativeOnly with get, set
        member val completion_tokens : float option = nativeOnly with get, set
        member val total_tokens : float option = nativeOnly with get, set

    module choices =

        [<Global>]
        [<AllowNullLiteral>]
        type message
            [<ParamObject; Emit("$0")>]
            (
                role: string,
                content: string,
                ?reasoning_content: string,
                ?tool_calls: ResizeArray<Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Chat_Completion_Response.choices.message.tool_calls>
            ) =

            member val role : string = nativeOnly with get, set
            member val content : string = nativeOnly with get, set
            member val reasoning_content : string option = nativeOnly with get, set
            member val tool_calls : ResizeArray<Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Chat_Completion_Response.choices.message.tool_calls> option = nativeOnly with get, set

        module message =

            [<Global>]
            [<AllowNullLiteral>]
            type tool_calls
                [<ParamObject; Emit("$0")>]
                (
                    id: string,
                    ``type``: string,
                    ``function``: Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Chat_Completion_Response.choices.message.tool_calls.``function``
                ) =

                member val id : string = nativeOnly with get, set
                member val ``type`` : string = nativeOnly with get, set
                member val ``function`` : Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Chat_Completion_Response.choices.message.tool_calls.``function`` = nativeOnly with get, set

            module tool_calls =

                [<Global>]
                [<AllowNullLiteral>]
                type ``function``
                    [<ParamObject; Emit("$0")>]
                    (
                        name: string,
                        arguments: string
                    ) =

                    member val name : string = nativeOnly with get, set
                    member val arguments : string = nativeOnly with get, set

        module logprobs =

            module U2 =

                [<Global>]
                [<AllowNullLiteral>]
                type Case1
                    [<ParamObject; Emit("$0")>]
                    (
                    ) =

                    class end

    module prompt_logprobs =

        module U2 =

            [<Global>]
            [<AllowNullLiteral>]
            type Case1
                [<ParamObject; Emit("$0")>]
                (
                ) =

                class end

module Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Text_Completion_Response =

    [<Global>]
    [<AllowNullLiteral>]
    type choices
        [<ParamObject; Emit("$0")>]
        (
            index: float,
            text: string,
            finish_reason: string,
            ?stop_reason: U2<string, obj>,
            ?logprobs: U2<Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Text_Completion_Response.choices.logprobs.U2.Case1, obj>,
            ?prompt_logprobs: U2<Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Text_Completion_Response.choices.prompt_logprobs.U2.Case1, obj>
        ) =

        member val index : float = nativeOnly with get, set
        member val text : string = nativeOnly with get, set
        member val finish_reason : string = nativeOnly with get, set
        member val stop_reason : U2<string, obj> option = nativeOnly with get, set
        member val logprobs : U2<Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Text_Completion_Response.choices.logprobs.U2.Case1, obj> option = nativeOnly with get, set
        member val prompt_logprobs : U2<Ai_Cf_Aisingapore_Gemma_Sea_Lion_V4_27B_It_Text_Completion_Response.choices.prompt_logprobs.U2.Case1, obj> option = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type usage
        [<ParamObject; Emit("$0")>]
        (
            ?prompt_tokens: float,
            ?completion_tokens: float,
            ?total_tokens: float
        ) =

        member val prompt_tokens : float option = nativeOnly with get, set
        member val completion_tokens : float option = nativeOnly with get, set
        member val total_tokens : float option = nativeOnly with get, set

    module choices =

        module logprobs =

            module U2 =

                [<Global>]
                [<AllowNullLiteral>]
                type Case1
                    [<ParamObject; Emit("$0")>]
                    (
                    ) =

                    class end

        module prompt_logprobs =

            module U2 =

                [<Global>]
                [<AllowNullLiteral>]
                type Case1
                    [<ParamObject; Emit("$0")>]
                    (
                    ) =

                    class end

module Ai_Cf_Deepgram_Flux_Input =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type mip_opt_out =
        | ``true``
        | ``false``

module Ai_Cf_Deepgram_Flux_Output =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type event =
        | Update
        | StartOfTurn
        | EagerEndOfTurn
        | TurnResumed
        | EndOfTurn

    [<Global>]
    [<AllowNullLiteral>]
    type words
        [<ParamObject; Emit("$0")>]
        (
            word: string,
            confidence: float
        ) =

        member val word : string = nativeOnly with get, set
        member val confidence : float = nativeOnly with get, set

module Ai_Cf_Deepgram_Aura_2_En_Input =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type speaker =
        | amalthea
        | andromeda
        | apollo
        | arcas
        | aries
        | asteria
        | athena
        | atlas
        | aurora
        | callista
        | cora
        | cordelia
        | delia
        | draco
        | electra
        | harmonia
        | helena
        | hera
        | hermes
        | hyperion
        | iris
        | janus
        | juno
        | jupiter
        | luna
        | mars
        | minerva
        | neptune
        | odysseus
        | ophelia
        | orion
        | orpheus
        | pandora
        | phoebe
        | pluto
        | saturn
        | thalia
        | theia
        | vesta
        | zeus

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type encoding =
        | linear16
        | flac
        | mulaw
        | alaw
        | mp3
        | opus
        | aac

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type container =
        | none
        | wav
        | ogg

module Ai_Cf_Deepgram_Aura_2_Es_Input =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type speaker =
        | sirio
        | nestor
        | carina
        | celeste
        | alvaro
        | diana
        | aquila
        | selena
        | estrella
        | javier

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type encoding =
        | linear16
        | flac
        | mulaw
        | alaw
        | mp3
        | opus
        | aac

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type container =
        | none
        | wav
        | ogg

module AiModelsSearchObject =

    [<Global>]
    [<AllowNullLiteral>]
    type task
        [<ParamObject; Emit("$0")>]
        (
            id: string,
            name: string,
            description: string
        ) =

        member val id : string = nativeOnly with get, set
        member val name : string = nativeOnly with get, set
        member val description : string = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type properties
        [<ParamObject; Emit("$0")>]
        (
            property_id: string,
            value: string
        ) =

        member val property_id : string = nativeOnly with get, set
        member val value : string = nativeOnly with get, set

module GatewayRetries =

    [<RequireQualifiedAccess>]
    type maxAttempts =
        | ``1`` = 1
        | ``2`` = 2
        | ``3`` = 3
        | ``4`` = 4
        | ``5`` = 5

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type backoff =
        | constant
        | linear
        | exponential

module GatewayOptions =

    [<AllowNullLiteral>]
    [<Interface>]
    type metadata =
        [<EmitIndexer>]
        abstract member Item: key: string -> U5<float, string, bool, obj, obj> with get, set

module AiGatewayPatchLog =

    module metadata =

        module U2 =

            [<AllowNullLiteral>]
            [<Interface>]
            type Case1 =
                [<EmitIndexer>]
                abstract member Item: key: string -> U5<float, string, bool, obj, obj> with get, set

module AiGatewayLog =

    [<AllowNullLiteral>]
    [<Interface>]
    type metadata =
        [<EmitIndexer>]
        abstract member Item: key: string -> U5<float, string, bool, obj, obj> with get, set

module AIGatewayHeaders =

    module ````cf-aig-metadata```` =

        module U2 =

            [<AllowNullLiteral>]
            [<Interface>]
            type Case1 =
                [<EmitIndexer>]
                abstract member Item: key: string -> U5<float, string, bool, obj, obj> with get, set

    module ````cf-aig-custom-cost```` =

        module U3 =

            [<Global>]
            [<AllowNullLiteral>]
            type Case1
                [<ParamObject; Emit("$0")>]
                (
                    ?per_token_in: float,
                    ?per_token_out: float
                ) =

                member val per_token_in : float option = nativeOnly with get, set
                member val per_token_out : float option = nativeOnly with get, set

            [<Global>]
            [<AllowNullLiteral>]
            type Case2
                [<ParamObject; Emit("$0")>]
                (
                    ?total_cost: float
                ) =

                member val total_cost : float option = nativeOnly with get, set

module AIGatewayUniversalRequest =

    [<AllowNullLiteral>]
    [<Interface>]
    type headers =
        abstract member ``cf-aig-metadata``: U2<AIGatewayUniversalRequest.headers.Partial.````cf-aig-metadata````.U2.Case1, string> option with get, set
        abstract member ``cf-aig-custom-cost``: U3<AIGatewayUniversalRequest.headers.Partial.````cf-aig-custom-cost````.U3.Case1, AIGatewayUniversalRequest.headers.Partial.````cf-aig-custom-cost````.U3.Case2, string> option with get, set
        abstract member ``cf-aig-cache-ttl``: U2<float, string> option with get, set
        abstract member ``cf-aig-skip-cache``: U2<bool, string> option with get, set
        abstract member ``cf-aig-cache-key``: string option with get, set
        abstract member ``cf-aig-event-id``: string option with get, set
        abstract member ``cf-aig-request-timeout``: U2<float, string> option with get, set
        abstract member ``cf-aig-max-attempts``: U2<float, string> option with get, set
        abstract member ``cf-aig-retry-delay``: U2<float, string> option with get, set
        abstract member ``cf-aig-backoff``: string option with get, set
        abstract member ``cf-aig-collect-log``: U2<bool, string> option with get, set
        abstract member Authorization: string option with get, set
        abstract member ``Content-Type``: string option with get, set

    module headers =

        module Partial =

            module ````cf-aig-metadata```` =

                module U2 =

                    [<AllowNullLiteral>]
                    [<Interface>]
                    type Case1 =
                        [<EmitIndexer>]
                        abstract member Item: key: string -> U5<float, string, bool, obj, obj> with get, set

            module ````cf-aig-custom-cost```` =

                module U3 =

                    [<Global>]
                    [<AllowNullLiteral>]
                    type Case1
                        [<ParamObject; Emit("$0")>]
                        (
                            ?per_token_in: float,
                            ?per_token_out: float
                        ) =

                        member val per_token_in : float option = nativeOnly with get, set
                        member val per_token_out : float option = nativeOnly with get, set

                    [<Global>]
                    [<AllowNullLiteral>]
                    type Case2
                        [<ParamObject; Emit("$0")>]
                        (
                            ?total_cost: float
                        ) =

                        member val total_cost : float option = nativeOnly with get, set

module AiGateway =

    module run =

        [<Global>]
        [<AllowNullLiteral>]
        type options
            [<ParamObject; Emit("$0")>]
            (
                ?gateway: UniversalGatewayOptions,
                ?extraHeaders: obj
            ) =

            member val gateway : UniversalGatewayOptions option = nativeOnly with get, set
            member val extraHeaders : obj option = nativeOnly with get, set

module ComparisonFilter =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type ``type`` =
        | eq
        | ne
        | gt
        | gte
        | lt
        | lte

module CompoundFilter =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type ``type`` =
        | ``and``
        | ``or``

module AutoRagSearchRequest =

    [<Global>]
    [<AllowNullLiteral>]
    type ranking_options
        [<ParamObject; Emit("$0")>]
        (
            ?ranker: string,
            ?score_threshold: float
        ) =

        member val ranker : string option = nativeOnly with get, set
        member val score_threshold : float option = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type reranking
        [<ParamObject; Emit("$0")>]
        (
            ?enabled: bool,
            ?model: string
        ) =

        member val enabled : bool option = nativeOnly with get, set
        member val model : string option = nativeOnly with get, set

module AutoRagAiSearchRequest =

    [<Global>]
    [<AllowNullLiteral>]
    type ranking_options
        [<ParamObject; Emit("$0")>]
        (
            ?ranker: string,
            ?score_threshold: float
        ) =

        member val ranker : string option = nativeOnly with get, set
        member val score_threshold : float option = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type reranking
        [<ParamObject; Emit("$0")>]
        (
            ?enabled: bool,
            ?model: string
        ) =

        member val enabled : bool option = nativeOnly with get, set
        member val model : string option = nativeOnly with get, set

module AutoRagAiSearchRequestStreaming =

    [<Global>]
    [<AllowNullLiteral>]
    type ranking_options
        [<ParamObject; Emit("$0")>]
        (
            ?ranker: string,
            ?score_threshold: float
        ) =

        member val ranker : string option = nativeOnly with get, set
        member val score_threshold : float option = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type reranking
        [<ParamObject; Emit("$0")>]
        (
            ?enabled: bool,
            ?model: string
        ) =

        member val enabled : bool option = nativeOnly with get, set
        member val model : string option = nativeOnly with get, set

module AutoRagSearchResponse =

    [<Global>]
    [<AllowNullLiteral>]
    type data
        [<ParamObject; Emit("$0")>]
        (
            file_id: string,
            filename: string,
            score: float,
            attributes: AutoRagSearchResponse.data.attributes,
            content: ResizeArray<AutoRagSearchResponse.data.content>
        ) =

        member val file_id : string = nativeOnly with get, set
        member val filename : string = nativeOnly with get, set
        member val score : float = nativeOnly with get, set
        member val attributes : AutoRagSearchResponse.data.attributes = nativeOnly with get, set
        member val content : ResizeArray<AutoRagSearchResponse.data.content> = nativeOnly with get, set

    module data =

        [<AllowNullLiteral>]
        [<Interface>]
        type attributes =
            [<EmitIndexer>]
            abstract member Item: key: string -> U4<string, float, bool, obj> with get, set

        [<Global>]
        [<AllowNullLiteral>]
        type content
            [<ParamObject; Emit("$0")>]
            (
                ``type``: string,
                text: string
            ) =

            member val ``type`` : string = nativeOnly with get, set
            member val text : string = nativeOnly with get, set

module AutoRagAiSearchResponse =

    [<Global>]
    [<AllowNullLiteral>]
    type data
        [<ParamObject; Emit("$0")>]
        (
            file_id: string,
            filename: string,
            score: float,
            attributes: AutoRagAiSearchResponse.data.attributes,
            content: ResizeArray<AutoRagAiSearchResponse.data.content>
        ) =

        member val file_id : string = nativeOnly with get, set
        member val filename : string = nativeOnly with get, set
        member val score : float = nativeOnly with get, set
        member val attributes : AutoRagAiSearchResponse.data.attributes = nativeOnly with get, set
        member val content : ResizeArray<AutoRagAiSearchResponse.data.content> = nativeOnly with get, set

    module data =

        [<AllowNullLiteral>]
        [<Interface>]
        type attributes =
            [<EmitIndexer>]
            abstract member Item: key: string -> U4<string, float, bool, obj> with get, set

        [<Global>]
        [<AllowNullLiteral>]
        type content
            [<ParamObject; Emit("$0")>]
            (
                ``type``: string,
                text: string
            ) =

            member val ``type`` : string = nativeOnly with get, set
            member val text : string = nativeOnly with get, set

module BasicImageTransformations =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type fit =
        | ``scale-down``
        | contain
        | cover
        | crop
        | pad
        | squeeze

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type gravity =
        | face
        | left
        | right
        | top
        | bottom
        | center
        | auto
        | entropy

    [<RequireQualifiedAccess>]
    type rotate =
        | ``0`` = 0
        | ``90`` = 90
        | ``180`` = 180
        | ``270`` = 270
        | ``360`` = 360

module BasicImageTransformationsGravityCoordinates =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type mode =
        | remainder
        | ``box-center``

module RequestInitCfProperties =

    [<AllowNullLiteral>]
    [<Interface>]
    type cacheTtlByStatus =
        [<EmitIndexer>]
        abstract member Item: key: string -> float with get, set

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type polish =
        | lossy
        | lossless
        | off

module RequestInitCfPropertiesImage =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type trim =
        | border

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type quality =
        | low
        | ``medium-low``
        | ``medium-high``
        | high

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type format =
        | avif
        | webp
        | json
        | jpeg
        | png
        | ``baseline-jpeg``
        | ``png-force``
        | svg

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type metadata =
        | keep
        | copyright
        | none

    [<AllowNullLiteral>]
    [<Interface>]
    type border =
        abstract member color: string with get, set
        abstract member width: float with get, set
        abstract member color: string with get, set
        abstract member top: float with get, set
        abstract member right: float with get, set
        abstract member bottom: float with get, set
        abstract member left: float with get, set

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type flip =
        | h
        | v
        | hv

module IncomingRequestCfProperties =

    [<AllowNullLiteral>]
    [<Interface>]
    type botManagement =
        /// <summary>
        /// Cloudflare’s [level of certainty](https://developers.cloudflare.com/bots/concepts/bot-score/) that a request comes from a bot,
        /// represented as an integer percentage between <c>1</c> (almost certainly a bot) and <c>99</c> (almost certainly human).
        /// </summary>
        abstract member score: float with get, set
        /// <summary>
        /// A boolean value that is true if the request comes from a good bot, like Google or Bing.
        /// Most customers choose to allow this traffic. For more details, see [Traffic from known bots](https://developers.cloudflare.com/firewall/known-issues-and-faq/#how-does-firewall-rules-handle-traffic-from-known-bots).
        /// </summary>
        abstract member verifiedBot: bool with get, set
        /// <summary>
        /// A boolean value that is true if the request originates from a
        /// Cloudflare-verified proxy service.
        /// </summary>
        abstract member corporateProxy: bool with get, set
        /// <summary>
        /// A boolean value that's true if the request matches [file extensions](https://developers.cloudflare.com/bots/reference/static-resources/) for many types of static resources.
        /// </summary>
        abstract member staticResource: bool with get, set
        /// <summary>
        /// List of IDs that correlate to the Bot Management heuristic detections made on a request (you can have multiple heuristic detections on the same request).
        /// </summary>
        abstract member detectionIds: ResizeArray<float> with get, set
        /// <summary>
        /// A [JA3 Fingerprint](https://developers.cloudflare.com/bots/concepts/ja3-fingerprint/) to help profile specific SSL/TLS clients
        /// across different destination IPs, Ports, and X509 certificates.
        /// </summary>
        abstract member ja3Hash: string with get, set

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type country =
        | T1

module IncomingRequestCfPropertiesBotManagementEnterprise =

    [<AllowNullLiteral>]
    [<Interface>]
    type botManagement =
        /// <summary>
        /// Cloudflare’s [level of certainty](https://developers.cloudflare.com/bots/concepts/bot-score/) that a request comes from a bot,
        /// represented as an integer percentage between <c>1</c> (almost certainly a bot) and <c>99</c> (almost certainly human).
        /// </summary>
        abstract member score: float with get, set
        /// <summary>
        /// A boolean value that is true if the request comes from a good bot, like Google or Bing.
        /// Most customers choose to allow this traffic. For more details, see [Traffic from known bots](https://developers.cloudflare.com/firewall/known-issues-and-faq/#how-does-firewall-rules-handle-traffic-from-known-bots).
        /// </summary>
        abstract member verifiedBot: bool with get, set
        /// <summary>
        /// A boolean value that is true if the request originates from a
        /// Cloudflare-verified proxy service.
        /// </summary>
        abstract member corporateProxy: bool with get, set
        /// <summary>
        /// A boolean value that's true if the request matches [file extensions](https://developers.cloudflare.com/bots/reference/static-resources/) for many types of static resources.
        /// </summary>
        abstract member staticResource: bool with get, set
        /// <summary>
        /// List of IDs that correlate to the Bot Management heuristic detections made on a request (you can have multiple heuristic detections on the same request).
        /// </summary>
        abstract member detectionIds: ResizeArray<float> with get, set
        /// <summary>
        /// A [JA3 Fingerprint](https://developers.cloudflare.com/bots/concepts/ja3-fingerprint/) to help profile specific SSL/TLS clients
        /// across different destination IPs, Ports, and X509 certificates.
        /// </summary>
        abstract member ja3Hash: string with get, set

module IncomingRequestCfPropertiesGeographicInformation =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type country =
        | T1

module IncomingRequestCfPropertiesTLSClientAuth =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type certVerified =
        | SUCCESS
        | ``FAILED:self signed certificate``
        | ``FAILED:unable to verify the first certificate``
        | ``FAILED:certificate is not yet valid``
        | ``FAILED:certificate has expired``
        | FAILED

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type certRevoked =
        | ``1``
        | ``0``

module D1Meta =

    [<Global>]
    [<AllowNullLiteral>]
    type timings
        [<ParamObject; Emit("$0")>]
        (
            sql_duration_ms: float
        ) =

        member val sql_duration_ms : float = nativeOnly with get, set

module D1Response =

    [<AllowNullLiteral>]
    [<Interface>]
    type meta =
        abstract member duration: float with get, set
        abstract member size_after: float with get, set
        abstract member rows_read: float with get, set
        abstract member rows_written: float with get, set
        abstract member last_row_id: float with get, set
        abstract member changed_db: bool with get, set
        abstract member changes: float with get, set
        /// <summary>
        /// The region of the database instance that executed the query.
        /// </summary>
        abstract member served_by_region: string option with get, set
        /// <summary>
        /// The three letters airport code of the colo that executed the query.
        /// </summary>
        abstract member served_by_colo: string option with get, set
        /// <summary>
        /// True if-and-only-if the database instance that executed the query was the primary.
        /// </summary>
        abstract member served_by_primary: bool option with get, set
        abstract member timings: D1Response.meta.timings option with get, set
        /// <summary>
        /// Number of total attempts to execute the query, due to automatic retries.
        /// Note: All other fields in the response like <c>timings</c> only apply to the last attempt.
        /// </summary>
        abstract member total_attempts: float option with get, set

    module meta =

        [<Global>]
        [<AllowNullLiteral>]
        type timings
            [<ParamObject; Emit("$0")>]
            (
                sql_duration_ms: float
            ) =

            member val sql_duration_ms : float = nativeOnly with get, set

module D1Result =

    [<AllowNullLiteral>]
    [<Interface>]
    type meta =
        abstract member duration: float with get, set
        abstract member size_after: float with get, set
        abstract member rows_read: float with get, set
        abstract member rows_written: float with get, set
        abstract member last_row_id: float with get, set
        abstract member changed_db: bool with get, set
        abstract member changes: float with get, set
        /// <summary>
        /// The region of the database instance that executed the query.
        /// </summary>
        abstract member served_by_region: string option with get, set
        /// <summary>
        /// The three letters airport code of the colo that executed the query.
        /// </summary>
        abstract member served_by_colo: string option with get, set
        /// <summary>
        /// True if-and-only-if the database instance that executed the query was the primary.
        /// </summary>
        abstract member served_by_primary: bool option with get, set
        abstract member timings: D1Result.meta.timings option with get, set
        /// <summary>
        /// Number of total attempts to execute the query, due to automatic retries.
        /// Note: All other fields in the response like <c>timings</c> only apply to the last attempt.
        /// </summary>
        abstract member total_attempts: float option with get, set

    module meta =

        [<Global>]
        [<AllowNullLiteral>]
        type timings
            [<ParamObject; Emit("$0")>]
            (
                sql_duration_ms: float
            ) =

            member val sql_duration_ms : float = nativeOnly with get, set

module D1PreparedStatement =

    module raw =

        [<Global>]
        [<AllowNullLiteral>]
        type options
            [<ParamObject; Emit("$0")>]
            (
                columnNames: bool
            ) =

            member val columnNames : bool = nativeOnly with get, set

        [<Global>]
        [<AllowNullLiteral>]
        type options_1
            [<ParamObject; Emit("$0")>]
            (
                ?columnNames: bool
            ) =

            member val columnNames : bool option = nativeOnly with get, set

module SendEmail =

    module send =

        [<Global>]
        [<AllowNullLiteral>]
        type builder
            [<ParamObject; Emit("$0")>]
            (
                from: U2<string, EmailAddress>,
                ``to``: U2<string, ResizeArray<string>>,
                subject: string,
                ?replyTo: U2<string, EmailAddress>,
                ?cc: U2<string, ResizeArray<string>>,
                ?bcc: U2<string, ResizeArray<string>>,
                ?headers: SendEmail.send.builder.headers,
                ?text: string,
                ?html: string,
                ?attachments: ResizeArray<EmailAttachment>
            ) =

            member val from : U2<string, EmailAddress> = nativeOnly with get, set
            member val ``to`` : U2<string, ResizeArray<string>> = nativeOnly with get, set
            member val subject : string = nativeOnly with get, set
            member val replyTo : U2<string, EmailAddress> option = nativeOnly with get, set
            member val cc : U2<string, ResizeArray<string>> option = nativeOnly with get, set
            member val bcc : U2<string, ResizeArray<string>> option = nativeOnly with get, set
            member val headers : SendEmail.send.builder.headers option = nativeOnly with get, set
            member val text : string option = nativeOnly with get, set
            member val html : string option = nativeOnly with get, set
            member val attachments : ResizeArray<EmailAttachment> option = nativeOnly with get, set

        module builder =

            [<AllowNullLiteral>]
            [<Interface>]
            type headers =
                [<EmitIndexer>]
                abstract member Item: key: string -> string with get, set

module HelloWorldBinding =

    [<Global>]
    [<AllowNullLiteral>]
    type get
        [<ParamObject; Emit("$0")>]
        (
            value: string,
            ?ms: float
        ) =

        member val value : string = nativeOnly with get, set
        member val ms : float option = nativeOnly with get, set

module ImageTransform =

    [<AllowNullLiteral>]
    [<Interface>]
    type border =
        abstract member color: string option with get, set
        abstract member width: float option with get, set
        abstract member top: float option with get, set
        abstract member bottom: float option with get, set
        abstract member left: float option with get, set
        abstract member right: float option with get, set

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type fit =
        | ``scale-down``
        | contain
        | pad
        | squeeze
        | cover
        | crop

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type flip =
        | h
        | v
        | hv

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type gravity =
        | face
        | left
        | right
        | top
        | bottom
        | center
        | auto
        | entropy

    [<RequireQualifiedAccess>]
    type rotate =
        | ``0`` = 0
        | ``90`` = 90
        | ``180`` = 180
        | ``270`` = 270

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type trim =
        | border

module ImageOutputOptions =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type format =
        | image/jpeg
        | image/png
        | image/gif
        | image/webp
        | image/avif
        | rgb
        | rgba

module ImageMetadata =

    [<AllowNullLiteral>]
    [<Interface>]
    type meta =
        [<EmitIndexer>]
        abstract member Item: key: string -> obj with get, set

module ImageUploadOptions =

    [<AllowNullLiteral>]
    [<Interface>]
    type metadata =
        [<EmitIndexer>]
        abstract member Item: key: string -> obj with get, set

module ImageUpdateOptions =

    [<AllowNullLiteral>]
    [<Interface>]
    type metadata =
        [<EmitIndexer>]
        abstract member Item: key: string -> obj with get, set

module ImageListOptions =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type sortOrder =
        | asc
        | desc

module MediaTransformationInputOptions =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type fit =
        | contain
        | cover
        | ``scale-down``

module MediaTransformationOutputOptions =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type mode =
        | video
        | spritesheet
        | frame
        | audio

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type format =
        | jpg
        | png
        | m4a

module EventContext =

    type next =
        delegate of ?input: U2<Request, string> * ?init: RequestInit -> JS.Promise<Response>

    [<AllowNullLiteral>]
    [<Interface>]
    type env =
        abstract member ASSETS: EventContext.env.ASSETS with get, set

    module env =

        [<Global>]
        [<AllowNullLiteral>]
        type ASSETS
            [<ParamObject; Emit("$0")>]
            (
                fetch: (U2<RequestInfo, URL> -> RequestInit option -> JS.Promise<Response>)
            ) =

            member val fetch : (U2<RequestInfo, URL> -> RequestInit option -> JS.Promise<Response>) = nativeOnly with get, set

module EventPluginContext =

    type next =
        delegate of ?input: U2<Request, string> * ?init: RequestInit -> JS.Promise<Response>

    [<AllowNullLiteral>]
    [<Interface>]
    type env =
        abstract member ASSETS: EventPluginContext.env.ASSETS with get, set

    module env =

        [<Global>]
        [<AllowNullLiteral>]
        type ASSETS
            [<ParamObject; Emit("$0")>]
            (
                fetch: (U2<RequestInfo, URL> -> RequestInit option -> JS.Promise<Response>)
            ) =

            member val fetch : (U2<RequestInfo, URL> -> RequestInit option -> JS.Promise<Response>) = nativeOnly with get, set

module ImageConversionOptions =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type descriptionLanguage =
        | en
        | es
        | fr
        | it
        | pt
        | de

module EmbeddedImageConversionOptions =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type descriptionLanguage =
        | en
        | es
        | fr
        | it
        | pt
        | de

module ConversionOptions =

    [<Global>]
    [<AllowNullLiteral>]
    type html
        [<ParamObject; Emit("$0")>]
        (
            ?images: ConversionOptions.html.images,
            ?hostname: string,
            ?cssSelector: string
        ) =

        member val images : ConversionOptions.html.images option = nativeOnly with get, set
        member val hostname : string option = nativeOnly with get, set
        member val cssSelector : string option = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type docx
        [<ParamObject; Emit("$0")>]
        (
            ?images: EmbeddedImageConversionOptions
        ) =

        member val images : EmbeddedImageConversionOptions option = nativeOnly with get, set

    [<Global>]
    [<AllowNullLiteral>]
    type pdf
        [<ParamObject; Emit("$0")>]
        (
            ?images: EmbeddedImageConversionOptions,
            ?metadata: bool
        ) =

        member val images : EmbeddedImageConversionOptions option = nativeOnly with get, set
        member val metadata : bool option = nativeOnly with get, set

    module html =

        [<AllowNullLiteral>]
        [<Interface>]
        type images =
            abstract member descriptionLanguage: ConversionOptions.html.images.descriptionLanguage option with get, set
            abstract member convert: bool option with get, set
            abstract member maxConvertedImages: float option with get, set
            abstract member convertOGImage: bool option with get, set

        module images =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type descriptionLanguage =
                | en
                | es
                | fr
                | it
                | pt
                | de

module VectorizeVectorMetadata =

    module U2 =

        [<AllowNullLiteral>]
        [<Interface>]
        type Case2 =
            [<EmitIndexer>]
            abstract member Item: key: string -> VectorizeVectorMetadataValue with get, set

module VectorizeVectorMetadataFilter =

    module Item =

        module U4 =

            [<AllowNullLiteral>]
            [<Interface>]
            type Case1 =
                interface end

module VectorizeVector =

    [<AllowNullLiteral>]
    [<Interface>]
    type metadata =
        [<EmitIndexer>]
        abstract member Item: key: string -> VectorizeVectorMetadata with get, set

module VectorizeMatch =

    [<AllowNullLiteral>]
    [<Interface>]
    type metadata =
        [<EmitIndexer>]
        abstract member Item: key: string -> VectorizeVectorMetadata with get, set

module DynamicDispatchOptions =

    [<AllowNullLiteral>]
    [<Interface>]
    type outbound =
        [<EmitIndexer>]
        abstract member Item: key: string -> obj with get, set

module DispatchNamespace =

    module get =

        [<AllowNullLiteral>]
        [<Interface>]
        type args =
            [<EmitIndexer>]
            abstract member Item: key: string -> obj with get, set

module WorkflowInstanceCreateOptions =

    [<Global>]
    [<AllowNullLiteral>]
    type retention
        [<ParamObject; Emit("$0")>]
        (
            ?successRetention: WorkflowRetentionDuration,
            ?errorRetention: WorkflowRetentionDuration
        ) =

        member val successRetention : WorkflowRetentionDuration option = nativeOnly with get, set
        member val errorRetention : WorkflowRetentionDuration option = nativeOnly with get, set

module InstanceStatus =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type status =
        | queued
        | running
        | paused
        | errored
        | terminated
        | complete
        | waiting
        | waitingForPause
        | unknown

    [<Global>]
    [<AllowNullLiteral>]
    type error
        [<ParamObject; Emit("$0")>]
        (
            name: string,
            message: string
        ) =

        member val name : string = nativeOnly with get, set
        member val message : string = nativeOnly with get, set

module WorkflowInstance =

    module sendEvent =

        [<Global>]
        [<AllowNullLiteral>]
        type arg0
            [<ParamObject; Emit("$0")>]
            (
                ``type``: string,
                payload: obj
            ) =

            member val ``type`` : string = nativeOnly with get, set
            member val payload : obj = nativeOnly with get, set

module Exports =

    [<AllowNullLiteral>]
    [<Interface>]
    type EventTarget =
        [<EmitIndexer>]
        abstract member Item: key: string -> Event with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type EventTarget_1 =
        [<EmitIndexer>]
        abstract member Item: key: string -> Event with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type SqlStorageCursor =
        [<EmitIndexer>]
        abstract member Item: key: string -> SqlStorageValue with get, set

    module CompressionStream =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type format =
            | gzip
            | deflate
            | ``deflate-raw``

    module DecompressionStream =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type format =
            | gzip
            | deflate
            | ``deflate-raw``

    module URLSearchParams =

        module init =

            module U4 =

                [<AllowNullLiteral>]
                [<Interface>]
                type Case3 =
                    [<EmitIndexer>]
                    abstract member Item: key: string -> string with get, set
