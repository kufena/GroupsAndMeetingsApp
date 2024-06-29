
aws s3 cp .\cognito.yaml s3://thegatehousewereham-cftemplates/cognito.yaml

aws cloudformation create-stack --stack-name CandMStack2 --template-url https://thegatehousewereham-cftemplates.s3.eu-west-2.amazonaws.com/cognito.yaml --parameters ParameterKey=CallBackURL,ParameterValue=https://localhost:8081/SignUp
