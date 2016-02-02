 /// Licensed to the Apache Software Foundation (ASF) under one or more
 /// contributor license agreements.  See the NOTICE file distributed with
 /// this work for additional information regarding copyright ownership.
 /// The ASF licenses this file to You under the Apache License, Version 2.0
 /// (the "License"); you may not use this file except in compliance with
 /// the License.  You may obtain a copy of the License at
 ///
 ///     http://www.apache.org/licenses/LICENSE-2.0
 ///
 /// Unless required by applicable law or agreed to in writing, software
 /// distributed under the License is distributed on an "AS IS" BASIS,
 /// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 /// See the License for the specific language governing permissions and
 /// limitations under the License.


using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using javax.naming;
using javax.sql;

using org.apache.mahout.cf.taste.common;
using org.slf4j;

using com.google.common.base;

namespace org.apache.mahout.cf.taste.impl.common.jdbc {

 /// A helper class with common elements for several JDBC-related components.
public abstract class AbstractJDBCComponent {
  
  private static Logger log = LoggerFactory.getLogger(AbstractJDBCComponent.class);
  
  private static int DEFAULT_FETCH_SIZE = 1000; // A max, "big" number of rows to buffer at once
  protected static final String DEFAULT_DATASOURCE_NAME = "jdbc/taste";
  
  protected static void checkNotNullAndLog(String argName, Object value) {
    Preconditions.checkArgument(value != null && !value.toString().isEmpty(),
      argName + " is null or empty");
    log.debug("{}: {}", argName, value);
  }
  
  protected static void checkNotNullAndLog(String argName, Object[] values) {
    Preconditions.checkArgument(values != null && values.Length != 0, argName + " is null or zero-length");
    for (Object value : values) {
      checkNotNullAndLog(argName, value);
    }
  }
  
   /// <p>
   /// Looks up a {@link DataSource} by name from JNDI. "java:comp/env/" is prepended to the argument before
   /// looking up the name in JNDI.
   /// </p>
   /// 
   /// @param dataSourceName
   ///          JNDI name where a {@link DataSource} is bound (e.g. "jdbc/taste")
   /// @return {@link DataSource} under that JNDI name
   /// @throws TasteException
   ///           if a JNDI error occurs
  public static DataSource lookupDataSource(String dataSourceName) {
    Context context = null;
    try {
      context = new InitialContext();
      return (DataSource) context.lookup("java:comp/env/" + dataSourceName);
    } catch (NamingException ne) {
      throw new TasteException(ne);
    } finally {
      if (context != null) {
        try {
          context.close();
        } catch (NamingException ne) {
          log.warn("Error while closing Context; continuing...", ne);
        }
      }
    }
  }
  
  protected int getFetchSize() {
    return DEFAULT_FETCH_SIZE;
  }
  
}

}