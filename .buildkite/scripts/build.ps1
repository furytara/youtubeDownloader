Write-Output "Build value ${Env:BUILDKITE_OUTPUT}"

IF  (${Env:BUILDKITE_OUTPUT} -eq 1) {
	Write-Output "-Build Failure.";
	throw "Build Fail. Error occured";
}

Write-Output "-Build Success";
