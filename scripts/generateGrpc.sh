TOOLS_PATH='/home/jpichardo/.nuget/packages/grpc.tools/1.9.0-pre2/tools/linux_x64';

for i in `find ./jp.tamagotchi.proto.business/service -name '*.proto'` ; 
do $TOOLS_PATH/protoc -I ./ --csharp_out ./Services $i --grpc_out ./Services --plugin=protoc-gen-grpc=$TOOLS_PATH/grpc_csharp_plugin ;
done
