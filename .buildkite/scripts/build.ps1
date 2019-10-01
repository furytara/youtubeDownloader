Write-Output "Build value $env:BUILDKITE_OUTPUT"

IF  ($env:BUILDKITE_OUTPUT -eq 0) {
	Write-Output "--- Build Failure.";
	throw "Build Fail. Error occured";
}

Write-Output "--- Build Success";
