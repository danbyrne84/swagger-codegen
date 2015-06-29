#!/bin/sh

SCRIPT="$0"

while [ -h "$SCRIPT" ] ; do
  ls=`ls -ld "$SCRIPT"`
  link=`expr "$ls" : '.*-> \(.*\)$'`
  if expr "$link" : '/.*' > /dev/null; then
    SCRIPT="$link"
  else
    SCRIPT=`dirname "$SCRIPT"`/"$link"
  fi
done

if [ ! -d "${APP_DIR}" ]; then
  APP_DIR=`dirname "$SCRIPT"`/..
  APP_DIR=`cd "${APP_DIR}"; pwd`
fi

executable="./modules/swagger-codegen-cli/target/swagger-codegen-cli.jar"

if [ ! -f "$executable" ]
then
  mvn clean package
fi

# if you've executed sbt assembly previously it will use that instead.
export JAVA_OPTS="${JAVA_OPTS} -XX:MaxPermSize=256M -Xmx1024M -DloggerPath=conf/log4j.properties"
#ags="$@ generate -t modules/swagger-codegen/src/main/resources/webapi -i modules/swagger-codegen/src/test/resources/2_0/petstore.json -l WebApi -l io.swagger.codegen.languages.WebApiCodegen -o samples/server/petstore/webapi"

ags="$@ generate -t modules/swagger-codegen/src/main/resources/webapi -i https://raw.githubusercontent.com/SaleCycle/salecycle_api/master/doc/salecycle-api.yaml?token=ABaOQE4q57uRPTT364Xk4A3EOm7i8aVLks5Vlrs1wA%3D%3D -l WebApi -l io.swagger.codegen.languages.WebApiCodegen -o samples/server/petstore/webapi"
java $JAVA_OPTS -jar $executable $ags
