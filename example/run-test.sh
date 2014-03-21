#!/bin/sh

EXPECTED_ARGS=1

if [ $# -ne $EXPECTED_ARGS ]
then
  echo "Usage: `basename $0` compiled-example-to-execute"
  exit $E_BADARGS
fi

export MONO_PATH=$MONO_PATH:../module/

mono $1


