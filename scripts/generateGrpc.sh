TOOLS_PATH='/home/jpichardo/.nuget/packages/grpc.tools/1.9.0-pre2/tools/linux_x64';


$TOOLS_PATH/protoc -I ../jp.tamagotchi.proto.business/service/ --csharp_out jp.tamagotchi.shared ../Shared --grpc_out jp.tamagotchi.shared --plugin=protoc-gen-grpc=$TOOLS_PATH/grpc_csharp_plugin
